using System;

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
            Console.Write("Enter a price: ");

            const double vat = 21.00; //it's a const because it never changes (in our example)
            double price = double.Parse(Console.ReadLine()); //convert the user input into a double
            double priceVat = (vat / 100) * price; //calculate the % 
            double totalPrice = price + priceVat;

            Console.WriteLine($"price: {price.ToString("0.00")}, VAT: {priceVat.ToString("0.00")}, total: {totalPrice.ToString("0.00")}");
        }
    }
}
