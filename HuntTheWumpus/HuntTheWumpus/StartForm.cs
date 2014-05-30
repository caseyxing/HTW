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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void startButton_Click_1(object sender, EventArgs e)
		{
			this.Hide();

			Random rnd = new Random();
			GameControl.caveSelection(rnd.Next(1, 6));
			GameControl.startGame();
		}

		private void hsButton_Click(object sender, EventArgs e)
		{
			GameControl.viewHighScore();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

        private void button1_Click(object sender, EventArgs e)
        {
            GameControl.viewInstructions();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
