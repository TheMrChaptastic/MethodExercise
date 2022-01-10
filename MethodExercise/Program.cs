using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string fColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string fAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string fBand = Console.ReadLine();

            Console.WriteLine($"\n{name} was going to see their favorite band, {fBand}, when they got distracted by an {fColor} {fAnimal}.");

            Console.WriteLine(Add(1, 2, 3, 4, 5));
            Console.WriteLine(Multiply(1, 2, 3, 4, 5));
        }

        public static int Add(params int[] nums)
        {
            int rv = 0;
            foreach(int n in nums)
            {
                rv += n;
            }
            return rv;
        }

        public static int Multiply(params int[] nums)
        {
            int rv = 1;
            foreach (int n in nums)
            {
                rv *= n;
            }
            return rv;
        }
    }
}
