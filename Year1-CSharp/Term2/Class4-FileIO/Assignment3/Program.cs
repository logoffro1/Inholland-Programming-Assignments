using System;
using System.IO;

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
            string filename = "tweets.txt";
            Console.Write("Enter a word (to search): ");
            string word = Console.ReadLine();
            int lines= SearchWordInFile(filename, word);

        }
        private int SearchWordInFile(string filename, string word)
        {
            int count = 0;
            if (File.Exists(filename))
            {
                using(StreamReader sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (WordInLine(line.ToLower(), word.ToLower()))
                        {
                            DisplayWordInLine(line, word);
                            count++;
                        }
                    }
                }
            }

            return count;
           
        }
        private bool WordInLine(string line, string word)
        {
            return line.Contains(word);
        }
        private void DisplayWordInLine(string line, string word)
        {
            int wordIndex = line.ToLower().IndexOf(word.ToLower());
            for (int i = 0; i < line.Length; i++)
            {
                if (i == wordIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[");
                }
                else if (i == wordIndex + word.Length)
                {
                    Console.Write("]");
                    Console.ResetColor();
                }
                Console.Write(line[i]);
            }
            Console.WriteLine();
        }
    }
}
