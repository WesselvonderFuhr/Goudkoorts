using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class StandardTrack: Track
    {
        public StandardTrack(char value, Square square)
        {
            ObjectType = value;
            Square = square;
        }
    }
}
