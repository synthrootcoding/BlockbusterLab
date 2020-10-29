using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLabRedux
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public VHS(string Title, string Category, int Runtime, List<String> Scenes) :base(Title, Category, Runtime, Scenes)
        {

        }
        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine($"{CurrentTime}:{scene}");
                CurrentTime++;
                string scene2 = Scenes[CurrentTime];
                Console.WriteLine($"{CurrentTime}:{scene2}");
                CurrentTime++;
                string scene3 = Scenes[CurrentTime];
                Console.WriteLine($"{CurrentTime}:{scene3}");
                CurrentTime++;
                Console.WriteLine("You need to rewind the movie, it is over. [press enter to rewind]");
                Console.ReadLine();
                Rewind();
            }
            else
            {
                Console.WriteLine("You need to rewind the movie, it is over.");
            }
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
