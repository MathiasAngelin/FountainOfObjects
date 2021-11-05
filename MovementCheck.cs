using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FountainOfObjects
{
    class MovementCheck
    {


        public bool CheckEast(int Y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (Y <= 2)
                return true;
            else
                Console.WriteLine("You cannot go that way");
            return false;
        }

        public bool CheckWest(int Y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (Y >= 1)
                return true;
            else
                Console.WriteLine("You cannot go that way");
            return false;
        }

        public bool CheckNorth(int X)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (X >= 1)
                return true;
            else
                Console.WriteLine("You cannot go that way");
            return false;
        }

        public bool CheckSouth(int X)
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
