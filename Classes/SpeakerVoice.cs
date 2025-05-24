using System;
using System.Speech.Synthesis;

namespace PROG6221Part1.Classes
{
    class SpeakerVoice
    {
        /// <summary>
        /// creates a speech synthesizer object
        /// </summary>
        private readonly SpeechSynthesizer Speaker;

        /// <summary>
        /// Default constructor for the SpeakerVoice class that initializes the SpeechSynthesizer object.
        /// Sets the default for the speech synthesizer.
        /// </summary>
        public SpeakerVoice()
        {
            this.Speaker = new SpeechSynthesizer();// Initialize the SpeechSynthesizer object
            this.Speaker.SetOutputToDefaultAudioDevice(); // Set the output to the default audio device
            this.Speaker.Rate = 0; // Set the rate of speech
            this.Speaker.Volume = 100; // Set the volume of speech
        }

        /// <summary>
        /// Method to speak the given text.
        /// Uses try and catch to handle any exceptions that may occur during speech synthesis.
        /// </summary>
        public void Speak(string text)
        {
            try
            { 
                this.Speaker.SpeakAsyncCancelAll(); // Cancel any previous speech
                this.Speaker.SpeakAsync(text); // Speak the text asynchronously
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️Error: " + ex.Message); // Display error message if speech synthesis fails
            }
            
        }
    }
}
////////////////////////////////////_-_-_-_-_-_-_-_-_-_  END OF FILE  _-_-_-_-_-_-_-_-_-_////////////////////////////////////