using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_13
{
    class Program
    {
        delegate void GameMethod(Game game);
        static void Main(string[] args)
        {
            Game g = new Game("GameName1", "GameRules1", "GameAuthor1");
            GameMethod[] gm1 = new GameMethod[5] { new GameMethod(g.Exit), new GameMethod(g.NewGame), new GameMethod(g.DownloadGame), new GameMethod(g.ShowRules), new GameMethod(g.ShowAuthor) };
            int answ = 1;
            while (answ != 0)
            {
                Console.WriteLine("1 - новая игра\n2 - загрузить игру\n3 - правила\n4 - об авторе\n0 - выход");
                answ = Convert.ToInt32(Console.ReadLine());
                if (answ >= 0 && answ < 5)
                {
                    gm1[answ](g);
                }
                else
                    Console.WriteLine("Wrong input");
            }
        }
    }
}

