using System;

namespace CyberSecurityAwarenessBot
{
    public class ChatBot
    {
        public static void Start(string userName)
        {
            // Main chatbot loop
            while (true)
            {
                // Display user prompt
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(userName + ": ");
                Console.ResetColor();

                // Read user input
                string input = Console.ReadLine().ToLower();

                // Validate input
                if (string.IsNullOrWhiteSpace(input))
                {
                    ConsoleUI.Error("Please enter a valid question.");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online.");
                    break;
                }

                // GENERAL
                if (input.Contains("how are you"))
                {
                    ConsoleUI.Section("GENERAL");
                    Console.WriteLine("Bot: I am functioning well and ready to help.");
                }
                else if (input.Contains("purpose"))
                {
                    ConsoleUI.Section("GENERAL");
                    Console.WriteLine("Bot: My purpose is to educate users about cybersecurity.");
                }

                // CYBERSECURITY
                else if (input.Contains("cybersecurity"))
                {
                    ConsoleUI.Section("CYBERSECURITY");
                    Console.WriteLine("Cybersecurity protects systems and data from attacks.");
                    Console.WriteLine("Solution: Use antivirus and keep systems updated.");
                }

                // PHISHING
                else if (input.Contains("phishing"))
                {
                    ConsoleUI.Section("PHISHING");
                    Console.WriteLine("Phishing is a scam to steal personal information.");
                    Console.WriteLine("Prevention: Do not click unknown links.");
                }

                // PASSWORD
                else if (input.Contains("password"))
                {
                    ConsoleUI.Section("PASSWORD SAFETY");
                    Console.WriteLine("Use strong passwords with symbols and numbers.");
                    Console.WriteLine("Solution: Use different passwords for each account.");
                }

                // SAFE BROWSING
                else if (input.Contains("safe browsing") || input.Contains("safe"))
                {
                    ConsoleUI.Section("SAFE BROWSING");
                    Console.WriteLine("Safe browsing avoids harmful websites.");
                    Console.WriteLine("Solution: Check HTTPS and avoid public WiFi.");
                }

                else
                {
                    ConsoleUI.Error("I didn't understand that. Try asking about cybersecurity.");
                }
            }
        }
    }
}
