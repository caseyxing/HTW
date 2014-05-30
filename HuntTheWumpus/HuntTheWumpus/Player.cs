using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuntTheWumpus
{
    class Player
    {
        private const int ARROW_PURCHASE = 2, SCORE_WIN_CONSTANT = 100,
            ARROW_MULTIPLIER = 10, DEFAULT_ARROW_COUNT = 3, DEFAULT_TURN_COUNT = 0,
            DEFAULT_COIN_COUNT = 10;
        private int arrows, goldCoins, turns;

        public Player() 
        {
            // initialize the defaults for a new player
            arrows = ARROW_PURCHASE;
            goldCoins = DEFAULT_COIN_COUNT;
            turns = DEFAULT_TURN_COUNT;
        }

        public Player(int arrows, int goldCoins, int turns)
        {
            this.arrows = arrows;
            this.goldCoins = goldCoins;
            this.turns = turns;
        }

        public int Arrows
        {
            get { return arrows; }
            set { arrows = value; }
        }

        public int GoldCoins
        {
            get { return goldCoins; }
            set { goldCoins = value; }
        }

        public int Turns
        {
            get { return turns; }
            set { turns = value; }
        }

        // Successful purchase through trivia questions
        public void purchaseArrowsSuccess()
        {
            arrows += ARROW_PURCHASE;
        }

        // Increment gold after moving tunnels
        public void moveGoldIncrement()
        {
            goldCoins++;
        }

        // Each time a question is asked, a coin is subtracted
        public void triviaQuestionAsked()
        {
            goldCoins--;
        }

        // The game progresses; increment the turn
        public void incrementTurn()
        {
            turns++;
        }

        // Returns the player's final score after killing the Wumpus
        public int computeScore()
        {
            return SCORE_WIN_CONSTANT - turns + goldCoins + (ARROW_MULTIPLIER * arrows);
        }
    }
}
