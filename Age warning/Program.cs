using System;

namespace Age_warning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            byte age = Byte.Parse(Console.ReadLine());

            if (age < 17)
            {
                Console.WriteLine("Recommended age is 17!");
               
            }
            Console.WriteLine("Enjoy your game");
            Console.ReadKey();
            
        }
    }
}
