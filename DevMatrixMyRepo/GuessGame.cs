using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMatrixMyRepo
{
    public class GuessGame
    {
        public static void GuessGameApp()
        {
            int randomNumber = new Random().Next(1, 11);
            Console.WriteLine($"The random number is {randomNumber}");

            int maxAttempts = 3;
            int count = 0;
            //int myGuess;

            while (count < maxAttempts)
            {
                if (!int.TryParse(Console.ReadLine(), out int myGuess))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 10");
                    continue;
                }else if (myGuess > 10)
                {
                    Console.WriteLine("This number is not between 1 and 10. Please enter a number between 1 and 10");
                    continue;
                }

                if (myGuess == randomNumber)
                {
                    Console.WriteLine("Congratulations. Your guess is correct");
                    break;
                }
                else if (myGuess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again!");
                }
                else
                {
                    Console.WriteLine("Your guess is too high. Try again!");
                }
                count++;
                Console.WriteLine($"You have made {count} attempts.");
                if (maxAttempts == count && myGuess != randomNumber)
                {
                    Console.WriteLine("Game Over! You've used all your attempts. The correct number was {0}.", randomNumber);
                }
            }


        }
    }
}
