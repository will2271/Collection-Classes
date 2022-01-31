using System;
using System.Collections.Generic;
namespace Collection_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> playerList;
            playerList = new List<Player>();



            Console.WriteLine("Indtast spillernavne - skriv stop for at afslutte. ");
            while (2 + 2 == 4)
            {
                Console.Write("Spillernavn: ");
                string name = Console.ReadLine();
                Console.Write("Spillerscore: ");
                if (name == "stop" || name == "Stop")
                {
                    break;
                }
                int score = int.Parse(Console.ReadLine());
                Player player = new Player(name, score);
                playerList.Add(player);
            }
            Console.WriteLine("Sorter efter navn eller score (n/s)?");
            var userinput = Console.ReadKey(true);
            if(userinput.Key == ConsoleKey.N)
            {
            playerList.Sort(new CompareName());
            }else if(userinput.Key == ConsoleKey.S)
            {
            playerList.Sort((x, y) => x.Score - y.Score);
            }

            foreach (Player player in playerList)
            {
                Console.WriteLine($"{player.Name}: {player.Score}");
            }


        }

        public static int CompareIt(Player p1, Player p2)
        {
            return p1.Score - p2.Score;
        }

        static void Namelist()
        {
            List<string> namelist;
            namelist = new List<string>();

            Console.WriteLine("Indtast spillernavne - skriv stop for at afslutte. ");
            while (2 + 2 == 4)
            {
                Console.Write("Spillernavn: ");
                string name = Console.ReadLine();
                if (name == "stop" || name == "Stop")
                {
                    break;
                }
                namelist.Add(name);
            }
            namelist.Sort();
            foreach (string name in namelist)
            {
                Console.WriteLine(name);
            }
        }
    }
    class Player : IComparable
    {
        string name;
        int score;

        public Player(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int CompareTo(object obj)
        {
            return Score.CompareTo((obj as Player).Score);
        }
    }
    class CompareName : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            return x.Name.CompareTo(y.Name);
        }
       
    }
}
