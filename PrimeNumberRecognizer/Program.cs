using System;

namespace PrimeNumberRecognizer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            bool decision = false;
            string key;

            Console.WriteLine("Hello! type your number and check if it is prime");
            while (!quit)
            { 
                int value = int.Parse(Console.ReadLine());

                if (PrimeNumberRecognizer.IsPrime(value))
                    Console.WriteLine("Number is prime");
                else
                    Console.WriteLine("Number is not prime");
            
                while (!decision)
                {
                    Console.WriteLine("Want to try again? y/n");
                    key = Console.ReadLine();
                    if (key == "n")
                        quit = decision = true;
                    else if (key == "y")
                    {
                        decision = true;
                    }
                    else
                        Console.WriteLine("Wrong command!");
                }
                decision = false;
            }

            // prime number generator
            /*
            int a = 2;
            Console.WriteLine("List of prime numbers");
            while (true)
            {
                if (PrimeNumberRecognizer.IsPrime(a))
                    Console.WriteLine(a);
                a++;
            }
            */
        }
    }
}
