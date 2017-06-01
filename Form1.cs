using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_races
{
    public partial class Form1 : Form
    {
        Greyhound[] Dogs;
        Guy[] Guys;
        public Form1()
        {
            InitializeComponent();
            Dogs = new Greyhound[4];
            Dogs[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                RacetrackLength = raceTrack.Width
            };
            Dogs[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                RacetrackLength = raceTrack.Width
            };
            Dogs[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                RacetrackLength = raceTrack.Width
            };

            Dogs[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                RacetrackLength = raceTrack.Width
            };
            Guys = new Guy[3];
            Guys[0] = new Guy()
            {
                Name = "Joe",
                Cash = 100,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };

            Guys[1] = new Guy()
            {
                Name = "Bob",
                Cash = 100,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };

            Guys[2] = new Guy()
            {
                Name = "Al",
                Cash = 100,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };
            minimumBetLabel.Text = "Minimum bet: " + betNumeric.Minimum.ToString() + " bucks";
            for(int i = 0; i < 3; i++)
            {
                Guys[i].MyRadioButton.Text = Guys[i].Name + " has " + Guys[i].Cash + " Bucks";
            }
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++)
            {
                if (Dogs[i].Run())
                {
                    timer1.Stop();
                    MessageBox.Show("Dog #" + (i + 1) + " won the race!", "We have a winner");
                    for(int f = 0; f < 3; f++)
                    {
                        Guys[f].Collect(i + 1);
                    }
                }
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentBetterLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentBetterLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentBetterLabel.Text = "Al";
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                Guys[0].PlaceBet((int)betNumeric.Value, (int)dogNumeric.Value);
            }else if (bobRadioButton.Checked) {
                Guys[1].PlaceBet((int)betNumeric.Value, (int)dogNumeric.Value);
            }
            else
            {
                Guys[2].PlaceBet((int)betNumeric.Value, (int)dogNumeric.Value);
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            for(int i = 0; i < 4; i++)
            {
                Dogs[i].TakeStartingPosition();

            }

        }
    }
}
