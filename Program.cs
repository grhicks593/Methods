using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first and last name: ");

            
            string input = Console.ReadLine();

            Console.WriteLine("\n");

            Print_Name(input);
        } 

        
        private static void Print_Name(string input)
        {
            Console.WriteLine("Hello " + input + "!");
        }
    }
}
