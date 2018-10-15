using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SwitchTrack : Track
    {
        Track TrackOne { get; set; }
        Track TrackTwo { get; set; }


        public SwitchTrack(char value, Square square)
        {
            ObjectType = value;
            Square = square;
        }

        public void switchTrack()
        {
            //deze methode veranderd de next van 1 van de 2 options
            //of veranderd de next van de switch track
        }
    }
}
