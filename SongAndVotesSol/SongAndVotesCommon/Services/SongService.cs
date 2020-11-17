using SongsAndVotesCommon.BusinessObjects;
using System;
using NAudio.Wave;


namespace SongsAndVotesCommon.Services
{



    /// <summary>
    /// Provides API methods related to songs.
    /// </summary>
    public class SongService
    {

        /// <summary>
        /// Loads ID3 metadata from the song file and stores it into a given object.
        /// </summary>
        /// <param name="song">Song to load metadata for.</param>
        public void LoadSongMetadata(Song song)
        {

            // Access to ID3 tags of a song.
            TagLib.File tagLibFile = null;

            // Try to get ID3 tag information about the selected file.
            tagLibFile = TagLib.File.Create(song.FilePath);

            // Load ID3 information about the file and store it in the given object.
            song.Title = tagLibFile.Tag.Title;
            song.Artist = tagLibFile.Tag.Performers[0];
            song.Album = tagLibFile.Tag.Album;
            song.Year = Convert.ToInt32( tagLibFile.Tag.Year );
            song.TrackNo = Convert.ToInt32( tagLibFile.Tag.Track );

            // Try to close the TagLib.File object.
            tagLibFile.Dispose();
            // Get rid of the reference to it.
            tagLibFile = null;

        }

        public void API(string filePath)
        {
            AudioFileReader audioFile = null;
            WaveOutEvent outputDevice = null;

            try
            {
                audioFile = new AudioFileReader(filePath);
                outputDevice = new WaveOutEvent();

                outputDevice.Init(audioFile);
                outputDevice.Play();

                Console.ReadKey(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                audioFile.Close();
                audioFile.Dispose();
            }
        }
    }



}
