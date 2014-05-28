using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuntTheWumpus
{
	public static class GameControl
    {
		static mainUI HTWMainUI = new mainUI ();
		static Map HTWMap = new Map();
		static Player HTWPlayer = new Player();
		static Cave HTWCave = new Cave();
		public static string playeraction = "";

		public static void initializeUI()
		{
			updateUI ();
			HTWMainUI.displayCaves ();
		}

		public static void updateUI()
		{
			bool batCollide = false;
			bool pitCollide = false;
			bool wumpusCollide = false;
			int playerLocation = HTWMap.currentPlayerLocation;

			if(playerLocation == HTWMap.currentBat1 || playerLocation == HTWMap.currentBat2)
			{
				batCollide = true;
			}
			if(playerLocation == HTWMap.currentPit1 || playerLocation == HTWMap.currentPit2)
			{
				pitCollide = true;
			}
			if(playerLocation == HTWMap.currentWumpusLocation)
			{
				wumpusCollide = true;
			}

			HTWMainUI.interfaceUpdate (HTWPlayer.GoldCoins, HTWPlayer.Turns, HTWPlayer.Arrows, HTWPlayer.computeScore(),
				HTWMap.Warnings (HTWCave.getCompoundCave (playerLocation)), pitCollide, batCollide, wumpusCollide);
			HTWMainUI.displayCaves ();
		}

		public static void reset()
		{
			HTWMainUI = new mainUI ();
		}

		public static int gethazardlocation(int hazard)
		{
			//1-2 bats 3-4 pits 5 wumpus
			if (hazard == 1)
			{
				return HTWMap.currentBat1;
			}
			else if (hazard == 2)
			{
				return HTWMap.currentBat2;
			}
			else if (hazard == 3)
			{
				return HTWMap.currentPit1;
			}
			else if (hazard == 4)
			{
				return HTWMap.currentPit2;
			}
			else
			{
				return HTWMap.currentWumpusLocation;
			}
		}

		public static void BatEncounter()
		{
			HTWMap.batEncounter ();
			// add show form
			HTWMainUI.centerPlayer ();
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
			//HTWTrivia.Trivia
			playeraction = "buy";
		}

		public static void Secret()
		{
			HTWPlayer.Turns++;
			//HTWTrivia.Trivia
			playeraction = "secret";
		}

		public static int[] getCompoundCaves(int currentLocation)
		{
			return HTWCave.getCompoundCave (currentLocation);
		}

		public static string getSecret()
		{
			return HTWMap.Secret ();
		}
    }
}
