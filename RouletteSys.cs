using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoulSim
{
    class RouletteSys
    {
        private Bet ActiveBet;
        private int SpinnedNumber;
        private decimal MoneyGained;

        // Stats
        private int[] NumberOccurences = new int[37];
        private int[] ColumnOccurences = new int[4]; // zero is number zero
        private int NumberOfSpins = 0;
        private int NumberOfBets = 0;

        public void PlaceBet(Bet bet)
        {
            ActiveBet = bet;
        }

        public void SpinTheWheel()
        {
            int number = GetRandomNumber();
            SpinnedNumber = number;
            MoneyGained = 0;

            int column = GetColumn(number);

            // check bets
            if (ActiveBet.PlaceBet)
            {
                NumberOfBets++;
                if (column == 2 || column == 3)
                {
                    // win
                    MoneyGained = ActiveBet.Amount * 3;
                }
                else
                {
                    // lose
                    MoneyGained = 0;
                }                          
            }

            // update stats
            NumberOccurences[number]++;
            ColumnOccurences[column]++;

            NumberOfSpins++;
        }

        public decimal GainedMoney()
        {
            return MoneyGained;
        }

        public int GetNumber()
        {
            return SpinnedNumber;
        }

        public void GetStats(out int[] numberOccurences, out int[] columnOccurences, out int numberOfSpins, out int numberOfBets)
        {
            numberOccurences = NumberOccurences;
            columnOccurences = ColumnOccurences;
            numberOfSpins = NumberOfSpins;
            numberOfBets = NumberOfBets;
        }

        private int GetColumn(int number)
        {
            if (number == 0) return 0;
            else if ((number % 3) == 1) return 1;
            else if ((number % 3) == 2) return 2;
            else return 3;
        }



        // TODO: Make real random function
        Random r = new Random();
        private int GetRandomNumber()
        {
            int number = r.Next(0, 37);

            return number;
        }
    }
}
