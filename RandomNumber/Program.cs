using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Titke of the cide 
            Console.Title = "Random Number generator";


            // Constants
            const int min = 0;
            const int max = 100;

            //Variables
            int number;

            //Prepare Random Number Generator
            Random random = new Random();

            // Generate a random number
            number = random.Next(min, max + 1);

            // Write the random number 
            Console.WriteLine("Random Number from {0} to {1} is {2}: ", min,max,number);

            // Wait for any key to be pressed 
            number = random.Next(min, max + 1);

            //Press any key to exit
            Console.ReadKey();


        }
    }
}
