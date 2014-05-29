using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HuntTheWumpus
{
	public class HighScore
	{

		//defining variables to be used within this class
		public int highScore;
		public String cave;
		public String name;

		//defining a new instance of the variable without parameters
		public HighScore() 
		{ 
		}
	}

	public class HighScoreObject
	{

		//creating a new list to be used to hold the highscore
		List<HighScore> highScores = new List<HighScore>();

		//creating a new instance of the object to use without parameters
		 public HighScoreObject()
        {
			//calling in the method to read in from the file holding the highscores
            readDatafile();
        }

		 private void readDatafile()
		 {
			 //the try keyword indicates to try using this method and if there's an error, skip to the catch portion.
			 try
			 {
				 //this is creating a temporary variable to use which holds the highscore text
				 TextReader tr = new StreamReader("Highscores.txt");

				 //another temporary variable to hold the text that is being read in line per line
				 string input = tr.ReadLine();

				 //while there is still text to be read, do the following functions
				 while (input != null)
				 {

					 //because the text is split by a comma, every time there is a comma it indicates that there is a different portion of code being read in
					 string[] data = input.Split(',');

					 //creating a new constructor to hold the information being read in by the read from file
					 HighScore hs = new HighScore(); ;

					 //depending on the position of the data being read in, it will assign to the specific part of the highscoreStruct
					 hs.highScore = int.Parse(data[0]);
					 hs.name = data[1];
					 hs.cave = data[2];

					 //after assigning the positions, it will add the highscore to the highscoreStruct
					 highScores.Add(hs);

					 //doing this calls upon the next line to be read, allowing for the complete file holding the text to be read. 
					 input = tr.ReadLine();
				 }

				 //after there is no more information left to read, the method will close
				 tr.Close();
			 }

			 //this catch will only be activated if the file is not present, which usually does not happen
			 catch { }

		 }

		 //this method writes the data to the file
		 private void writeDatatoFile()
		 {
			 try
			 {
				 //creating an instance of the variable to be used that will write to the text file holding the highscores
				 TextWriter tw = new StreamWriter("Highscores.txt");

				 //running the for loop to input into the text file, making sure that the information is structured correctly. 
				 foreach (HighScore hs in highScores)
				 {
					 string output = hs.highScore.ToString() + "," + hs.name + "," + hs.cave;

					 tw.WriteLine(output);
				 }
				 tw.Close();
			 }
			 catch
			 {

			 }
		 }

			//This method, when called upon, adds new highscores. 
        public void AddNewScore(HighScore hst)
        {
			//calling upon this method adds the new highscore to the text file
            highScores.Add(hst);

			//compares the scores and if one is equal to or greater than another then it will override it and replace
            highScores.Sort((HighScore p1, HighScore p2) => p1.highScore.CompareTo(p2.highScore));

			//This calls upon the method to write the new data into the file that has now been updated. s
            writeDatatoFile();          
        }

		//this method allows for the data to be read in and give back to game control the data of the highscores array
        public List<HighScore> GetAllScoreData()
        {
            return highScores;
        }

		//If a specific index wants to be grabbed, it will be passed through like this and return out that specific index. 
        public HighScore GetAllScoreData(int index)
        {
            return highScores[index];
        }
    }
}

