using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Songs
{
    internal class Program
    {
        /*
         Define a class called Song that will hold the following information about some songs:
            · Type List
            · Name
            · Time

            Input / Constraints
            · On the first line, you will receive the number of songs - N.
            · On the next N lines, you will be receiving data in the following format: "{typeList}_{name}_{time}".
            · On the last line, you will receive Type List or "all".

            Output
            If you receive Type List as an input on the last line, print out only the names of the songs, which are from that Type List. If you receive the "all" command, print out the names of all the songs.


            Input                                   Output

            3
            favourite_DownTown_3:14                 DownTown
            favourite_Kiss_4:16                     Kiss
            favourite_Smooth Criminal_4:01          Smooth Criminal
            favourite 
                     */

        public class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }

        }
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            //To hold all the songs
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] currentSong = Console.ReadLine().Split('_').ToArray();
                string type = currentSong[0];
                string name = currentSong[1];
                string time = currentSong[2];

                Song song= new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Song song in songs) 
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
