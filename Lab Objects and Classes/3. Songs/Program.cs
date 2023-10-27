using System;
using System.Collections.Generic;
using System.Globalization;

namespace _3._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberSongs = int.Parse(Console.ReadLine());

            List<Song> playlist = new List<Song>();

            for (int i = 0; i < numberSongs; i++)
            {
                string[] tokens = Console.ReadLine().Split("_");

                string type = tokens[0];
                string name = tokens[1];
                string time = tokens[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;
                playlist.Add(song);
            }

            string filter = Console.ReadLine();
            if (filter != "all")
            {
                foreach (Song song in
                    playlist)
                {
                    if (song.TypeList == filter)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
                return;
            }
            foreach (Song song in playlist)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
    class Song 
    { 
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

}
