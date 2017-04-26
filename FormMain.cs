using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoulSim
{
    public partial class FormMain : Form
    {
        Table table;
        Player player;
        RouletteSys rouletteSys;

        bool GameActive = false;
        int FastPlayStepSize = 1;

        public FormMain()
        {
            InitializeComponent();

            table = new Table(this);
            rouletteSys = new RouletteSys();

            // fill stats
            for (int i = 0; i != 37; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add("0");
                listViewStats.Items.Add(item);
            }
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            table.Draw();

            if(GameActive)
            {
                // Play step
                for (int i = 0; i != FastPlayStepSize; i++)
                {
                    CalulateStep();
                }
                // DRAW
                // update table
                table.Draw(rouletteSys.GetNumber());

                // update stats
                textBoxMoney.Text = player.Money.ToString();

                string numberOcc = "";
                string columnOcc = "";
                int[] numberOccurences;
                int[] columnOccurences;
                int numberOfSpins;
                int numberOfBets;
                rouletteSys.GetStats(out numberOccurences, out columnOccurences, out numberOfSpins, out numberOfBets);
                
                foreach (int i in columnOccurences)
                {
                    columnOcc += string.Format("{0},", i);
                }
                textBoxColumnOccurences.Text = columnOcc;

                for(int i=0; i!= numberOccurences.Length; i++)
                {
                    listViewStats.Items[i].SubItems[1].Text = numberOccurences[i].ToString();
                }
                textBoxNumOfSpins.Text = numberOfSpins.ToString();
                textBoxNumOfBets.Text = numberOfBets.ToString();
            }
        }

        private void CalulateStep()
        {
            // do game
            Bet bet = player.GetBet();
            rouletteSys.PlaceBet(bet);

            // Spin the wheel
            rouletteSys.SpinTheWheel();
            int number = rouletteSys.GetNumber();
            decimal moneyGained = rouletteSys.GainedMoney();

            // update player
            player.LastNumberPlayed(number);
            player.MoneyGained(moneyGained);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Start")
            {
                decimal initialMoney;
                if (decimal.TryParse(textBoxMoney.Text, out initialMoney) == false)
                {
                    initialMoney = 500;
                }
                textBoxMoney.Text = initialMoney.ToString();
                textBoxMoney.ReadOnly = true;
                buttonStart.Text = "Stop";

                player = new Player(initialMoney);
                GameActive = true;

            }
            else
            {
                // STOP...
                GameActive = false;
                buttonStart.Text = "Start";
                textBoxMoney.ReadOnly = false;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButtonSlow)
            {
                timerTick.Interval = 1000;
                FastPlayStepSize = 1;
            }

            else if (sender == radioButtonFast)
            {
                timerTick.Interval = 100;
                FastPlayStepSize = 1;
            }
            else if (sender == radioButtonMegaFast)
            {
                timerTick.Interval = 10;
                FastPlayStepSize = 1;
            }
            else if (sender == radioButtonSpeed100)
            {
                timerTick.Interval = 10;
                FastPlayStepSize = 100;
            }
            else if (sender == radioButtonSpeed1000)
            {
                timerTick.Interval = 10;
                FastPlayStepSize = 1000;
            }
            else if (sender == radioButtonSpeed10000)
            {
                timerTick.Interval = 10;
                FastPlayStepSize = 10000;
            }
            else if (sender == radioButtonSpeed100000)
            {
                timerTick.Interval = 10;
                FastPlayStepSize = 100000;
            }        
        }
    }
}