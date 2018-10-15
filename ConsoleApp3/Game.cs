using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Game
    {
        private InputView input   { get; set; }
        private OutputView output { get; set; }
        private PlayField playField { get; set; }
        private FieldData fieldData { get; set; }

        public void start()
        {
            output.showTutuorial();
        }
    }
}
