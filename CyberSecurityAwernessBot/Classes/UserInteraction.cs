using System;

namespace CyberSecurityAwarenessBot
{
    public class UserInteraction
    {
        public static string AskName()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Validate that the name is not empty or whitespace
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Please enter a valid name: ");
                name = Console.ReadLine();
            }

            // Greet the user and provide instructions
            Console.WriteLine($"\nWelcome, {name}!");
            Console.WriteLine("Ask me anything about cybersecurity.\n");

            return name;
        }
    }
}
