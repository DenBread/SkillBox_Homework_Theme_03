using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UI
    {
        public void DrowMwnu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Давайте обьясню правила:\n " +
                              $"- Игроки ходят по очереди\n" +
                              $" - Игрок, ход которого указан - вводит число. Программа принимать значения 1, 2, 3 или 4\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
