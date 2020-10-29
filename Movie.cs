using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BlockbusterLabRedux
{
    abstract class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, string Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {Runtime}");
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine($"{i + 1}: {scene}");
            }
        }

        public void PrintScene(int i)
        {
            string scene = Scenes[i];
            Console.WriteLine($"{i + 1}: {scene}");
        }

        public abstract void Play();
    }
}
