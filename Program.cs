using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BlockbusterLabRedux
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Blockbuster! Select which movie you would like to watch");
                Console.WriteLine();

                Blockbuster bb = new Blockbuster();
                Movie m = bb.Checkout();
                Console.Clear();
                Console.WriteLine($"You selected: ");
                Console.WriteLine();
                m.PrintInfo();
                Console.WriteLine();
                m.Play();
                Console.WriteLine();
                Console.WriteLine("Check out another movie?[y/n]");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    continue;
                }
                if (userInput == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
            }
        }
    }
}
