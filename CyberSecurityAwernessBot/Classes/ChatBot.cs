using System;
using System.Collections.Generic;

namespace CyberSecurityAwarenessBot
{
    public class ChatBot
    {
        // Entry method to start chatbot interaction
        public static void Start(string userName)
        {
            // Infinite loop keeps chatbot running until user exits
            while (true)
            {
                ShowMenu();

                // Prompt user for menu selection
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nSelect an option (1-5) or type 'exit': ");
                Console.ResetColor();

                // Read user input safely (avoid null errors)
                string choice = (Console.ReadLine() ?? "").ToLower();

                // Exit condition
                if (choice == "exit")
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online.");
                    break;
                }

                // Handle selected menu option
                HandleMenu(choice);
            }
        }

        // Displays the main chatbot menu
        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n========== CYBERSECURITY MENU ==========");
            Console.ResetColor();

            Console.WriteLine("1. General Questions");
            Console.WriteLine("2. Phishing");
            Console.WriteLine("3. Password Safety");
            Console.WriteLine("4. Safe Browsing");
            Console.WriteLine("5. Cybersecurity Basics");
        }

        // Routes user choice to the correct topic
        static void HandleMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    ShowQuestions("General", GeneralQuestions());
                    break;
                case "2":
                    ShowQuestions("Phishing", PhishingQuestions());
                    break;
                case "3":
                    ShowQuestions("Password", PasswordQuestions());
                    break;
                case "4":
                    ShowQuestions("Browsing", BrowsingQuestions());
                    break;
                case "5":
                    ShowQuestions("Cybersecurity", CyberQuestions());
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }

        // Displays questions for a selected topic
        static void ShowQuestions(string topic, Dictionary<int, string> questions)
        {
            Console.WriteLine($"\n--- {topic} Questions ---");

            // Loop through dictionary and display numbered questions
            foreach (var q in questions)
            {
                Console.WriteLine($"{q.Key}. {q.Value}");
            }

            Console.Write("\nChoose a question number: ");
            int num;

            // Validate numeric input and check if question exists
            if (int.TryParse(Console.ReadLine(), out num) && questions.ContainsKey(num))
            {
                ShowAnswer(topic, num);
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
        }

        // Displays answer + solution based on topic and question number
        static void ShowAnswer(string topic, int num)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAnswer:");
            Console.ResetColor();

            // GENERAL QUESTIONS
            if (topic == "General")
            {
                if (num == 1) Console.WriteLine("I am functioning well and ready to assist.");
                else if (num == 2) Console.WriteLine("My purpose is to educate users about cybersecurity.");
                else if (num == 3) Console.WriteLine("You can ask about phishing, passwords, browsing, and more.");
                else if (num == 4) Console.WriteLine("I help improve your online safety awareness.");
                else if (num == 5) Console.WriteLine("Cyber threats are increasing globally, so awareness is important.");
            }

            // PHISHING QUESTIONS 
            else if (topic == "Phishing")
            {
                if (num == 1) Console.WriteLine("Phishing is a scam to steal sensitive data.\nSolution: Avoid clicking unknown links.");
                else if (num == 2) Console.WriteLine("Phishing emails look real but are fake.\nSolution: Check sender carefully.");
                else if (num == 3) Console.WriteLine("Links may redirect to fake sites.\nSolution: Hover before clicking.");
                else if (num == 4) Console.WriteLine("Attackers pretend to be trusted companies.\nSolution: Verify sources.");
                else if (num == 5) Console.WriteLine("Urgent messages are common in phishing.\nSolution: Don't rush decisions.");
            }

            // PASSWORD SAFETY QUESTIONS
            else if (topic == "Password")
            {
                if (num == 1) Console.WriteLine("Strong passwords use letters, numbers, symbols.\nSolution: Use 12+ characters.");
                else if (num == 2) Console.WriteLine("Avoid using personal info.\nSolution: Use random combinations.");
                else if (num == 3) Console.WriteLine("Never reuse passwords.\nSolution: Use different passwords per account.");
                else if (num == 4) Console.WriteLine("Password managers help store passwords.\nSolution: Use trusted tools.");
                else if (num == 5) Console.WriteLine("Change passwords regularly.\nSolution: Update every few months.");
            }

            // SAFE BROWSING QUESTIONS 
            else if (topic == "Browsing")
            {
                if (num == 1) Console.WriteLine("Safe browsing protects you from harmful sites.\nSolution: Use HTTPS.");
                else if (num == 2) Console.WriteLine("Avoid downloading unknown files.\nSolution: Use trusted sources.");
                else if (num == 3) Console.WriteLine("Pop-ups may contain malware.\nSolution: Block pop-ups.");
                else if (num == 4) Console.WriteLine("Public WiFi is risky.\nSolution: Use VPN.");
                else if (num == 5) Console.WriteLine("Keep browser updated.\nSolution: Enable auto updates.");
            }

            // CYBERSECURITY BASICS 
            else if (topic == "Cybersecurity")
            {
                if (num == 1) Console.WriteLine("Cybersecurity protects systems and data.\nSolution: Use antivirus.");
                else if (num == 2) Console.WriteLine("It prevents hacking and data theft.\nSolution: Secure your devices.");
                else if (num == 3) Console.WriteLine("Cyber attacks are increasing.\nSolution: Stay informed.");
                else if (num == 4) Console.WriteLine("Everyone is a target.\nSolution: Practice safe habits.");
                else if (num == 5) Console.WriteLine("Security awareness reduces risk.\nSolution: Learn continuously.");
            }
        }

        // ================= QUESTION LISTS =================

        // General chatbot questions
        static Dictionary<int, string> GeneralQuestions() => new()
        {
            {1, "How are you?"},
            {2, "What is your purpose?"},
            {3, "What can I ask you?"},
            {4, "How do you help users?"},
            {5, "Why is cybersecurity important?"}
        };

        // Phishing-related questions
        static Dictionary<int, string> PhishingQuestions() => new()
        {
            {1, "What is phishing?"},
            {2, "How do phishing emails work?"},
            {3, "Are phishing links dangerous?"},
            {4, "How do attackers trick users?"},
            {5, "Why do phishing attacks feel urgent?"}
        };

        // Password safety questions
        static Dictionary<int, string> PasswordQuestions() => new()
        {
            {1, "What is a strong password?"},
            {2, "Why avoid personal info in passwords?"},
            {3, "Can I reuse passwords?"},
            {4, "What is a password manager?"},
            {5, "How often should I change passwords?"}
        };

        // Safe browsing questions
        static Dictionary<int, string> BrowsingQuestions() => new()
        {
            {1, "What is safe browsing?"},
            {2, "Is downloading risky?"},
            {3, "Are pop-ups dangerous?"},
            {4, "Is public WiFi safe?"},
            {5, "Why update browsers?"}
        };

        // Cybersecurity basics questions
        static Dictionary<int, string> CyberQuestions() => new()
        {
            {1, "What is cybersecurity?"},
            {2, "Why is cybersecurity important?"},
            {3, "Are cyber attacks increasing?"},
            {4, "Who is at risk?"},
            {5, "How can I stay safe?"}
        };
    }
}

