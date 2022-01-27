using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Players
    {
        public int CointPlayer { get; private set; }
        public List<string> Name { get; private set; } = new List<string>();

        public void CreatPlayer(int cointPlayer)
        {
            if(cointPlayer != 0)
            {
                for (int i = 0; i < cointPlayer; i++)
                {
                    int p = i + 1;
                    Console.Write("Имя " + p + " игрока: ");
                    Name.Add(Console.ReadLine());
                }

            }
            else
            {
                Console.WriteLine("Do't have player");
            }
        }

        

        

        public void RandomChoosePlayer()
        {
            Random random = new Random();
            int playerId = random.Next(0, Name.Count);

            //Console.WriteLine(Name[playerId]);
            string saveName = Name[playerId];
            Name.Remove(saveName);
            Name.Insert(0, saveName);
        }
    }


}
