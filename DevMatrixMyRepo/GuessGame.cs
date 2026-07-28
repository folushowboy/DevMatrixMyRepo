using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class GuessGame
    {
        public static void GuessNumber()
        {
            Console.WriteLine("Guess a number between 1 and 10");
            int randomNumber = new Random().Next(1, 11);
            Console.WriteLine(randomNumber);
            int maxtries = 3;
            int count = 0;

            while(count < maxtries)
            {
                int guess;
                if(!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Must be numbers.");
                }
                else if(guess < randomNumber)
                {
                    Console.WriteLine("Guess is too low");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Guess is too high");
                }
                else
                {
                    Console.WriteLine("Guess is correct");
                }
                count++;
                Console.WriteLine("Tries = {0}", count);

                if(count == maxtries && guess != randomNumber)
                {
                    Console.WriteLine("Game Over. Random number is {0}", randomNumber);
                }
            }
        }
    }
}
