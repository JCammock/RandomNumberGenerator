using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Generator
{
    class Randomiser
    {
        private int number;

        public void GenerateNumber(int numberOne, int numberTwo)
        {
            Random r = new Random();
            number = r.Next(numberOne, numberTwo);
        }

        public int GetNumber()
        {
            return number;
        }
    }
}
