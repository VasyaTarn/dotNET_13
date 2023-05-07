using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_13
{
    class Game
    {
        private string name;
        private string rules;
        private string author;
        public Game(string name, string rules, string author)
        {
            this.name = name;
            this.rules = rules;
            this.author = author;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Rules
        {
            get
            {
                return rules;
            }
            set
            {
                rules = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public void NewGame(Game game)
        {
            Console.WriteLine($"New game {game.Name}");
        }
        public void DownloadGame(Game game)
        {
            Console.WriteLine($"Downloading game {game.Name}");
        }
        public void ShowRules(Game game)
        {
            Console.WriteLine($"Rules:\n{game.Rules}");
        }
        public void ShowAuthor(Game game)
        {
            Console.WriteLine($"The author is {game.Author}");
        }
        public void Exit(Game game)
        {
            Console.WriteLine($"The game {game.Name} closed");
        }
    }
}
