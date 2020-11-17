using System;



namespace SongsAndVotesCommon.BusinessObjects
{



    /// <summary>
    /// Represents a song in SongsAndVotes.
    /// </summary>
    public class Song
    {

        public string FilePath { get; set; }

        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public int TrackNo { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="filePath">Full path to the song file.</param>
        public Song(string filePath)
        {
            this.FilePath = filePath;
        }

    }



}
