using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BlockbusterLabRedux
{
    class DVD : Movie
    {
        public DVD(string Title, string Category, int Runtime, List<String> Scenes) : base(Title, Category, Runtime, Scenes)
        {

        }
        public override void Play()
        {
            while (true)
            {
                PrintScenes();
                Console.WriteLine();
                Console.WriteLine("What scene would you like to watch?");
                Console.WriteLine();
                int i = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine();
                Console.WriteLine(Scenes[i]);
                Console.WriteLine();
                Console.WriteLine("Watch another scene? [y/n]");
                Console.WriteLine();
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "y")
                {
                    continue;
                } 
                if (userInput == "n")
                {
                    Console.Clear();
                    Console.WriteLine();
                    break;
                }
            }
        }

    }
}
