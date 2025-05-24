using PROG6221Part1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PROG6221Part1.Classes
{
    public class MainWorker
    {
        /// <summary>
        /// Default constructor for the MainWorker class
        /// </summary>
        public MainWorker()
        {

        }
        public void Run()
        {
            // Set the console encoding to UTF-8 to support special characters
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            /// <summary>
            /// Create an instance of the Sounds class to handle sound
            ///</summary>
            Sounds Soundplayer = new Sounds();

            /// <summary>
            /// Title of the console window
            ///</summary>
            Console.Title = "CyberBot";

            Soundplayer.PlayGreetingSound(); // Play the greeting sound

            // Display the chatbot's welcome banner with colored formatting
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                                            ║");
            Console.WriteLine("║                        Welcome to CyberBot                                 ║");
            Console.WriteLine("║                                                                            ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("       _______");
            Console.WriteLine("      /       \\");
            Console.WriteLine("     |  @   @  |        <<< CyberBot");
            Console.WriteLine("     |   \\_/   |        Defender of Your Data 🔐");
            Console.WriteLine("     |  \\___/  |");
            Console.WriteLine("      \\_______/");
            Console.WriteLine("      /|     |\\");
            Console.WriteLine("     /_|_____|_\\        🛡️ Activating Threat Detection");
            Console.WriteLine("    |           |");
            Console.WriteLine("    |  [_____]  |         - Educating Users...");
            Console.WriteLine("    |  ||   ||  |         - Blocking Threats & Phishing");
            Console.WriteLine("    '-----------'");
            Console.ResetColor();

            /// <summary>
            /// Creates an instance of the WorkerClass to handle user input and responses
            ///</summary>
            WorkerClass chatbot = new WorkerClass();

            /// <summary>
            /// While loop to continuously prompt the user for input until they choose to exit
            ///</summary>
            while (true)
            {
                //Asks the user to enter a cybersecurity related word
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║ 🔍 Enter a cybersecurity related word (or type 'exit' to quit):            ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
                Console.ResetColor();

                // Change input text color to dark blue for readability
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                string userInput = Console.ReadLine();
                Console.ResetColor(); // Reset color immediately after user input

                // Ensure the input is not empty or just whitespace
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║ ⚠️ Please enter a valid word.                                              ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
                    Console.ResetColor();
                    continue; // Restart loop to prompt for a valid input
                }

                // Check if the user wants to exit the chatbot
                if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Soundplayer.PlayByeSound(); // Play the goodbye sound


                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("       _______");
                    Console.WriteLine("      /       \\");
                    Console.WriteLine("     |  @   @  |        <<< ✅ Thank you for using CyberBot.");
                    Console.WriteLine("     |   \\_/   |  ");
                    Console.WriteLine("     |  \\___/  |");
                    Console.WriteLine("      \\_______/");
                    Console.WriteLine("      /|     |\\");
                    Console.WriteLine("     /_|_____|_\\ ");
                    Console.WriteLine("    |           |");
                    Console.WriteLine("    |  [_____]  | ");
                    Console.WriteLine("    |  ||   ||  | ");
                    Console.WriteLine("    '-----------'");
                    Console.ResetColor();

                    Thread.Sleep(5000); // Pause for 5 seconds before exiting

                    break; // Exit the loop and terminate the program
                }

                ///<summary>
                /// Process the user's input and provide a response
                ///</summary>
                chatbot.ProcessingQuestion(userInput, true);
            }

        }
    }
}
////////////////////////////////////_-_-_-_-_-_-_-_-_-_  END OF FILE  _-_-_-_-_-_-_-_-_-_////////////////////////////////////