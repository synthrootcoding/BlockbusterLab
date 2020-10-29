using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLabRedux
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Blockbuster()
        {
            List<string> scenes1 = new List<string>();
            scenes1.Add("Narrator meets Tyler");
            scenes1.Add("Narrator and Tyler start Fight Club");
            scenes1.Add("Narrator kills Tyler");
            VHS v1 = new VHS("Fight Club", "Action", 151, scenes1);

            List<string> scenes2 = new List<string>();
            scenes2.Add("McConaughey leaves family for space trip");
            scenes2.Add("Everything goes wrong");
            scenes2.Add("Everything fixes itself and McConaughey sees his daughter one last time");
            VHS v2 = new VHS("Interstellar", "Action", 169, scenes2);

            List<string> scenes3 = new List<string>();
            scenes3.Add("Jay gets curse");
            scenes3.Add("Jay runs from curse");
            scenes3.Add("Jay rids curse... or does she?");
            VHS v3 = new VHS("It Follows", "Horror", 107, scenes3);

            List<string> scenes4 = new List<string>();
            scenes4.Add("Stock market crashes");
            scenes4.Add("Jordan scams poor people with penny stocks and gets filthy rich");
            scenes4.Add("Jordan gets arrested");
            DVD d1 = new DVD("Wolf of Wall Street", "Comedy", 190, scenes4);

            List<string> scenes5 = new List<string>();
            scenes5.Add("Someone rigs the Goblet of FIre");
            scenes5.Add("Harry goes for a swim");
            scenes5.Add("Edward from Twilight dies");
            DVD d2 = new DVD("Harry Potter: Goblet of FIre", "Action", 157, scenes5);

            List<string> scenes6 = new List<string>();
            scenes6.Add("Jason Statham loses his fighter for a fixed boxing match");
            scenes6.Add("Jason Statham finds a new fighter for a fixed boxing match");
            scenes6.Add("Jason Statham's new fighter doesn't fix the match");
            DVD d3 = new DVD("Snatch", "Comedy", 104, scenes6);

            Movies.Add(v1); Movies.Add(v2); Movies.Add(v3); Movies.Add(d1); Movies.Add(d2); Movies.Add(d3);
        }

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine((i + 1) + ": " + m.Title);
            }
        }

        public Movie Checkout()
        {
            Console.WriteLine("Blockbuster Movie List");
            Console.WriteLine("==========");
            PrintMovies();
            Console.WriteLine();
            string userInput = Console.ReadLine();
            int index = int.Parse(userInput) - 1;
            Movie output = Movies[index];
            return output;
        }
    }
}
