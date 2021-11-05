using System;

namespace FountainOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Map myMap = new Map();

            while (myMap.victoryStatus == false)
            {
            myMap.DrawMap();
            }
        }
    }
}
