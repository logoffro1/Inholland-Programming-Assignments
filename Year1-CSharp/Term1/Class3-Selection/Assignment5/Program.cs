using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
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

            if (firstNr % secondNr == 0)
                Console.WriteLine("Number 1 is multiple of number 2");
            else if (secondNr % firstNr == 0)
                Console.WriteLine("Number 2 is multiple of number 1");
            else
                Console.WriteLine("Numbers are not multiples");

        }
    }
}
