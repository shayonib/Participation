using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, pick heads or tails >>");
            string.usersGuessAsString = Console.ReadLine();
            int usersGuess;

            if (usersGuess == "heads") ;
            {
                usersGuess = 0;
            }
           else
            {
                usersGuess = 1;
            }

            Random rand = new Random();
            int randomNumber = rand.Next(0, 2);

            if (randomNumber = 0) ;
            {
                Console.WriteLine("The coin landed on heads");
            }
            if else (randomNumber = 1);
            {
                Console.WriteLine("The coin landed on tails");
            }



            Console.ReadKey();
        }
    }
}
