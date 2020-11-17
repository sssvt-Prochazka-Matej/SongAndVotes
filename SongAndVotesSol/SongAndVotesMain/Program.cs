using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongAndVotesCommon;
using SongsAndVotesMain;
using System.IO;

namespace SongAndVotesMain
{
    class Program
    {
        static void Main(string[] args)
        {
            // string filePath = @"X:\třeťák dude\PGR\SongAndVotes\20200909_hodina\SongAndVotesSol\Recources\Yshwa_-_01_-_ride_out.mp3";
            //SongPlayer pisen = new SongPlayer();

            //pisen.PlaySong(filePath);

            SongServiceTest test = new SongServiceTest();
            test.TestLoadSongMetadata(@"C:\Users\matej\Desktop\SongyPGR\Yshwa\Yshwa_-_01_-_ride_out.mp3");

            string pathToLibrary = @"C:\Users\matej\Desktop\SongyPGR";

            BrowseLibrary(pathToLibrary);




            Console.ReadKey(true);

        }

        static void BrowseLibrary(string pathToLibrary)
        {
            string[] directories = Directory.GetDirectories(pathToLibrary);
            
            for(int i = 0; i < directories.Length; i++)
            {
                DirectoryInfo currentDir = new DirectoryInfo(directories[i]);
                Console.WriteLine(currentDir.Name);

                string[] files = Directory.GetFiles(directories[i]);
                
                for(int ii = 0; ii < files.Length; ii++)
                {
                    SongServiceTest song = new SongServiceTest();
                    song.TestLoadSongMetadata(files[ii]);
                }
            }
        }
                
                

            
            

    }
}
