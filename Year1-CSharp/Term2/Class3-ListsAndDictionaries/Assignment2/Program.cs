using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            List<string> words = ListOfWords();
            string selectedWord = SelectWord(words);

            hangman.Init(selectedWord);
            bool guessed = PlayHangman(hangman);

            if (guessed)
                Console.WriteLine("You guessed the word!");
            else
                Console.WriteLine($"Too bad, you did not guess the word ({hangman.secretWord})");


        }
        private List<string> ListOfWords()
        {
            List<string> words = new List<string>();
            words.Add("airplane");
            words.Add("kitchen");
            words.Add("building");
            words.Add("incredible");
            words.Add("funny");
            words.Add("trainstation");
            words.Add("neighbor");
            words.Add("different");
            words.Add("department");
            words.Add("planet");
            words.Add("presentation");
            words.Add("embarrassment");
            words.Add("integration");
            words.Add("scenario");
            words.Add("discount");
            words.Add("management");
            words.Add("understanding");
            words.Add("registration");
            words.Add("security");
            words.Add("language");

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
                Console.WriteLine($"Attempts left: {attempts}");
                Console.WriteLine();
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
            {
                c = readChar(blacklistLetters);
            }
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
