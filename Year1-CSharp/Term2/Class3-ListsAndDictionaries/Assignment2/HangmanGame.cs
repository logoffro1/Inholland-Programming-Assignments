using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class HangmanGame
    {
        public string secretWord { get; set; }
        public string guessedWord { get; set; }
        public void Init(string secretWord)
        {
            this.secretWord = secretWord;
            foreach (char c in secretWord)
                guessedWord += ".";
        }
        public bool ContainsLetter(char letter)
        {
            return secretWord.Contains(letter);
        }
        public void ProcessLetter(char letter)
        {
            StringBuilder sb = new StringBuilder(guessedWord);
            for (int i = 0; i < secretWord.Length; i++)
            {
               
                if (secretWord[i] == letter)
                    sb[i] = letter;
            }
            guessedWord = sb.ToString();
        }
        public bool IsGuessed()
        {
            return guessedWord == secretWord;
        }
    }
}
