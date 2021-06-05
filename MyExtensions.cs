using System;
using System.Collections.Generic;

namespace Extension_Method
{
    public static class MyExtensions
    {
        // I created ChooseMyMood extension to return a mood for me
        public static mood ChooseMyMood(this string mood){
            
            Random rasgele = new Random();
            int sayi = rasgele.Next(1,12);

            return (mood) sayi;
        }

        // I created MotivateMe extension to return a motivational sentence pharese for me
        public static string MotivateMe(this string motivate){
            
            List<String> motivateWords = new List<String>();
            
            string motivateWord1 = " \"He who is not courageous enough to take risks will accomplish nothing in life.\" Muhammad Ali";
            string motivateWord2 = " \"Knowing is not enough; we must apply. Willing is not enough; we must do.\"—Johann Wolfgang von Goethe";
            string motivateWord3 = " \"The path to success is to take massive, determined actions.\"—Tony Robbins";
            string motivateWord4 = " \"Without self-confidence, we are as babes in the cradle.\"—Virginia Woolf";
            string motivateWord5 = " \"Excellence is not a skill, it's an attitude.\"—Ralph Marston";

            motivateWords.Add(motivateWord1);
            motivateWords.Add(motivateWord2);
            motivateWords.Add(motivateWord3);
            motivateWords.Add(motivateWord4);
            motivateWords.Add(motivateWord5);
            
            Random rasgele = new Random();
            int sayi = rasgele.Next(1,5);

            return motivateWords[sayi];
        }

    }
}