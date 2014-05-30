using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    /**
     * Main UI for gameplay.
     */
    public partial class GameForm : Form
    {
		// Anti-flicker
		int originalExStyle = -1;
		bool enableFormLevelDoubleBuffering = true;
		protected override CreateParams CreateParams
		{
			get
			{
				if (originalExStyle == -1)
					originalExStyle = base.CreateParams.ExStyle;
				CreateParams cp = base.CreateParams;
				if (enableFormLevelDoubleBuffering)
					cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
				else
					cp.ExStyle = originalExStyle;
				return cp;
			}
		}
		private void TurnOffFormLevelDoubleBuffering()
		{
			enableFormLevelDoubleBuffering = false;
			this.MaximizeBox = true;
		}
		private void frmMain_Shown(object sender, EventArgs e)
		{
			TurnOffFormLevelDoubleBuffering();
		}
		const int MOVEMENT_CONSTANT = 5, LEFT_RIGHT = 0, UP_DOWN = 1, X_COORD = 0, Y_COORD = 1, MAX_CAVES = 6, 
            DIMENSIONS = 2, GAME_AREA_HEIGHT = 603;
        const double COLLISION_STRETCH_FACTOR = 1.5; // Not quite sqrt(2) in collision detection, to make it slightly more fluid.
		PictureBox[] caves; // Array of caves for easy access.
		Label[] caveLabels; // Array of cave captions for easy access.
		int[] caveConnections; // Local copy of cave connections data.
		int[] caveNeighbors; // Local copy of cave neighbor data.
		bool refresh = true; // We don't want to constantly update labels if not necessary
		bool enter = false; // Avoid over-triggering
        bool hazardActivated = false;
		int doorid;
		int[] movement = new int[DIMENSIONS]; // x and y movement

        /**
         * Default constructor
         *
         * @param caveConnections - cave connections holding which doors are open
         *  caveNeighbors - cave neighbors, whether connected or not.
         *  */
        public GameForm(int[] caveConnections, int[] caveNeighbors)
        {
            InitializeComponent();
            caves = new PictureBox[MAX_CAVES] { cave0, cave1, cave2, cave3, cave4, cave5 };
            caveLabels = new Label[MAX_CAVES] { label0, label1, label2, label3, label4, label5 };
            this.caveConnections = caveConnections;
            this.caveNeighbors = caveNeighbors;
        }

		public GameForm()
		{
			InitializeComponent();
			caves = new PictureBox[MAX_CAVES] { cave0, cave1, cave2, cave3, cave4, cave5 };
			caveLabels = new Label[MAX_CAVES] { label0, label1, label2, label3, label4, label5 };
		}

        public void clearHazard()
        {
            hazardActivated = false;
        }
            

		// Movement Form Events
		private void GameForm_KeyDown(object sender, KeyEventArgs e)
		{
            if (!hazardActivated)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        movement[LEFT_RIGHT] = -MOVEMENT_CONSTANT;
                        break;
                    case Keys.Right:
                        movement[LEFT_RIGHT] = MOVEMENT_CONSTANT;
                        break;
                    case Keys.Down:
                        movement[UP_DOWN] = MOVEMENT_CONSTANT;
                        break;
                    case Keys.Up:
                        movement[UP_DOWN] = -MOVEMENT_CONSTANT;
                        break;                    
                }
            }
		}

		private void GameForm_KeyUp(object sender, KeyEventArgs e)
		{
			if (!hazardActivated)
			{
				switch (e.KeyCode)
				{
					case Keys.Left:
						if (movement[LEFT_RIGHT] == -MOVEMENT_CONSTANT)
							movement[LEFT_RIGHT] = 0;
						break;
					case Keys.Right:
						if (movement[LEFT_RIGHT] == MOVEMENT_CONSTANT)
							movement[LEFT_RIGHT] = 0;
						break;
					case Keys.Down:
						if (movement[UP_DOWN] == MOVEMENT_CONSTANT)
							movement[UP_DOWN] = 0;
						break;
					case Keys.Up:
						if (movement[UP_DOWN] == -MOVEMENT_CONSTANT)
							movement[UP_DOWN] = 0;
						break;
					case Keys.Y:
						enter = true;
						break;
					case Keys.D1:
						GameControl.buyArrow();
						break;
					case Keys.D2:
						GameControl.buySecret();
						break;
				}
			}
			else
			{
				GameControl.continueWithHazard();
			}
		}

		private void Update_Tick(object sender, EventArgs e)
		{
			refresh = false;
            // Check if the new destination will be in bounds, and if so, move it there.
			Point nextDestination = new Point(playerSprite.Left, playerSprite.Top);
			if (inBounds(new Point(playerSprite.Left + movement[LEFT_RIGHT],
				playerSprite.Top), playerSprite))
			{
				nextDestination = new Point(nextDestination.X + movement[LEFT_RIGHT], nextDestination.Y);
				refresh = true;
			}

			if (inBounds(new Point(playerSprite.Left,
				playerSprite.Top + movement[UP_DOWN]), playerSprite))
			{
				nextDestination = new Point(nextDestination.X, nextDestination.Y + movement[UP_DOWN]);
				refresh = true;
			}
			playerSprite.Location = nextDestination;
			if (refresh)
				checkLocation();
            if (actionLabel.Text != "" && enter) 
            {
				GameControl.playerMove(caveNeighbors[doorid]);
				playerSprite.Location = caves[(doorid+3) % 6].Location;
				enter = false;
            }                
            else
                enter = false;
            Warnings();
		}

        /**
         * Checks a point to see if it is in-bounds.
         *
         * @param destinatiom- the new point under consideration, sprite - the player sprite picturebox.
         *
         * @return bool whether the point is within acceptable boundaries.
         */
		private bool inBounds(Point destination, PictureBox sprite)
		{
			if (destination.X < 0 || destination.X + playerSprite.Width > this.Width)
				return false;
			if (destination.Y < 0 || destination.Y + playerSprite.Height > GAME_AREA_HEIGHT)
				return false;
			return true;
		}

        /**
         * Checks for any collisions with doors
         */
		private void checkLocation()
		{
			int[] playerCenter = new int[DIMENSIONS]{playerSprite.Left + playerSprite.Width, playerSprite.Top + playerSprite.Height};
			doorid = MAX_CAVES;
			for (int index = 0; index < MAX_CAVES; index++)
			{
				if (caveConnections[index] == 0)
					continue;
				int[] caveCenter = new int[DIMENSIONS]{caves[index].Left + caves[index].Width, caves[index].Top + caves[index].Height};
				if ((playerCenter[X_COORD] - caveCenter[X_COORD]) * (playerCenter[X_COORD] - caveCenter[X_COORD]) + 
					(playerCenter[Y_COORD] - caveCenter[Y_COORD]) * (playerCenter[Y_COORD] - caveCenter[Y_COORD]) < playerSprite.Width * playerSprite.Height * COLLISION_STRETCH_FACTOR)
				{
					doorid = index;
					break;
				}
			}
			if (doorid != MAX_CAVES)
				actionLabel.Text = "Do you want to enter room " + caveNeighbors[doorid].ToString() + "? (y/n)";
			else
				actionLabel.Text = "";

		}

        /**
         * Called by GameControl to update the interface
         *
         * @param caveConnections - cave connections holding which doors are open
         *  caveNeighbors - cave neighbors, whether connected or not.
         *  gold, turns, score, hazard - self-explanatory
         */
		public void UpdateUI(int[] caveConnections, int[] caveNeighbors, int arrows, int gold, int turns, int score, string hazard)
		{
            this.caveConnections = caveConnections;
            this.caveNeighbors = caveNeighbors;
			string output = "";
			for (int index = 0; index < MAX_CAVES; index++)
			{
                if (caveConnections[index] != 0)
				{
					output += index.ToString();
                    caveLabels[index].Text = caveConnections[index].ToString();
				}
				else
					caveLabels[index].Text = "";
			}
			if (output != "")
				this.BackgroundImage = Image.FromFile(output + ".png");
			else
				this.BackgroundImage = Image.FromFile("None.png");
			arrowHolder.Text = arrows.ToString();
			goldHolder.Text = gold.ToString();
			turnHolder.Text = turns.ToString();
            hazardBox.Visible = true;
            hazardActivated = true;
            if (hazard == "bat")
            { this.hazardBox.Image = HuntTheWumpus.Properties.Resources.SecurityBot; }
            else if (hazard == "pit")
            { this.hazardBox.Image = HuntTheWumpus.Properties.Resources.pit; }
            else if (hazard == "wumpus")
            { this.hazardBox.Image = HuntTheWumpus.Properties.Resources.AUTO_Wumpus; }
            else
            {
                hazardBox.Visible = false;
                hazardActivated = false;
            }
		}

        public void Warnings()
        {
            notificationLabel.Text = GameControl.getWarning();
        }

		private void this_Enter(object sender, EventArgs e)
		{

		}

		private void GameForm_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
		{
            // Don't leave any ghost processes.
			UpdateTimer.Enabled = false;
		}

		private void GameForm_Load(object sender, EventArgs e)
		{

		}
    }
}
