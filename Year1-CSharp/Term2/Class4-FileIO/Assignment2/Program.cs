using System;
using System.Collections.Generic;
using System.IO;

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
            HangmanGame hangman = new HangmanGame();

            List<string> words = ListOfWords("words.txt");
            string selectedWord = SelectWord(words);

            hangman.Init(selectedWord);
            bool guessed = PlayHangman(hangman);

            if (guessed)
                Console.WriteLine("You guessed the word!");
            else
                Console.WriteLine($"Too bad, you did not guess the word ({hangman.secretWord})");

        }
        private List<string> ListOfWords(string filename)
        {
            List<string> words = new List<string>();
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    while (!sr.EndOfStream)
                    {
                        string word = sr.ReadLine();
                        if (word.Length >= 3)
                            words.Add(word);
                    }
                }
            }
            return words;
        }
        private string SelectWord(List<string> words)
        {
            return words[new Random().Next(0, words.Count - 1)];
        }
        private bool PlayHangman(HangmanGame hangman)
        {
            List<char> enteredLetters = new List<char>();
            int attempts = 8;
            while (true)
            {
                char letter = ReadLetter(enteredLetters);
                if (hangman.ContainsLetter(letter))
                    hangman.ProcessLetter(letter);
                else
                    attempts--;
                Console.WriteLine($"Attempts left: {attempts}\n");
                DisplayWord(hangman.guessedWord);

                if (attempts <= 0 || hangman.IsGuessed())
                    break;

            }
            return hangman.IsGuessed();
        }
        private void DisplayWord(string word)
        {
            foreach (char c in word)
                Console.Write($"{c} ");

            Console.WriteLine();
        }
        private void DisplayLetters(List<char> letters)
        {
            Console.Write("Entered letters: ");
            foreach (char c in letters)
                Console.Write($"{c} ");

            Console.WriteLine();
        }
        private char ReadLetter(List<char> blacklistLetters)
        {
            char c = readChar(blacklistLetters);
            while (!blacklistLetters.Contains(c))
                c = readChar(blacklistLetters);
            
            return c;
        }
        private char readChar(List<char> blacklistLetters)
        {
            Console.Write("Enter a letter: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (!blacklistLetters.Contains(c))
                blacklistLetters.Add(c);
            DisplayLetters(blacklistLetters);

            return c;
        }
    }
}
