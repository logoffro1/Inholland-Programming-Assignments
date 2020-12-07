using System;
using System.IO;
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
            string userName = ReadString("Enter your name: ");
            string filename = userName + ".txt";
            if (!File.Exists(filename))
            {
                Console.WriteLine($"Welcome, {userName}");
                WritePerson(ReadPerson(), filename);
            }
            else
            {
                Console.WriteLine($"Nice to see you again, {userName}");
                DisplayPerson(ReadPerson(filename));
            }
        }
        private Person ReadPerson()
        {
            Person person = new Person();
            person.Name = ReadString("Enter your name: ");
            person.City = ReadString("Enter your city: ");
            person.Age = ReadInt("Enter your age: ");

            return person;
        }
        private Person ReadPerson(string filename)
        {
            Person person = new Person();
            using (StreamReader sr = new StreamReader(filename))
            {
                person.Name = sr.ReadLine();
                person.City = sr.ReadLine();
                person.Age = int.Parse(sr.ReadLine());
            }

            return person;
        }
        void DisplayPerson(Person p)
        {
            Console.WriteLine("We have the following information about you:");
            Console.WriteLine($"Name      : {p.Name}\nCity      : {p.City}\nAge       : {p.Age}");
        }
        private void WritePerson(Person p, string filename)
        {
            using (StreamWriter sr = new StreamWriter(filename))
            {
                sr.WriteLine(p.Name);
                sr.WriteLine(p.City);
                sr.WriteLine(p.Age);
            }
            Console.WriteLine("Your data is written to the file.");
        }
        private string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
        private int ReadInt(string question)
        {
            Console.Write(question);
            return int.Parse(Console.ReadLine());
        }

    }
}
