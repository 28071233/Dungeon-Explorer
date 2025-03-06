using System;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;

        public Game()
        {
            // Initialize the game with one room and one player
            Console.WriteLine($"game function");

            Console.Write("Please enter your characters name: ");
            string name = Console.ReadLine();

            Player player = new Player(name, 100);
            Console.WriteLine($"{player.Name}, {player.Health}");

        }

        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                // Code your playing logic here

                Console.WriteLine("\nEnd of While loop...");
                Console.ReadKey();
            }
        }
    }
}