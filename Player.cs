using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoulSim
{
    struct Bet
    {
        public bool PlaceBet;
        public decimal Amount;
    };

    class Player
    {
        public decimal Money;

        // betting strategy
        int lastNumber = 0;
        int lastColumn = 0;
        int lastColumnCount;

        // stats
        int[] columnCount = new int[20];

        public Player(decimal initialMoney)
        {
            Money = initialMoney;
        }

        public Bet GetBet()
        {
            // get last columns
            int column = GetColumn(lastNumber);
            if( column > 0) // ignore Zero
            {
                if (column == lastColumn)
                {
                    lastColumnCount++;

                    // update stats
                    columnCount[lastColumnCount]++;
                }
                else
                {
                    lastColumn = column;
                    lastColumnCount = 0;
                }
            }


            // bet strategy
            Bet bet = new Bet();            

            // TODO!!!
            bet.PlaceBet = true;
            bet.Amount = 1;

            // give money
            Money -= (bet.Amount*2); // two columns in one bet!

            return bet;
        }

        public void MoneyGained(decimal moneyGained)
        {
            Money += moneyGained;
        }

        public void LastNumberPlayed(int number)
        {
            lastNumber = number;
        }

        public int[] GetColumnStats()
        {
            return columnCount;
        }

        private int GetColumn(int number)
        {
            if (number == 0) return 0;
            else if ((number % 3) == 1) return 1;
            else if ((number % 3) == 2) return 2;
            else return 3;
        }
    }
}
