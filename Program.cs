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
            string[] chars = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "#", "¤", "%", "&", "/", "(", ")", "=", "?", "+", ":", ";", ",", ".", "-", "_" };

            // Main
            while (true)
            {
                Console.ReadKey();

                // Randomizes text and background colors
                Console.ForegroundColor = colors[randGen.Next(colors.Length)];
                Console.BackgroundColor = colors[randGen.Next(colors.Length)];

                // Configures the console title
                string[] title = new string[randGen.Next(1, 30)];
                for (int k = 0; k < title.Length; k++)
                {
                    title[k] = chars[randGen.Next(1, chars.Length)];
                }
                for (int l = 0; l < title.Length; l++)
                {
                    Console.Title = (string.Join("", title));
                }

                // Writes stuff in the console            
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    for (int j = 0; j < Console.WindowWidth; j++)
                    {
                        Console.Write(chars[randGen.Next(1, chars.Length)]);
                    }
                }
            }
        }
    }
}