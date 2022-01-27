using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GameTest
    {
        private Players Players;
        private GameNumbers GameNumbers;
        private int minNumber;
        private int maxNumber;
        private int gameNumbers;
        private int countPlayer;


        public void Start()
        {
            Players = new Players();
            GameNumbers = new GameNumbers();

            Console.WriteLine("Выберите пункт");
            Console.WriteLine("1) Играть с игроками");
            //Console.WriteLine("2) Играть с ботом");
            Console.Write("Ваш выбор: ");

            bool chouseGame = int.Parse(Console.ReadLine()) == 1 ? true : false;


            if (chouseGame)
            {
                Console.Write("Напишите кол-во игроков: ");
                countPlayer = int.Parse(s: Console.ReadLine());
                MaxMinNumber();
                gameNumbers = GameNumbers.GenerationRandomNumber(minNumber, maxNumber);
            }


            

            

            Players.RandomChoosePlayer();
            MotionPlayer(Players.Name, gameNumbers);
        }

        private void MaxMinNumber()
        {
            Players.CreatPlayer(countPlayer);

            Console.WriteLine("Введите минимальное и максимальное число для рандомной генерации:");
            Console.Write("Минимальное число: ");
            minNumber = int.Parse(Console.ReadLine());

            Console.Write("Максимальное число: ");
            maxNumber = int.Parse(Console.ReadLine());
        }


        public void MotionPlayer(List<string> names, int gameNumber)
        {
            while (gameNumber > 0)
            {
                foreach (string name in names)
                {
                    Console.WriteLine($"Игровое число {gameNumber}");
                    Console.Write($"Ход {name}: ");
                    int n = int.Parse(Console.ReadLine());
                    gameNumber = CheckNumberInput(n, gameNumber);

                    if (gameNumber == 0)
                    {
                        FinishPlayer(name);
                        break;
                    }
                }
            }
            
        }

        public void FinishPlayer(string name)
        {
            Console.WriteLine($"Выграл игрок {name}");
        }

        public int CheckNumberInput(int number, int gameNumber)
        {
            if(number >= 0 && number <= 4)
            {
                bool numberCheck = gameNumber - number < 0 ? true : false;

                if(numberCheck)
                {
                    Console.WriteLine("Число не должно быть в минусе...");
                    return gameNumber;
                }

                return gameNumber -= number;
            }
            else
            {
                Console.WriteLine($"Введите число от 1 до 4. Число {number} не допускаеться...");
            }

            return gameNumber;
        }
    }
}
