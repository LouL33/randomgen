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

            Console.WriteLine("Pick a number pls?");
            var useGuess = Console.ReadLine();

        }
    }
}
