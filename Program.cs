﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
            Console.WriteLine("Waiting for your Implementation");
            Console.WriteLine("Press any key to exit...");
            Console.WriteLine("Test commit");
            Console.WriteLine("Test commit line 2");
            Console.WriteLine("Test commit line 3");
            Console.WriteLine("Test commit line 4");
            Console.ReadKey();
        }
    }
}
