using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleRandomizer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console window settings
            Console.Title = "Press any key";

            // Program
            Randomize();
        }
        public static void Randomize()
        {
            // Number generator
            Random randGen = new Random();

            // Arrays
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            string[] chars = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string title;

            // Main
            while (true)
            {
                Console.ReadKey();

                // Randomizes text and background colors
                Console.ForegroundColor = colors[randGen.Next(colors.Length)];
                Console.BackgroundColor = colors[randGen.Next(colors.Length)];

                // Writes stuff
                for(int i = 1; i < randGen.Next(1, 101); i++)
                {              
                    for(i = 0; i < randGen.Next(2000, 6001); i++)
                    {
                        Console.Write(chars[randGen.Next(1, 61)]);
                    }
                    Console.WriteLine(chars[randGen.Next(1, 61)]);
                }
                for (int i = 0; i < randGen.Next(1, 101); i++)
                {
                    title = chars[randGen.Next(1, 61)];
                    Console.Title = title + chars[randGen.Next(1, 61)]
                }
            }
        }
    }
}