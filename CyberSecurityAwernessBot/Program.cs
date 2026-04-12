using System;
using CyberSecurityAwarenessBot;

namespace CyberSecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            //set console title
            Console.Title = "Cybersecurity Awareness Bot";

            //play greeting audio and show logo
            AudioPlayer.PlayGreeting();
            ASCIIArt.ShowLogo();

            //ask user for their name and start chatbot
            string name = UserInteraction.AskName();

            //start chatbot with user's name
            ChatBot.Start(name);
        }
    }
}//TEST COMMIT
