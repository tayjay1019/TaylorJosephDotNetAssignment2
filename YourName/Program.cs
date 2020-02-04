using System;

namespace YourName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // display a literal value
            Console.WriteLine("What is your name?");
            // input a value and assign it to a string variable
            string name = Console.ReadLine();
            // display the string variable
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Hello, {0}", name);


            try
            {
                Console.WriteLine("Enter number one:");
                var number1 = Console.ReadLine();
                Console.WriteLine("Enter number two:");
                var number2 = Console.ReadLine();

                var isValid = int.TryParse(number1, out int x);
                int y = int.Parse(number2);
              
                if (isValid)
                {

                }

                var result = x + y;
                Console.WriteLine($"Your answer is: {result}");

            }
            catch (FormatException e)
            {
                Console.WriteLine("I'm afrade I can't let you do that.");
                throw;
            }
            
           
        }
    }
}
