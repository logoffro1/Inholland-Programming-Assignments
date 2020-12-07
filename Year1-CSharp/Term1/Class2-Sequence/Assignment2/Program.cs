using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }
        void Start()
        {
            const int nrToInput = 3;
            int sum = 0;

            for (int i = 0; i < nrToInput; i++) //I loop for how many numbers I want
            {
                Console.Write($"Enter number {i + 1}: ");
                sum += int.Parse(Console.ReadLine()); // I add to the sum the input from the user
            }

            double average = (double)sum / nrToInput; // I divide the sum by how many numbers
            Console.WriteLine($"\nThe average is: {average}");
        }
    }
}
