using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomgen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 100);
            Console.WriteLine(randomNumber);
            bool jackTheNumber = false;
            int theNewGuess = 0;

            Console.WriteLine("Pick a number pls?");
            var userGuess = Console.ReadLine();
            
            int.TryParse(userGuess, out theNewGuess);

            var countOfGuesses = 0;
            while (theNewGuess != randomNumber && countOfGuesses <= 4)
            {
                if (theNewGuess < randomNumber)
                {
                    countOfGuesses++;
                    Console.WriteLine($"try guessing again fool its to low {theNewGuess}");
                    jackTheNumber = int.TryParse(Console.ReadLine(), out theNewGuess);

                }
                else if (theNewGuess > randomNumber)
                {
                    countOfGuesses++;
                    Console.WriteLine($"try again yo its to high {theNewGuess}");
                    jackTheNumber = int.TryParse(Console.ReadLine(), out theNewGuess);
                }

                
            }
            if (theNewGuess == randomNumber)
            {
                Console.WriteLine($"YES!!!! you have done it {theNewGuess}");
            }

            if (theNewGuess != randomNumber)
            {
                Console.WriteLine($"DANG BRO!!!! you lose {theNewGuess}");
            }

            {
                //       theNewGuess++;
                //     Console.WriteLine("try guessing again dog");
                //   jackTheNumber = int.TryParse(Console.ReadLine(), out theNewGuess);

            }
        }
    }
}
