using System;

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
            Console.Write("Enter number of seconds: ");
            int seconds = int.Parse(Console.ReadLine());


            /*
             *  determine the number of hours and subtract this from the number of seconds, then
             *  determine the number of minutes and subtract this from the number of seconds.
             */
            int hours = seconds / 3600;
            seconds -= hours * 3600;

            int minutes = seconds / 60;
            seconds -= minutes * 60;

            Console.WriteLine($"{hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}");
        
        }
    }
}
