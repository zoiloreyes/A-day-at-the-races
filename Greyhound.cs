using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace A_Day_at_the_races
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        static public Random Randomizer = new Random();

        public bool Run()
        {
            Location += Randomizer.Next(1, 5);
            MyPictureBox.Left = StartingPosition + Location;
            if(MyPictureBox.Width + Location >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            StartingPosition = 0;
            Location = 0;
        }
    }
}
