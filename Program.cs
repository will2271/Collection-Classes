﻿using System;
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
            foreach (Player player in playerList)
            {
                Console.WriteLine($"{player.Name}: {player.Score}");
            }


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
    class Player
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
    }
}
