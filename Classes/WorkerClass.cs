using PROG6221Part1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PROG6221Part1.Classes
{
    /// <summary>
    /// This class is responsible for processing the user's question and providing a response.
    /// </summary>
    public class WorkerClass
    {
        /// <summary>
        /// Instance of the SpeakerVoice class to handle text-to-speech functionality.
        /// </summary>
        private readonly SpeakerVoice SpeakerVoiceProcesser;

        /// <summary>
        /// Instance of the TextDefinitions class to handle the definitions of keywords.
        /// </summary>
        private readonly TextDefinitions TextDefinitionsProcesser;


        /// <summary>
        /// Default constructor for the WorkerClass that initializes the SpeakerVoice and TextDefinitions instances.
        /// </summary>
        public WorkerClass()
        {
            this.SpeakerVoiceProcesser = new SpeakerVoice();
            this.TextDefinitionsProcesser = new TextDefinitions();
        }

        /// <summary>
        /// This method processes the user's question by checking if it contains any keywords from the TextDefinitions class.
        /// If found it retrieves the definition and speaks it out loud if the speak parameter is true.
        /// If not found, it informs the user that the topic is not available.
        /// </summary>
        public void ProcessingQuestion(string question, bool speak)
        {
            /// <summary>
            /// Converts the question to lowercase to make the keyword search case insensitive.
            ///</summary>
            string lowerQuestion = question.ToLower();

            /// <summary>
            /// Changes the console color to green and displays a message indicating that the question is being processed.
            ///</summary>
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Processing your question:........ \n");
            Console.ResetColor();

            /// <summary>
            /// It searches for keywords in the question that match any of the keywords in the WordsList from the TextDefinitions class.
            ///</summary>
            var KeywordIsMatched = TextDefinitionsProcesser.WordsList
                                    .Where(x => lowerQuestion.Contains(x.ToLower()))
                                    .ToList();

            /// <summary>
            /// If any keywords are found, it displays the definition.
            /// If keywords are not found, it displays a error message.
            ///</summary>
            if (KeywordIsMatched.Count > 0)
            {
                foreach (var key in KeywordIsMatched)
                {
                    /// <summary>
                    /// Retrieves the definition for the keyword from the TextDefinitions class.
                    ///</summary>
                    string response = TextDefinitionsProcesser.GetDefinition(key);

                    /// <summary>
                    /// Changes the color of the console to cyan and displays the keyword and its definition.
                    /// Replaces the "🗣️" emoji with an empty string for cleaner output.
                    ///</summary>
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string CleanResponse = response.Replace("🗣️", ""); // 🗣️ is removed from speech output but shows in the console
                    Console.WriteLine("🗣️ {0}:{1}\n", key, CleanResponse); // display the keyword and its definition
                    Console.ResetColor();

                    /// <summary>
                    /// Will speak the definition if the speak parameter is true.
                    ///</summary>
                    if (speak)
                    {
                        string definition = TextDefinitionsProcesser.GetSpeechFriendlyText(response);
                        SpeakerVoiceProcesser.Speak(definition);
                    }
                }
            }
            else 
            { 
                /// <summary>
                /// Will display an error message if no keywords are found.
                ///</summary>
                string errorMessage = "Sorry, I don't have information on that topic.";

                /// <summary>
                /// Will change the color of the console to red and display the error message.
                ///</summary>
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ " + errorMessage + "\n");
                Console.ResetColor();

                /// <summary>
                /// Will speak the error message if the speak parameter is true.
                ///</summary>
                if(speak)
                {
                    SpeakerVoiceProcesser.Speak(errorMessage);
                }
            }
        }

    }
}
////////////////////////////////////_-_-_-_-_-_-_-_-_-_  END OF FILE  _-_-_-_-_-_-_-_-_-_////////////////////////////////////