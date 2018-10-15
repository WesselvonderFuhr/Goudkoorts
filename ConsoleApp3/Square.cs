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

        public Square()
        {

        }

        private void setContent(char value)
        {
            switch (value)
            {

                case 's':
                    fieldObject = new StandardTrack('s');
                    break;
                case 'l':
                    fieldObject = new Shed('l');
                    break;

                case 'o':
                    fieldObject = new Water('w');
                    break;

                case 'v':
                    fieldObject = new SwitchTrack('v');
                    break;

                case 'c':
                    fieldObject = new CollectionTrack('c');
                    break;
            }
        }
    }
}
