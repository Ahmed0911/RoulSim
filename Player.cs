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

        public Player(decimal initialMoney)
        {
            Money = initialMoney;
        }

        public Bet GetBet()
        {
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
    }
}
