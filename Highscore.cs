using System;
using System.Collections.Generic;

namespace Hangman
{
    public static class Highscore
    {
        public static List<string> top10() {

            Random rnd = new Random();
            
            string line;
            var score = new List<string>();
           
            System.IO.StreamReader file = new System.IO.StreamReader(@"highscores.txt");
                while((line = file.ReadLine()) != null)  
                {  
                  score.Add(line);
                }  

            score.Sort();
            
            return score;
        }
    }
}