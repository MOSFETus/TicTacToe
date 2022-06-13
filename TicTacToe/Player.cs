using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        private int playerNumber;

        public int PlayerNumber {
            get
            {
                return this.playerNumber;
            }
            set
            {
                if(value == 2)
                {
                    this.playerNumber = 2;
                }
                else
                {
                    this.playerNumber = value;
                }
            }
        }

        public Player(int number)
        {
            if (number < 3 && number > 0)
                PlayerNumber = number;
            else
                throw new Exception("Enter for player value 1 or 2");
        }
    }
}
