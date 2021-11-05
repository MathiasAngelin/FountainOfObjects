using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    internal class Map
    {
        public int X { get; set; }
        public int Y { get; set; }
        private bool FountainEnabled = false;
        private Player player = new Player();
        public bool victoryStatus = false;
        private MovementCheck movementchecker = new MovementCheck();

        public void DrawMap()
        {
            Console.ResetColor();
            Console.WriteLine($"You are in the room at (Row:={X}, Collumn ={Y}).");
            CheckSpecialPositions();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine();
            Console.ResetColor();
            PlayerMovement(input);
            X = player.X;
            Y = player.Y;
            Console.WriteLine();
        }

        public void PlayerMovement(string input)
        {
            if (input == "east")
            {
                if (movementchecker.CheckEast(player.Y))
                    player.Y++;
            }
            if (input == "west")
            {
                if (movementchecker.CheckWest(player.Y))
                    player.Y--;
            }
            if (input == "north")
            {
                if (movementchecker.CheckNorth(player.X))
                    player.X--;
            }
            if (input == "south")
            {
                if (movementchecker.CheckSouth(player.X))
                    player.X++;
            }
            if (input == "enable fountain")
            {
                if (X == 0 & Y == 2)
                {
                    FountainEnabled = true;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Nice, it's now turned on!");
                }
                else
                {
                    Console.WriteLine("There is no fountain here..");
                }
            }
        }

        public void CheckSpecialPositions()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //in foundtain room
            if (X == 0 && Y == 2)
            {
                if (FountainEnabled == false)
                {
                    Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
                }
                else
                {
                    Console.WriteLine("The fountain is on, nothing to see here");
                }
            }
            //in entrance
            else if (X == 0 && Y == 0)
            {
                if (FountainEnabled == true)
                {
                    Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life! You win!");
                    victoryStatus = true;
                }
                else
                {
                    Console.WriteLine("You see light coming from the cavern entrance.");
                }
            }

            Console.ResetColor();
            if (victoryStatus == false)
                Console.WriteLine("What do you want do do?");
        }
    }
}