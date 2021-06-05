using System;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // I created this code to see the result of my extensions.
            Console.WriteLine(" **** What is your mood? **** ");
            Console.WriteLine();
            string mood = " ";
            Console.WriteLine("Your mood is : "  +  mood.ChooseMyMood());
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine(" **** I need to be motivated. Please motivate me! ****");
            Console.WriteLine();
            
            string motivateWord = "";
            Console.WriteLine("I want to say you this motive sentence : ");
            Console.WriteLine("   " + motivateWord.MotivateMe());
        }
    }
}
