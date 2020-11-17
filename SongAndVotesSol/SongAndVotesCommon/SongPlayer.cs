using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace SongAndVotesCommon
{
    public class SongPlayer
    {
       public void PlaySong(string filepath)
        {
            AudioFileReader audioFile = null;
            WaveOutEvent outputDevice = null;

            try
            {
                audioFile = new AudioFileReader(filepath);
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
