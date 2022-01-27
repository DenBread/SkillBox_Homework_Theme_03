using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Game
    {
        private string namePlayerOne, namePlayerTwo; // поля для хранения имен играков
        private int numberMin = 12, numberMax = 120; // генерация рандомного число от и до
        private int gameNumber; // игровое число
        private int maxNumber = 4; // Максимальное число для ввода играком
        private int userTry; // поле для ввода числа игроком
        private bool progressPlayer = true; // меняем игрока по очереди. True - первый игрок, false - второй игрок
        private bool isNumberTrue;
        private bool statusWin = false;
        public void Start()
        {
            gameNumber = RandomNumbers();
            //gameNumber = 4;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Давайте познакомимся! Я игра <<Угадай число>>. А как тебя зовут?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Имя первого игрока: ");
            namePlayerOne = Console.ReadLine();

            Console.Write("Имя второго игрока: ");
            namePlayerTwo = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Приятно познакомиться {namePlayerOne} и {namePlayerTwo}!");
            Console.WriteLine($"Давайте обьясню правила:\n " +
                              $"- я (программа) загадываю число от {numberMin} до {numberMax}\n " +
                              $"- Игроки ходят по очереди\n" +
                              $" - Игрок, ход которого указан вводит число, которое может принимать значения 1, 2, 3 или 4\n");
            Console.ForegroundColor = ConsoleColor.White;

            while (!statusWin)
            {
                CheckProgress();
            }
            
        }

        private void CheckProgress()
        {
            if (progressPlayer && gameNumber >= 0 && !statusWin)
            {
                Console.WriteLine($"Число: {gameNumber}");
                Console.Write($"- Ход {namePlayerOne}: ");

                try
                {
                    userTry = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Не коректно написано число...");
                }
                gameNumber -= CheckNumber(userTry, namePlayerOne);

                if (gameNumber == 0)
                {
                    progressPlayer = true;
                }
                else
                {
                    progressPlayer = false;
                    Console.WriteLine();
                }
            }

            if (!progressPlayer && gameNumber >= 0 && !statusWin)
            {
                Console.WriteLine($"Число: {gameNumber}");
                Console.Write($"- Ход {namePlayerTwo}: ");

                try
                {
                    userTry = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Не коректно написано число...");
                }


                gameNumber -= CheckNumber(userTry, namePlayerTwo);

                if (gameNumber == 0)
                {
                    //statusWin = true;
                    //Console.WriteLine("Ты выграл!");
                    progressPlayer = false;
                }
                else
                {
                    progressPlayer = true;
                    Console.WriteLine();
                }
            }

        }

        /// <summary>
        /// Проверка числа и возращает его
        /// </summary>
        /// <param name="number">Число введенное играком</param>
        /// <param name="namePlayer">Имя игрока</param>
        /// <returns></returns>
        private int CheckNumber(int number, string namePlayer)
        {
            while (true)
            {
                switch (number)
                {
                    case 1:
                        if(gameNumber - 1 > 0)
                            isNumberTrue = true;
                        if (gameNumber - 1 < 0)
                        {
                            Console.WriteLine("Число не может быть меньше нуля...");
                            return 0;
                        }
                        if (gameNumber - 1 == 0)
                        {
                            Console.WriteLine("Ты выграл!");
                            statusWin = true;
                        }
                        break;
                    case 2:
                        if (gameNumber - 2 > 0)
                            isNumberTrue = true;
                        if (gameNumber - 2 < 0)
                        {
                            Console.WriteLine("Число не может быть меньше нуля...");
                            return 0;
                        }
                        if (gameNumber - 2 == 0)
                        {
                            Console.WriteLine("Ты выграл!");
                            statusWin = true;
                        }
                        break;
                    case 3:
                        if (gameNumber - 3 > 0)
                            isNumberTrue = true;
                        if (gameNumber - 3 < 0)
                        {
                            Console.WriteLine("Число не может быть меньше нуля...");
                            return 0;
                        }
                        if (gameNumber - 3 == 0)
                        {
                            Console.WriteLine("Ты выграл!");
                            statusWin = true;
                        }
                        break;
                    case 4:
                        if (gameNumber - 4 > 0)
                            isNumberTrue = true;
                        if (gameNumber - 4 < 0)
                        {
                            Console.WriteLine("Число не может быть меньше нуля...");
                            return 0;
                        }
                        if (gameNumber - 4 == 0)
                        {
                            Console.WriteLine("Ты выграл!");
                            statusWin = true;
                            isNumberTrue = true;
                        }
                        break;
                    default:
                        //Console.WriteLine("Не коректное число. Введите ещё раз...");
                        isNumberTrue = false;
                        break;
                }


                if (isNumberTrue) // если число верно, то выходим из while
                {
                    return number;
                    break; // выход из while
                }
                else // иначе игрок пишет сново число
                {
                    try // проверяем не написал ли игрок больше четырех
                    {
                        if (number > 4)
                        {
                            Console.WriteLine("Нужно ввести 1, 2, 3 или 4, но не больше...");
                            Console.Write($"- Ход {namePlayer}: ");
                            number = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.Write($"- Ход {namePlayer}: ");
                            number = int.Parse(Console.ReadLine());
                        }
                    }
                    catch // если он написал букву, а не цыфру
                    {
                        Console.WriteLine("Не коректно написано число. Введите ещё раз...");
                    }
                }
            }
        }


        private int RandomNumbers()
        {
            Random random = new Random();
            return random.Next(numberMin, numberMax);
        }
    }
}
