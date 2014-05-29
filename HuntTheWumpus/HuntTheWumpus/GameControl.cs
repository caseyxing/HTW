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
		static TriviaUI HTWTriviaUI = new TriviaUI();
		static Trivia HTWTrivia	= new Trivia();

		public static void initializeUI()
		{
			updateUI ();
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

		}

		public static void BatEncounter()
		{
			HTWMap.batEncounter ();
			updateUI ();
		}

		public static void WumpusRun()
		{
			Random rnd = new Random ();
			int upper = rnd.Next (2, 4);
			while (HTWMap.wumpusConflict())
			{
				for (int index = 0; index < upper; index++)
				{
					HTWMap.awakeWumpus ();
				}
				updateUI ();
			}
		}

		public static void BuyArrow()
		{
			HTWPlayer.Turns++;
			HTWTriviaUI.nextQuestion (3);
			playeraction = "buy";
		}

		public static void Secret()
		{
			HTWPlayer.Turns++;
			HTWTriviaUI.nextQuestion (3);
			playeraction = "secret";
		}

		public static void	getOutOfPit()
		{
			HTWPlayer.Turns++;
			HTWTriviaUI.nextQuestion (3);
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

		public static void triviaFinal()
		{
			if (playeraction == "buy" && HTWTriviaUI.GetCorrectAnswers () >= 2)
			{
				HTWPlayer.purchaseArrowsSuccess ();
			}
			if (playeraction == "secret" && HTWTriviaUI.GetCorrectAnswers () >= 2)
			{
				HTWMap.Secret ();
			}
			if (playeraction == "pit" && HTWTriviaUI.GetCorrectAnswers () >= 2)
			{
				HTWMap.startPlayerLocation;
			}

		}

		public static string passHighScore()
		{
			HTWPlayer.computeScore ();
		}

    }
}
