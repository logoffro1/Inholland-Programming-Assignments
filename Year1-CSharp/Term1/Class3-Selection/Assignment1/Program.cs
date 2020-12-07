using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
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
            Console.Write("Enter first number: ");
            int firstNr = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNr = int.Parse(Console.ReadLine());

            int highestNr;
            int lowestNr;

            if (firstNr > secondNr)
            {
                highestNr = firstNr;
                lowestNr = secondNr;
            }
            else
            {
                highestNr = secondNr;
                lowestNr = firstNr;
            }

            Console.WriteLine();
            Console.WriteLine($"Highest value is: {highestNr}");
            Console.WriteLine($"Lowest value is: {lowestNr}");

        }
    }
}
