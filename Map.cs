using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    internal class Map
    {
        private int X = 0;
        private int Y = 0;
        private bool FountainEnabled = false;
        private Player player = new Player();
        public bool victoryStatus = false;

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
                if (CheckEast())
                    player.Y++;
            }
            if (input == "west")
            {
                if (CheckWest())   
                player.Y--;             
            }
            if (input == "north")
            {
               if (CheckNorth())
                player.X--;
            }
            if (input == "south")
            {
               if (CheckSouth())
                player.X++;
            }
            if (input == "enable fountain")
            {

                if (X==0 & Y ==2)
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
                if(FountainEnabled == false)
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
            if(victoryStatus == false)
                Console.WriteLine("What do you want do do?");
        }

        public bool CheckEast()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (Y <= 2)
                return true;
            else
                Console.WriteLine("You cannot go that way");
            return false;
        }

        public bool CheckWest()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (Y >= 1)
                return true;
            else
                Console.WriteLine("You cannot go that way");
            return false;
        }

        public bool CheckNorth()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (X >= 1)
                return true;
            else
                Console.WriteLine("You cannot go that way");
            return false;
        }

        public bool CheckSouth()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (X <= 2)
                return true;
            else
                Console.WriteLine("You cannot go that way");
            return false;
        }
       
    }
}