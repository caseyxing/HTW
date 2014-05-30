using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuntTheWumpus
{
	public static class GameControl
    {
		static StartForm HTWStartForm = new StartForm();
		static GameForm HTWGameForm = new GameForm ();
		static Map HTWMap = new Map();
		static Player HTWPlayer = new Player();
		static Cave HTWCave = new Cave();
		public static string playeraction = "";
		static HighScoreForm HTWScoreForm = new HighScoreForm();
		static HighScore HTWScore = new HighScore();
		static HighScoreObject HTWScoreObject = new HighScoreObject();
		static TriviaUI HTWTriviaUI = new TriviaUI();
		static Trivia HTWTrivia	= new Trivia();
		static ResultForm HTWResults = new ResultForm();
        static PlayerInstructionsForm HTWInstructions = new PlayerInstructionsForm();

		public static void startGame()
		{
			updateUI();
			HTWGameForm.Show();
		}

		public static void viewHighScore()
		{
			HTWScoreForm.Show();
		}

        public static void viewInstructions()
        {
            HTWInstructions.Show();
        }

		public static void updateUI()
		{
			int playerLocation = HTWMap.currentPlayerLocation;

			HTWGameForm.UpdateUI (HTWCave.getCompoundCave(playerLocation), HTWCave.getNeighborCaves(playerLocation), HTWPlayer.Arrows,
				HTWPlayer.GoldCoins, HTWPlayer.Turns, HTWPlayer.computeScore (), getHazard());
		}

		public static void reset()
		{
			HTWGameForm = new GameForm ();
			HTWScore = new HighScore ();
			HTWScoreForm = new HighScoreForm ();
			HTWTrivia = new Trivia ();
			HTWTriviaUI = new TriviaUI ();
			HTWMap = new Map ();
			HTWCave = new Cave ();
			HTWPlayer = new Player ();
			HTWStartForm = new StartForm ();
		}

		public static string getHazard()
		{
			int playerLocation = HTWMap.currentPlayerLocation;

			if(playerLocation == HTWMap.currentBat1 || playerLocation == HTWMap.currentBat2)
			{
				return "bat";
			}
			if(playerLocation == HTWMap.currentPit1 || playerLocation == HTWMap.currentPit2)
			{
				return "pit";
			}
			if(playerLocation == HTWMap.currentWumpusLocation)
			{
				return "wumpus";
			}
			return "";
		}

		public static void continueWithHazard()
		{
			string hazard = getHazard();
			if (hazard == "bat")
			{
				BatEncounter();
			}
			if (hazard == "pit")
			{
                pitEncounter();
			}
			if (hazard == "wumpus")
			{
				wumpusEncounter();
			}
		}

        public static void resolveHazard(int numCorrect)
        {
            string hazard = getHazard();
            if (hazard == "pit")
            {
                if (HTWTriviaUI.GetCorrectAnswers() < 2)
                {
                    gameLost();
                }
                else
                {
                    HTWMap.currentPlayerLocation = HTWMap.startPlayerLocation;
                    HTWGameForm.clearHazard();
                }
            }
            if (hazard == "wumpus")
            {
                if (HTWTriviaUI.GetCorrectAnswers() >= 3)
                {
                    WumpusRun();
                    HTWGameForm.clearHazard();
                    updateUI();
                }
                else
                {
                    gameLost();
                }
            }
        }
		public static void BatEncounter()
		{
			HTWMap.batEncounter ();
			updateUI ();
		}

		public static void pitEncounter()
		{
            HTWTriviaUI.Show();
            HTWTriviaUI.nextQuestion(4);
		}

		public static int WumpusRun()
		{
			Random rnd = new Random ();
			int upper = rnd.Next (2, 4);
			while (HTWMap.wumpusConflict())
			{
				for (int index = 0; index < upper; index++)
				{
					HTWMap.awakeWumpus ();
				}
			}
            updateUI();
			return HTWMap.currentWumpusLocation;
		}

		public static void buyArrow()
		{
			HTWPlayer.Turns++;
			playeraction = "buy";
		}

        public static void buyStuff()
        {
            if(playeraction == "buy")
            {
                getArrow();
            }
            if(playeraction == "secret")
            {
                getTriviaSecret();
            }
        }
        public static void getArrow()
        {
            HTWTriviaUI.Show();
			HTWTriviaUI.nextQuestion (4);
        }

        public static void getTriviaSecret()
        {
        	HTWTriviaUI.Show();
			HTWTriviaUI.nextQuestion (4);
        }
		public static void shoot(int selectedCave)
		{
			HTWPlayer.Arrows--;
			if (selectedCave == HTWMap.currentWumpusLocation)
			{
				win();
			}
			if(HTWPlayer.Arrows == 0)
			{
				gameLost();
			}
		}
		public static void buySecret()
		{
			HTWPlayer.Turns++;
			playeraction = "secret";
		}

		public static void	getOutOfPit()
		{
			HTWPlayer.Turns++;
			HTWTriviaUI.Show();
			HTWTriviaUI.nextQuestion (4);
			playeraction = "pit";
		}

		public static int[] getCompoundCaves(int currentLocation)
		{
			return HTWCave.getCompoundCave (currentLocation);
		}

		public static string getSecret()
		{
			return HTWMap.Secret ();
		}
		public static string getWarning()
		{
			return HTWMap.Warnings (HTWCave.getCompoundCave (HTWMap.currentPlayerLocation));
		}

		public static void triviaFinal(int numCorrect)
		{
			if (playeraction == "buy" && numCorrect >= 2)
			{
				HTWPlayer.purchaseArrowsSuccess ();
			}
			if (playeraction == "secret" && numCorrect >= 2)
			{
				HTWMap.Secret ();
			}

		}

		public static int passHighScore()
		{
			return HTWPlayer.computeScore ();
		}

		public static void playerMove(int location)
		{
			HTWMap.currentPlayerLocation = location;
			HTWPlayer.Turns++;
			updateUI();
		}

		private static void win()
		{
            HTWResults.setResult(true);
			HTWResults.Show();
		}

		private static void gameLost()
		{
            HTWResults.setResult(false);
			HTWResults.Show();
		}

		public static void caveSelection(int cave)
		{
			HTWCave.loadCave(cave);
		}

		public static void wumpusEncounter()
		{
            HTWTriviaUI.Show();
            HTWTriviaUI.nextQuestion(6);
		}


    }
}
