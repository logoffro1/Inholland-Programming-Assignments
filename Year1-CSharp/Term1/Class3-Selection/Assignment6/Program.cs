using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
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
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 90)
                Console.WriteLine($"grade: A\ncourse passed");
            else if (score >= 80)
                Console.WriteLine($"grade: B\ncourse passed");
            else if (score >= 70)
                Console.WriteLine($"grade: C\ncourse passed");
            else if (score >= 60)
                Console.WriteLine($"grade: D\ncourse not passed");
            else
                Console.WriteLine($"grade: F\ncourse not passed");

        }
    }
}
