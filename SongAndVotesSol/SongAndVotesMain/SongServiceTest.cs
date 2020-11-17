using SongsAndVotesCommon.BusinessObjects;
using SongsAndVotesCommon.Services;
using System;



namespace SongsAndVotesMain
{



    /// <summary>
    /// To test the SongService class.
    /// </summary>
    public class SongServiceTest
    {

        public void TestLoadSongMetadata(string pathToSong)
        {
            //string pathToSong = @"X:\třeťák dude\PGR\SongAndVotes\202001014_hodina\SongAndVotesSol\Recources\Yshwa_-_01_-_ride_out.mp3";
            Song song = new Song(pathToSong);
            SongService songService = new SongService();
            songService.LoadSongMetadata(song);
            Console.WriteLine();
            // Display ID3 information.
            Console.WriteLine(
                "{0}"
                + "Title:                  {1}{0}"
                + "Artist:                 {2}{0}"
                + "Album:                  {3}{0}"
                + "Year:                   {4}{0}"
                + "Track #:                {5}{0}"
                + "{0}{0}",
                Environment.NewLine,
                song.Title,
                song.Artist,
                song.Album,
                song.Year,
                song.TrackNo
                );
        }

    }



}
