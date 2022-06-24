using System;

namespace ConsoleRandomizer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Randomize();
        }
        public static void Randomize()
        {
            // Number generator
            Random randGen = new Random();

            // Arrays
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            // Main
            while (true)
            {
                Console.ReadKey();
                Console.ForegroundColor = colors[randGen.Next(colors.Length)];
                Console.BackgroundColor = colors[randGen.Next(colors.Length)];
                for (int i = 0; i < 50; i++)
                {
                    Console.Write(alphabet[i]);
                }
            }
        }
    }
}