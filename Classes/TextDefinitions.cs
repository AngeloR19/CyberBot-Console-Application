using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PROG6221Part1.Classes
{
    public class TextDefinitions
    {
        /// <summary>
        /// Creates a dictionary that has a string as the key and a string as the value.
        /// The StringComparer.OrdinalIgnoreCase make the dictionary case insensitive.
        /// A lsit of string is also created to hold the keys from the dictionary and made it to readonly meaning it cannot be modified.
        /// </summary>
        private readonly Dictionary<string, string> CyberWordsDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public List<string> WordsList { get; } = new List<string>();

        /// <summary>
        /// Default constructor for the TextDefinitions class that initializes the dictionary and loads the words.
        /// </summary>
        public TextDefinitions()
        {
            LoadWords();
        }

        /// <summary>
        /// Populates the dictionary with words and their definitions.
        /// </summary>
        private void LoadWords()
        {
            try
            {
                CyberWordsDictionary.Add("Malware",
                    "🗣️ Malicious code that sneaks into systems to damage, disrupt, or steal data.\n\n" +
                    "📌 Example: A user downloads a fake PDF viewer that installs spyware.\n\n" +
                    "🛡️ Remediation: Use reliable antivirus software and don’t download files from suspicious sources.");

                CyberWordsDictionary.Add("Firewall",
                    "🗣️ A digital barrier that filters traffic between a trusted network and outsiders.\n\n" +
                    "📌 Example: A home router uses a firewall to block unapproved internet access.\n\n" +
                    "🛡️ Remediation: Keep firewall settings active and regularly review security rules.");

                CyberWordsDictionary.Add("Phishing",
                    "🗣️ A scam that tricks people into giving away sensitive data by pretending to be legitimate.\n\n" +
                    "📌 Example: You get an email that looks like it's from your bank, asking for your PIN.\n\n" +
                    "🛡️ Remediation: Double-check sender info and never click on strange email links.");

                CyberWordsDictionary.Add("Ransomware",
                    "🗣️ A digital hostage-taker that encrypts files and demands money to unlock them.\n\n" +
                    "📌 Example: Your personal photos become inaccessible unless you pay in cryptocurrency.\n\n" +
                    "🛡️ Remediation: Keep offline backups and avoid clicking unknown links.");

                CyberWordsDictionary.Add("Trojan",
                    "🗣️ Malware disguised as safe software to trick users into installing it.\n\n" +
                    "📌 Example: A 'free game' installs a keylogger in the background.\n\n" +
                    "🛡️ Remediation: Only download software from official or verified sources.");

                CyberWordsDictionary.Add("SQL Injection",
                    "🗣️ An attack where hackers insert malicious code into database queries.\n\n" +
                    "📌 Example: Typing `' OR '1'='1` into a login form to bypass login checks.\n\n" +
                    "🛡️ Remediation: Always validate inputs and use parameterized SQL statements.");

                CyberWordsDictionary.Add("Rootkit",
                    "🗣️ A sneaky piece of software that hides deep in the system to avoid detection.\n\n" +
                    "📌 Example: A hacker installs a rootkit to secretly monitor system activity.\n\n" +
                    "🛡️ Remediation: Use specialized scanners and perform integrity checks.");

                CyberWordsDictionary.Add("Adware",
                    "🗣️ Software that floods your device with unwanted ads.\n\n" +
                    "📌 Example: Free apps that open pop-ups or browser redirects without permission.\n\n" +
                    "🛡️ Remediation: Run adware cleaners and be cautious with free software.");

                CyberWordsDictionary.Add("Botnet",
                    "🗣️ A network of hijacked computers under a hacker’s control.\n\n" +
                    "📌 Example: Infected smart fridges used to launch DDoS attacks.\n\n" +
                    "🛡️ Remediation: Secure all devices with strong credentials and updates.");

                CyberWordsDictionary.Add("Whaling",
                    "🗣️ A phishing attack that targets high-level individuals like CEOs.\n\n" +
                    "📌 Example: A fake email tricks a CFO into transferring company funds.\n\n" +
                    "🛡️ Remediation: Train executives to spot fraud and enforce verification steps.");

                CyberWordsDictionary.Add("Backdoor",
                    "🗣️ A hidden way into a system that bypasses normal login processes.\n\n" +
                    "📌 Example: An attacker installs a backdoor to re-enter after breaching a server.\n\n" +
                    "🛡️ Remediation: Monitor systems for unusual behavior and remove unverified software.");

                CyberWordsDictionary.Add("Logic Bomb",
                    "🗣️ Code that activates under specific conditions to cause harm.\n\n" +
                    "📌 Example: A script that deletes files on a set date if an employee is terminated.\n\n" +
                    "🛡️ Remediation: Conduct regular audits and monitor file changes.");

                CyberWordsDictionary.Add("Inside Threat",
                    "🗣️ A security risk coming from someone within the organization.\n\n" +
                    "📌 Example: A disgruntled employee leaking data to a competitor.\n\n" +
                    "🛡️ Remediation: Enforce role-based access and track user activities.");

                CyberWordsDictionary.Add("DNS Spoofing",
                    "🗣️ Redirecting a user to a fake website by corrupting DNS data.\n\n" +
                    "📌 Example: You think you’re visiting your bank, but it’s a phishing site.\n\n" +
                    "🛡️ Remediation: Use secure DNS services and check site certificates.");

                CyberWordsDictionary.Add("Eavesdropping",
                    "🗣️ Intercepting private digital conversations or data.\n\n" +
                    "📌 Example: A hacker captures unencrypted Wi-Fi traffic to read emails.\n\n" +
                    "🛡️ Remediation: Encrypt your connections and avoid public Wi-Fi without a VPN.");

                CyberWordsDictionary.Add("Zero-Day Exploit",
                    "🗣️ An attack that takes advantage of a flaw before it’s patched.\n\n" +
                    "📌 Example: Malware uses a new browser bug before an update is released.\n\n" +
                    "🛡️ Remediation: Enable automatic updates and use behavior-based antivirus tools.");

                CyberWordsDictionary.Add("Man-In-The-Middle",
                    "🗣️ A silent interceptor that listens or alters data between two parties.\n\n" +
                    "📌 Example: Someone intercepts your login info over unsecure Wi-Fi.\n\n" +
                    "🛡️ Remediation: Use HTTPS, VPNs, and avoid sensitive transactions on public networks.");

                WordsList.AddRange(CyberWordsDictionary.Keys); // Add all keys to the list
            }

            catch (Exception ex)
            {
                Console.WriteLine("⚠️Error: " + ex.Message); // Display error message if dictionary loading fails
            }
        }

        /// <summary>
        /// This method checks if the keywird exists in the dictionary.
        /// If not found, it returns a message indicating that the keyword was not found.
        /// </summary>
        public string GetDefinition(string keyword)
        {
            return CyberWordsDictionary.TryGetValue(keyword, out string definition)
                ? definition
                : "⚠️ Sorry, I don't have information on that topic.";
        }

        /// <summary>
        /// This method formats the text to be more speech friendly.
        /// </summary>
        public string GetSpeechFriendlyText(string input)
        {
            return input
                  .Replace("🗣️", "")  // 🗣️ is removed from speech output but shows in the console
                  .Replace("⚠️", "")  // ⚠️ is removed from speech output but shows in the console
                  .Replace("(Speaking):", "")  // Removes"(Speaking):"
                  .Replace("📌 Example:", "Example:") // 📌 is removed from speech output but shows in the console
                  .Replace("🛡️ Remediation:", "Remediation:") // 🛡️ is removed from speech output but shows in the console
                  .Trim();
        }
    }  
}
////////////////////////////////////_-_-_-_-_-_-_-_-_-_  END OF FILE  _-_-_-_-_-_-_-_-_-_////////////////////////////////////