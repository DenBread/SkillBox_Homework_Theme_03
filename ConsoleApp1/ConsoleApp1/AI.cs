using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AI
    {
        public string NameBot { get; private set; } = "BOT";

        public int GenerationNumber()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }
    }
}
