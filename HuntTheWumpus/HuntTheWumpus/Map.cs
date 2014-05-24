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
		public string[] secrectList = new string[6];

		public Map ()
		{
			initializeRoomNumbers();
			initializesPlayerLocation();
			initializeWumpusLocation();
			initializeBottomlessPitLocation();
			initializeSuperBatsLocation();
			initializeWarnings();
			initilizeSecrets();
		}

		/* This method initializes the list of room
		 * numbers in the arraylist roomNumberList.
		 */
		private void initializeRoomNumbers()
		{
			for (int index = 0; index < 30; index++) 
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
		private void initializesPlayerLocation()
		{
			Random rnd = new Random ();
			playerLocation = playerRoomNumber.ElementAt(rnd.Next (0, playerRoomNumber.Count-1));
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
		 * other object can get that room number.
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
		private void initilizeSecrets()
		{
			secrectList [0] = "The Wumpus is in room " + wumpusLocation;
			secrectList [1] = "A Bat is in room " + superBatsLocation [0];
			secrectList [2] = "A Bat is in room " + superBatsLocation [1];
			secrectList [3] = "A Pit is in room " + bottomlessPitsLocation [0];
			secrectList [4] = "A Pit is in room " + bottomlessPitsLocation [1];
			secrectList [5] =  "I don't feel like telling you a secret.";
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
			bool isShot = isWumpusAt ();
			if (wumpusLocation == playerLocation || isShot) 
			{
			}
		}

		/* This method provides warnings to the player if the player
		 * is one cave away from an object: wumpus, bat, or pit.The
		 * method will return a string which is the warning.
		 */
		public string Warning()
		{
		}

		/* This method provides secrets that the player can purchase.
		 * The method will return a string which is the secret.
		 */
		public string Secret()
		{
			Random rnd = new Random ();
			int index = rnd.Next (0, 5);
			return secrectList [index];
		}

		/* This method tells the program if the shot arrow was shot into
		 * the cave that has the Wumpus in it.
		 */
			public bool isWumpusAt(int caveToShootInto)
		{
			if (wumpusLocation == caveToShootInto) {
				return true;
			} 
			else 
			{
				return false;
			}
		}
	}
}

