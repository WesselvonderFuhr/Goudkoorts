using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PlayField
    {
        private FieldData fieldData;
        Square[,] field;

        PlayField(FieldData fieldData)
        {
            this.fieldData = fieldData;
            field = new Square[fieldData.numberOfRows(), fieldData.numberOfColumns()];
        }

        private void fillArray()
        {
            for(int i=0;i< field.GetLength(0); i++)
            {
                for(int j=0; j< field.GetLength(1); j++)
                {
                    field[i, j] = new Square(fieldData.getDataWithIndexIndex(i,j));    
                }
            }
        }



    }
}
