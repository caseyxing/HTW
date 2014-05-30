using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HuntTheWumpus
{
    /*
    * Cave Object - handling room connections
	*/
	class Cave
	{
        private const int CAVES_MAX = 6, TOTAL_CAVES = 30, MAX_DOORS_PER_CAVE = 3, CYCLE = 10;
		private bool[] filled = new bool[TOTAL_CAVES + 1]; // This is for the floodfill.
		private bool[,] baseCaveConnections = new bool[TOTAL_CAVES + 1, CAVES_MAX]; // Stores whether two caves are connected.
		private string selectedCave; // the cave the player selected, preset, or random

		public string SelectedCave
		{
			get { return selectedCave; }
			set { selectedCave = value; }
		}

		public bool[] getFilled
		{
			get { return filled; }
            set { filled = value; }
		}

		public bool[,] caveConnections
		{
            get { return baseCaveConnections; }
            set { baseCaveConnections = value; }
		}

		public Cave() {}

		private int boolToInt(bool input)
		{
			if (input)
                return 1;
			else
				return 0;
		}

        /**
         * Determines whether the cave number is valid and if not, convert it to a valid cave ID.
         *
         * @param caveID - proposed ID for testing.
         *
         * @return Sanitized ID
         */
		private int validateID(int caveID)
		{
			if (caveID < 1)
				return caveID + TOTAL_CAVES;
			else if (caveID > TOTAL_CAVES)
				return caveID - TOTAL_CAVES;
			else
				return caveID;
		}

        /**
         * Closes all doors
         */
		public void reset()
		{
			for (int index = 1; index < TOTAL_CAVES + 1; index++)
			{
				for (int subindex = 0; subindex < CAVES_MAX; subindex++)
					caveConnections[index, subindex] = false;
			}
		}

        /**
         * Generates a random new Cave
         * 
         * @return true if generation was successful, false otherwise.
         */
		public bool generateNewCave()
		{
			int cycles = 0, subcycles = 0, randomdoor;
			Random random = new Random();
			while (cycles < CYCLE)
			{
				reset();
				subcycles = 0;
				while (subcycles < CYCLE)
				{
					for (int index = 1; index < TOTAL_CAVES + 1; index++)
					{
						randomdoor = random.Next(0, CAVES_MAX);
						if ((!caveConnections[index, randomdoor] && numberOfDoors(index) < MAX_DOORS_PER_CAVE) && 
                            numberOfDoors(getNeighborCaves(index)[randomdoor]) < MAX_DOORS_PER_CAVE)
						{
							caveConnections[index, randomdoor] = true;
							caveConnections[getNeighborCaves(index)[randomdoor], 
                                getDirectionOfNeighbor(getNeighborCaves(index)[randomdoor], index)] = true;
						}

					}
					if (validateCave() == 0)
						return true;
					subcycles++;
				}
				cycles++;
			}
			return false; // Guess it failed...
		}

        /**
         * Checks the number of doors open for a cave.
         * 
         * @param id - Cave ID number
         * 
         * @return number of doors open
         */
		public int numberOfDoors(int id)
		{
			int doorsopen = 0;
			for (int index = 0; index < CAVES_MAX; index++)
			{
				if (caveConnections[id, index])
				{
					doorsopen++;
				}
			}
			return doorsopen;
		}

        /**
         * Loads a cave from file
         * 
         * @param caveID - number of preset cave
         * 
         * @return true on successful read, false otherwise
         */
		public bool loadCave(int caveID)
		{
			/*
			 * Cave Format from Text File
			 * Cave# (0|1) (0|1) (0|1) (0|1) (0|1) (0|1)
			 * Where 0 represents closed and 1 represents open
			 * Cave text should be 30*7 = 210 lines long.             * 
			 *   0
			 * 5/¯\1
			 * 4\_/2
			 *   3
			*/
			Random randomCave = new Random();
			List<string> caveInfo = new List<string>();
			using (StreamReader caveReader = new StreamReader("Cave" + randomCave.Next(1, CAVES_MAX).ToString() + ".CAV"))
			{
				string input = " ";
				input = caveReader.ReadLine();
				while (input != null)
				{
					caveInfo.Add(input);
					input = caveReader.ReadLine();
				}
			}
			for (int index = 0; index < caveInfo.Count; index++)
			{
				string[] caveExtract = caveInfo[index].Split(' ');
				int[] inputcaveConnections = getNeighborCaves(index + 1);
				try
				{
					for (int subindex = 0; subindex < CAVES_MAX; subindex++)
					{
						caveConnections[index + 1, getDirectionOfNeighbor(index + 1, inputcaveConnections[subindex])] = int.Parse(caveExtract[subindex]) == 1;
					}
				}
				catch
				{
					return false;
				}

			}
			return true;
		}
		public bool loadCave(List<string> caveInfo)
		{
			// loadCave called internally
			for (int index = 0; index < caveInfo.Count - 1; index++)
			{
				string[] caveExtract = caveInfo[index].Split(' ');
				int[] inputcaveConnections = getNeighborCaves(index + 1);
                try
                {
                    for (int subindex = 0; subindex < CAVES_MAX; subindex++)
                        caveConnections[index + 1, getDirectionOfNeighbor(index + 1, inputcaveConnections[subindex])] = int.Parse(caveExtract[subindex]) == 1;
                }
                catch { return false; }

			}
			return true;
		}
        /**
         * Writes a cave to file
         * 
         * @return true on successful read, false otherwise
         */
        public bool writeCave()
        {
            try
            {
                StreamWriter caveExporter = new StreamWriter("usercave.CAV");
                for (int caveindex = 1; caveindex < TOTAL_CAVES + 1; caveindex++)
                {
                    for (int index = 0; index < CAVES_MAX; index++)
                    {
                        caveExporter.Write(boolToInt(baseCaveConnections[caveindex, index]).ToString());
                        if (index != 5)
                            caveExporter.Write(" ");
                    }
                    caveExporter.Write(Environment.NewLine);
                }
                caveExporter.Close();
                return false;
            }
            catch { return true; }
        }

        /*
         * Checks that the cave meets requirements in the spec.
         * 
         * @return 0 if successful, ID of cave that is problematic if not.
         */
		public int validateCave()
		{
			// Floodfill
			bool[] queuebool = new bool[TOTAL_CAVES + 1];
			List<int> queue = new List<int>();
			queue.Add(0);
			queue.Add(1);
			for (int index = 0; index < TOTAL_CAVES + 1; index++)
			{
				filled[index] = false;
				queuebool[index] = false;
			}
			filled[1] = true;

            try
            {
                for (int index = 1; index < TOTAL_CAVES + 1; index++)
                {
                    for (int subindex = 0; subindex < CAVES_MAX; subindex++)
                    {
                        if (baseCaveConnections[queue[index], subindex])
                        {
                            filled[getNeighborCaves(queue[index])[subindex]] = true;
                            if (!queuebool[getNeighborCaves(queue[index])[subindex]])
                            {
                                queuebool[getNeighborCaves(queue[index])[subindex]] = true;
                                queue.Add(getNeighborCaves(queue[index])[subindex]);
                            }
                        }
                    }
                }
            }
            catch { }

			// Check if a cave has too many openings.
			int doorsPerCave = 0;
			for (int index = 1; index < TOTAL_CAVES + 1; index++)
			{
				doorsPerCave = 0;
				for (int subindex = 0; subindex < CAVES_MAX; subindex++)
				{
					if (baseCaveConnections[index, subindex])
						doorsPerCave++;
				}
				if (doorsPerCave > MAX_DOORS_PER_CAVE || doorsPerCave == 0)
					return index;
			}

			for (int index = 1; index < TOTAL_CAVES + 1; index++)
			{
				if (!filled[index])
					return index;
			}

			return 0;
		}

        /*
         * Returns neighboring caves (through walls and doors).
         * Hard-coded.
         * 
         * @param currentCave - ID of cave
         * 
         * @return int array of neighboring caves
         */
		public int[] getNeighborCaves(int currentCave)
		{
			if (currentCave % CAVES_MAX == 1)
                return new int[CAVES_MAX]{validateID(currentCave - CAVES_MAX), validateID(currentCave - CAVES_MAX + 1), 
                    validateID(currentCave + 1), validateID(currentCave + CAVES_MAX), validateID(currentCave + CAVES_MAX - 1), validateID(currentCave - 1)};
            else if (currentCave % CAVES_MAX == 2 || currentCave % CAVES_MAX == 4)
				return new int[CAVES_MAX]{validateID(currentCave - CAVES_MAX), validateID(currentCave + 1), 
                    validateID(currentCave + CAVES_MAX + 1), validateID(currentCave + CAVES_MAX), validateID(currentCave + CAVES_MAX - 1), validateID(currentCave - 1)};
			else if (currentCave % CAVES_MAX == 3 || currentCave % CAVES_MAX == 5)
                return new int[CAVES_MAX]{validateID(currentCave - CAVES_MAX), validateID(currentCave - CAVES_MAX + 1), 
                    validateID(currentCave + 1), validateID(currentCave + CAVES_MAX), validateID(currentCave - 1), validateID(currentCave - CAVES_MAX - 1)};
			else
                return new int[CAVES_MAX]{validateID(currentCave - CAVES_MAX), validateID(currentCave - CAVES_MAX + 1), 
                    validateID(currentCave + 1), validateID(currentCave + CAVES_MAX), validateID(currentCave + CAVES_MAX - 1), validateID(currentCave - 1)};
		}

        /*
         * Returns neighboring caves (through doors ONLY).
         * 
         * @param currentCave - ID of cave
         * 
         * @return int array of neighboring caves connected by door, 0 if walled.
         */
		public int[] getCompoundCave(int currentCave)
		{
			int[] compoundCave = new int[CAVES_MAX];
			int[] neighbors = getNeighborCaves(currentCave);
			for (int index = 0; index < CAVES_MAX; index++)
			{
				if (caveConnections[currentCave, index])
					compoundCave[index] = neighbors[index];
				else
					compoundCave[index] = 0;
			}
			return compoundCave;
		}

        /*
         * Returns the direction of cave with respect to the current cave.
         * 
         * @param currentCave - ID of cave
         *  destinationCave - destination cave relative to currentCave
         * 
         * @return int (0-5) depending on direction. -1 is returned if there's an error.
         */
		public int getDirectionOfNeighbor(int currentCave, int destinationCave)
		{
			int[] currentCaveNeighbor = getNeighborCaves(currentCave);
			for (int a = 0; a < CAVES_MAX; a++)
			{
				if (currentCaveNeighbor[a] == destinationCave)
					return a;
			}
			return -1;
		}
	}
}
