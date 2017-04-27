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

        enum EBettingPhase {  Wait, Bet, SecondBet };
        EBettingPhase strategyBettingPhase;

        // betting strategy
        int lastNumber = 0;
        int lastColumn = 0;
        int lastColumnCount;

        int strategyColInRow;
        decimal strategyBetAmount;

        // stats
        int[] columnCount = new int[20];

        int statBets = 0;
        int statSecondBets = 0;

        public Player(decimal initialMoney)
        {
            Money = initialMoney;
            strategyBettingPhase = EBettingPhase.Wait;
            statBets = 0;
            statSecondBets = 0;
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
            else
            {
                lastColumn = column;
                lastColumnCount = 0;
            }


            // bet strategy
            Bet bet = new Bet();            

            if( strategyBettingPhase == EBettingPhase.Wait)
            {
                // place initial bet?
                if( (column == 1) && lastColumnCount == strategyColInRow )
                {
                    bet.PlaceBet = true;
                    bet.Amount = strategyBetAmount;
                    strategyBettingPhase = EBettingPhase.Bet;
                    statBets++;
                }
            }
            else if(strategyBettingPhase == EBettingPhase.Bet)
            {
                // make second bet?
                if (column == 0 || column == 1)
                {
                    bet.PlaceBet = true;
                    bet.Amount = strategyBetAmount*3;
                    strategyBettingPhase = EBettingPhase.Wait; // done
                    statSecondBets++;
                }
                else strategyBettingPhase = EBettingPhase.Wait; // done
            }            

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

        public void GetBetStats(out int bets, out int secondBets)
        {
            bets = statBets;
            secondBets = statSecondBets;
        }

        private int GetColumn(int number)
        {
            if (number == 0) return 0;
            else if ((number % 3) == 1) return 1;
            else if ((number % 3) == 2) return 2;
            else return 3;
        }

        public void SetBettingStrategy(decimal betAmount, int betColInRow)
        {
            strategyColInRow = betColInRow;
            strategyBetAmount = betAmount;
        }
    }
}
