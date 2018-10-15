using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Square
    {
        public FieldObject fieldObject;

        public Square(char value)
        {

        }

        private void setContent(char value)
        {
            switch (value)
            {

                case '_':
                    FieldObject = new StandardTrack('_');
                    break;
                case '@':
                    GameObject = new Player('@', this);
                    break;

                case 'o':
                    GameObject = new Chest('o', this);
                    break;

                case 'x':
                    isDesitination = true;
                    break;

                case '.':
                    IsFloor = true;
                    break;

                default:
                    IsVoid = true;
                    break;


            }
        }
    }
}
