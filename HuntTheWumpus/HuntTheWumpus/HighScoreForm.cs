using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntTheWumpus
{
	public partial class HighScoreForm : Form
	{

		//creating a new instance of the class so that its methods can be used
		HighScoreObject hs = new HighScoreObject();
		int score = 0;
		public HighScoreForm()
		{
			//declaring the initial components and updating the list box
			InitializeComponent();
			UpdateListBox();
		}

		public int assignScore()
		{
			return GameControl.passHighScore();
		}

		//this is the method that is activated when a value in the list box is picked
		public void highScoresBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//this creates a new instance to get the score and string of the person's name
			HighScore hst = hs.GetAllScoreData(highScoresBox.SelectedIndex);

			//setting the text boxes to the temprary variable that has been found
			nameTextBox.Text = hst.name;
		}

		//updating the list box when called upon
		public void UpdateListBox()
		{
			//creating a list to hold all of the high scores
			List<HighScore> hst = hs.GetAllScoreData();

			//Clears out the list and re-sets the data to make sure that all data is up to date. 
			highScoresBox.Items.Clear();
			foreach (HighScore h in hst)
			{
				highScoresBox.Items.Add(h.highScore + "___" + h.name);

			}
		}

		public string selectedCave()
		{
			Cave highCave = new Cave();
			return highCave.SelectedCave;
		}

		//when the button is clicked on, it will run this method
		public void button2_Click(object sender, EventArgs e)
		{
			try
			{
				//creating a new instance of highscore to use to sex text boxes and add the new highscores
				HighScore hss = new HighScore();

				//sets the text to the information read in 
				hss.name = nameTextBox.Text;

				//setting the highscore varaible to the temprary high score that is in the text
				hss.highScore = assignScore();

				hss.cave = selectedCave();
				//adding the high score into the highscores list
				hs.AddNewScore(hss);
				string total = hss.name + "___" + hss.highScore;
				highScoresBox.Items.Add(total);




			}
			catch
			{
				//asking the user to enter their name and score if there is nothing there
				MessageBox.Show("Please Enter Your Name or Value");
			}

			//calling upon the list box to update it
			UpdateListBox();


		}

		public void HighscoreForm_Load(object sender, EventArgs e)
		{

		}

		public void nameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		public void labelName_Click(object sender, EventArgs e)
		{

		}

		public void HighScoreForm_Load_1(object sender, EventArgs e)
		{

		}
		public void nameTextBox_TextChanged_1(object sender, EventArgs e)
		{

		}

	}
}
