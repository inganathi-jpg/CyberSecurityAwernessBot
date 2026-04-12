using System;
using System.Media;
using System.IO;

namespace CyberSecurityAwarenessBot
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                // Construct the path to the audio file
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "greeting.wav");

                // Check if the file exists before trying to play it
                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            catch
            {
                // If there's an error (like the file not being found), we can just ignore it and continue
                Console.WriteLine("Audio could not be played.");
            }
        }
    }
}