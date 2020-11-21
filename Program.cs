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
            
                // }	  
                if (!(toAdd == null)) {
                    using (FileStream fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fileStream))
                    {
                    sw.WriteLine(toAdd);
                    } 
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

        
        for (int i = 0; i < 9; i++) {

            Console.WriteLine(Highscore.top10()[i]);
        }

         Console.ReadLine();   


        }
    }
}
