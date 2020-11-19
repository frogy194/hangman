using System;

namespace Hangman
{
    public static class Game
    {
        public static string newGame(int lifes)
        {


        Outer:

            string[] capitals = { "Amsterdam", "Andorra la Vella", "Ankara", "Astana", "Athens", "Baku", "Belgrade", "Berlin", "Bern", "Bratislava", "Brussels", "Bucharest", "Budapest", "Chisinau", "Copenhagen", "Dublin", "Helsinki", "Kiev", "Lisbon", "Ljubljana", "London", "Luxembourg", "Madrid", "Minsk", "Monaco", "Moscow", "Nicosia", "Oslo", "Paris", "Podgorica", "Prague", "Reykjavík", "Riga", "Rome", "San Marino", "Sarajevo", "Skopje", "Sofia", "Stockholm", "Tallinn", "Tbilisi", "Tirana", "Vaduz", "Valletta", "Vatican City", "Vienna", "Vilnius", "Warsaw", "Yerevan", "Zagreb", };
            Random rnd = new Random();
            string cityToGuess = capitals.GetValue(rnd.Next(0, capitals.Length)).ToString().ToUpper();
            string lettersNotInWord = " ";
            string guessWord;
            char guessChar;
            bool[] hit = new bool[cityToGuess.Length];
            int gameEnd = 0;
            int guessingTries = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();


            do
            {

                for (int i = 0; i < cityToGuess.Length; i++)
                {

                    if (hit[i] == true)
                    {

                        Console.Write(cityToGuess[i]);
                    }

                    else
                    {

                        Console.Write(" _ ");
                    }
                }



                for (int i = 0; i < cityToGuess.Length; i++)
                {


                    if (hit[i] == false)
                    {

                        gameEnd = 0;
                        break;
                    }

                    else
                    {

                        gameEnd = 1;

                    }
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Letters not in word : " + lettersNotInWord);
                Console.WriteLine();
                Console.WriteLine("You want to guess character or whole word ? (Type WORD or CHAR)    Lifes left :" + lifes);
                // Console.WriteLine(cityToGuess);
                guessWord = Console.ReadLine();


                if (string.Equals(guessWord.ToUpper(), "WORD"))
                {

                    Console.WriteLine("Type word");
                    guessWord = Console.ReadLine();

                    if (string.Equals(guessWord.ToUpper(), cityToGuess.ToUpper()))
                    {
                        guessingTries++;
                        gameEnd = 1;
                    }

                    else
                    {
                        guessingTries++;
                        lifes = lifes - 2;
                    }
                }

                else if (string.Equals(guessWord.ToUpper(), "CHAR"))
                {

                    Console.WriteLine("Type character");
                    guessChar = Console.ReadLine()[0];
                    int lifeCheck = 0;

                    for (int i = 0; i < cityToGuess.Length; i++)
                    {

                        if (char.Equals(Char.ToUpper(guessChar), cityToGuess[i]))
                        {

                            hit[i] = true;
                            lifeCheck = 1;
                        }
                    }

                    if (lifeCheck == 0)
                    {
                        lifes = lifes - 1;
                        lettersNotInWord = lettersNotInWord + " " + Char.ToString(guessChar);

                    }
                    guessingTries++;

                }

                else
                {

                    Console.WriteLine("I dont understand you");
                }



            }

            while (gameEnd == 0 && lifes > 0);

            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            
            
            if (lifes == 0)
            {

                Console.WriteLine("You lost, word you were looking for was " + cityToGuess);
            }

            else
            {

                Console.WriteLine("You won, word you were looking for was " + cityToGuess);
            }

            Console.WriteLine("What's your name");
            string results = Console.ReadLine() + " " + DateTime.Now.ToString("MMM d ddd h:mm:ss tt") + " " + elapsedTime + " " + lifes + " lifes left";
            Console.WriteLine("Thanks for playing");

            return results;
        }

    }
}