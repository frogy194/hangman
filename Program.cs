using System;
using System.IO;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
  
         string fileName = @"highscores.txt";

        string again = "no";
        

        do {

            try
            {
                string toAdd = Game.newGame(5);
            
            
                using (StreamWriter fileStr = File.CreateText(fileName)) 
                {
                    fileStr.WriteLine(toAdd);
                
                }	            			
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }

            Console.WriteLine("You want to play again ?");
            again = Console.ReadLine();
            
                            
        }

        while (again.ToUpper() == "YES");

        
        
            


        }
    }
}
