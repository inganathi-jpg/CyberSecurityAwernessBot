using System;

namespace CyberSecurityAwarenessBot
{
    public class ConsoleUI
    {

        // Method to display a section header in the console
        public static void Section(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n------------ " + title + " ------------");
            Console.ResetColor();
        }
        // Method to display a success message in the console

        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
