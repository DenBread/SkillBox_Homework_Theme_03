using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GameNumbers
    {
        public int MinNumber { get; private set; }
        public int MaxNumber { get; private set; }

        public int GameNumber { get; private set; }


        public int GenerationRandomNumber(int minNumber, int maxNumber)
        {
            Random random = new Random();
            return GameNumber = random.Next(minNumber, maxNumber);
        }
    }
}
