using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
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

            int sum = firstNr + secondNr + thirdNr;
            double average = (double)sum / 3;
            int product = firstNr * secondNr * thirdNr;
            int highest = 0;
            int lowest = 0;

            //highest number
            if (firstNr > secondNr && firstNr > thirdNr)
                highest = firstNr;
            else if (secondNr > firstNr && secondNr > thirdNr)
                highest = secondNr;
            else if (thirdNr > firstNr && thirdNr > secondNr)
                highest = thirdNr;

            //lowest number
            if (firstNr < secondNr && firstNr < thirdNr)
                lowest = firstNr;
            else if (secondNr < firstNr && secondNr < thirdNr)
                lowest = secondNr;
            else if (thirdNr < firstNr && thirdNr < secondNr)
                lowest = thirdNr;

            Console.WriteLine($"sum = {sum}\naverage = {average.ToString("0.00")}\nproduct = {product}\nhighest = {highest}\nlowest = {lowest}");
        }
    }
}
