using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HuntTheWumpus
{
	/* This class initializes and tracks the location
	 * of all of the objects in the game. In addition,
	 * it gives warnings and gets secrets for the
	 * player.
	 * 
	 */
	public class Map
	{
		// This is an arraylist of the room numbers: 1 to 30.
		List<int> roomNumbers = new List<int>();
		// This is an arraylist of the room numbers: 1 to 30.
		// However, this allows the player to be randomly place
		// in a room with another object.
		List<int> playerRoomNumber = new List<int> ();
		// This is an integer that keeps track of where
		// the player is.
		public int playerLocation;
		// This is an array of integers that keeps track of
		// where the two bats are.
		public int[] superBatsLocation = new int[2];
		// This is an integer that keeps track of where
		// the Wumpus is.
		public int wumpusLocation;
		// This is an array of integers that keeps track of 
		// where the two bottomless pits are.
		public int[] bottomlessPitsLocation = new int[2];
		// This is an array of strings that contains the 
		// warnings that can be given out.
		public string[] warningList = new string[3];
		// This is an array of strings that contains the 
		// secrets that can be given out.
		public string[] secretList = new string[6];
		// This integer variable holds the number of caves
		// in the game.
		public static int numberOfCaves = 30;

		public Map ()
		{
			initializeRoomNumbers();
			initializePlayerLocation();
			initializeWumpusLocation();
			initializeBottomlessPitLocation();
			initializeSuperBatsLocation();
			initializeWarnings();
			initializeSecrets();
		}

		/* This method initializes the list of room
		 * numbers in the arraylist roomNumberList.
		 */
		private void initializeRoomNumbers()
		{
			for (int index = 0; index < numberOfCaves; index++) 
			{
				roomNumbers.Add(index + 1);
				playerRoomNumber.Add (index + 1);
			}
		}

		/* This method generates a room number for where
		 * the player is going to start. It then removes
		 * that room number from the list so that no other
		 * object can get that room number.
		 */
		private void initializePlayerLocation()
		{
			Random rnd = new Random ();
			playerLocation = playerRoomNumber.ElementAt(rnd.Next (0, playerRoomNumber.Count-1));
			// The room number is removed so that no other object can be placed there.
			roomNumbers.RemoveAt (roomNumbers.IndexOf(playerLocation));
			playerRoomNumber.RemoveAt (playerRoomNumber.IndexOf(playerLocation));
		}

		/* This method generate two room numbers for
		 * where the super bats are going to start. It then 
		 * removes that room number from the list so that no
		 * other object can get that room number.
		 */
		private void initializeSuperBatsLocation()
		{
			for (int index = 0; index < 2; index++) 
			{
				Random rnd = new Random ();
				superBatsLocation [index] = roomNumbers.ElementAt (rnd.Next (0, roomNumbers.Count - 1));
				roomNumbers.RemoveAt (roomNumbers.IndexOf(superBatsLocation[index]));
			}
		}

		/* This method generates a room number for where the
		 * wumpus is going to start. It then 
		 * removes that room number from the list so that no
		 * other object can get that room number
		 */
		private void initializeWumpusLocation()
		{
			Random rnd = new Random ();
			wumpusLocation = playerRoomNumber.ElementAt(rnd.Next (0, playerRoomNumber.Count-1));
			roomNumbers.RemoveAt (roomNumbers.IndexOf(wumpusLocation));
		}

		/* This method generates two room numbers for where the
		 * bottomless pits are going to be placed. It then 
		 * removes that room number from the list so that no
		 * other object can get that room number. 
		 */
		private void initializeBottomlessPitLocation()
		{
			for (int index = 0; index < 2; index++) 
			{
				Random rnd = new Random ();
				bottomlessPitsLocation [index] = roomNumbers.ElementAt (rnd.Next (0, roomNumbers.Count - 1));
				roomNumbers.RemoveAt (roomNumbers.IndexOf(bottomlessPitsLocation[index]));
			}
		}

		/* This method initializes the list of warnings in
		 * the array warningList.
		 */
		private void initializeWarnings()
		{
			warningList [0] = "I smell a Wumpus!";
			warningList [1] = "Bats nearby.";
			warningList [2] = "I feel a draft.";
		}

		/* This method initializes the list of secrets in
		 * the array secretList.
		 */
		private void initializeSecrets()
		{
			secretList [0] = "The Wumpus is in room " + wumpusLocation;
			secretList [1] = "A Bat is in room " + superBatsLocation [0];
			secretList [2] = "A Bat is in room " + superBatsLocation [1];
			secretList [3] = "A Pit is in room " + bottomlessPitsLocation [0];
			secretList [4] = "A Pit is in room " + bottomlessPitsLocation [1];
			secretList [5] =  "I don't feel like telling you a secret.";
		}

		/* This method gets and sets where the player is on 
		 * the map.
		 */
		public int currentPlayerLocation
		{
			get
			{
				return playerLocation;
			}

			set 
			{
				playerLocation = value;
			}
		}

		/* This method gets where the wumpus is on 
		 * the map.
		 */
		public int currentWumpusLocation
		{
			get
			{
				return wumpusLocation;
			}
		}

		/* This method gets where the first bat is on 
		 * the map.
		 */
		public int currentBat1
		{
			get
			{
				return superBatsLocation [0];
			}
		}

		/* This method gets where the second bat is on 
		 * the map.
		 */
		public int currentBat2
		{
			get
			{
				return superBatsLocation [1];
			}
		}

		/* This method gets where the first pit is on 
		 * the map.
		 */
		public int currentPit1
		{
			get
			{
				return bottomlessPitsLocation [0];
			}
		}

		/* This method gets where the first bat is on 
		 * the map.
		 */
		public int currentPit2
		{
			get {
				return bottomlessPitsLocation [1];
			}
		}

		/* This method checks to see if the player has encountered
		 * any super bats. If so, then the player and bats will 
		 * respond accordingly.
		 */
		public void batEncounter()
		{
			Random rnd = new Random ();
			int index = 3;
			if (superBatsLocation [0] == playerLocation) 
			{
				index = 0;
			}
			if (superBatsLocation [1] == playerLocation) 
			{
				index = 1;
			}
			if (index == 0 || index == 1) {
				int location = playerRoomNumber.ElementAt (rnd.Next (0, playerRoomNumber.Count - 1));
				playerRoomNumber.Add (playerLocation);
				roomNumbers.Add (playerLocation);
				playerLocation = location;
				roomNumbers.RemoveAt (roomNumbers.IndexOf (playerLocation));
				playerRoomNumber.RemoveAt (playerRoomNumber.IndexOf (playerLocation));

				location = roomNumbers.ElementAt (rnd.Next (0, roomNumbers.Count - 1));
				roomNumbers.Add (superBatsLocation [index]);
				superBatsLocation [index] = location;
				roomNumbers.RemoveAt (roomNumbers.IndexOf (superBatsLocation [index]));
			}
		}

		/* This method tests to see if the Wumpus is awake and then
		 * responds accordingly. 
		 */
		public void awakeWumpus()
		{
			List<int> wumpusRooms = new List<int>();
				for (int cave = 0; cave < 6; cave++)
				{
				if(GameControl.getCompoundCaves(wumpusLocation)[cave] != 0)
					{
					wumpusRooms.Add(GameControl.getCompoundCaves(wumpusLocation)[cave]);
					}
				}
				Random rnd = new Random();
				wumpusLocation = wumpusRooms.IndexOf(rnd.Next(0, wumpusRooms.Count - 1));
		}

		public bool wumpusConflict()
		{
			if (playerLocation != wumpusLocation)
			{
				return false;

			}
			return true;
		}

		/* This method provides warnings to the player if the player
		 * is one cave away from an object: wumpus, bat, or pit.The
		 * method will return a string which is the warning.
		 */
		public string Warnings(int[] connectingCaves)
		{
			string Warning = "";
			bool isBat = false;
			bool isPit = false;
			bool isWumpus = false;
			for (int cave = 0; cave < 6; cave++)
			{
				if (superBatsLocation [0] == connectingCaves [cave]) {
					isBat = true;
				}
				if (superBatsLocation [1] == connectingCaves [cave]) {
					isBat = true;
				}
				if (bottomlessPitsLocation [0] == connectingCaves [cave]) {
					isPit = true;
				}
				if (bottomlessPitsLocation [1] == connectingCaves [cave]) {
					isPit = true;
				}
				if (wumpusLocation == connectingCaves [cave]) {
					isWumpus = true;
				}
			}

				if (isWumpus)
				{
					Warning += warningList [0] + " ";
				}
				if (isBat)
				{
					Warning += warningList [1] + " ";
				}
				if (isPit)
				{
					Warning += warningList [2];
				}

				return Warning;
		}

		/* This method provides secrets that the player can purchase.
		 * The method will return a string which is the secret.
		 */
		public string Secret()
		{
			Random rnd = new Random ();
			int index = rnd.Next (0, 5);
			return secretList [index];
		}

		/* This method tells the program if the shot arrow was shot into
		 * the cave that has the Wumpus in it.
		 */
		public bool isWumpusAt(int caveToShootInto)
		{
			if (wumpusLocation == caveToShootInto)
			{
				return true;
			} 
			else 
			{
				return false;
			}
		}
	}
}

