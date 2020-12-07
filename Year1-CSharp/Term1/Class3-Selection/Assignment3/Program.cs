using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
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

            Console.Write("Enter third number: ");
            int thirdNr = int.Parse(Console.ReadLine());

            if(firstNr > thirdNr && secondNr  > thirdNr)
                Console.WriteLine("The third numbere is the smallest of the tree");
            else
                Console.WriteLine("The third number is not the smallest of the tree");
        }
    }
}
