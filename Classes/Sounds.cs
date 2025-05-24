using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221Part1.Classes
{
    class Sounds
    {
        /// <summary>
        /// Creates SoundPlayer objects for greeting and bye sounds.
        /// </summary>
        private readonly SoundPlayer GreetingSound;
        private readonly SoundPlayer ByeSound;
        
        /// <summary>
        /// Default constructor for the Sounds class that initializes the SoundPlayer objects.
        /// </summary>
        public Sounds()
        {
            // Initialize the SoundPlayer objects for greeting and bye sounds
            GreetingSound = new SoundPlayer(Properties.Resources.Greeting);
            ByeSound = new SoundPlayer(Properties.Resources.Bye);
        }

        /// <summary>
        /// Plays the greeting sound.
        /// </summary>
        public void PlayGreetingSound()
        {
            ///<summary>
            /// Uses try and catch to handle any exceptions that may occur during sound playback.
            /// </summary>
            try
            {
                GreetingSound.Play(); // Play the greeting sound
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️Error: " + ex.Message); // Display error message if sound playback fails
            }
            
        }

        /// <summary>
        /// Plays the bye sound.
        /// </summary>
        public void PlayByeSound()
        {
            try
            {
                ByeSound.Play(); // Play the bye sound
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️Error: " + ex.Message); // Display error message if sound playback fails
            }
        }

    }
}
////////////////////////////////////_-_-_-_-_-_-_-_-_-_  END OF FILE  _-_-_-_-_-_-_-_-_-_////////////////////////////////////