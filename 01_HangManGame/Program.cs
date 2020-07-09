using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _01_HangManGame
{
    class Program
    {
        static void Main()
        {
            Console.Title = ("HangMan game");
            string secretword = "spaceship";
            List<string> letterGuessed = new List<string>();
            int lives = 5;
            Console.WriteLine("Welcome to the Hangman Game");
            Console.WriteLine(
                "guess for a {0} Letter word", secretword.Length);
            Console.WriteLine("You have {0} Lives", lives);
            Isletter(secretword, letterGuessed);
            while (lives > 0)
            {
                string input = Console.ReadLine();
                if (letterGuessed.Contains(input))
                {
                    Console.WriteLine("you entered [{0}] already", input);
                    Console.WriteLine("try a different word");
                    
                    continue;
                }
                letterGuessed.Add(input);
                if (IsWord(secretword, letterGuessed))
                {
                    Console.WriteLine(secretword);
                    Console.WriteLine("congratulations you are correct");
                    break;
                }
                else if (secretword.Contains(input))
                {
                    Console.WriteLine("nice entry");
                    string letters = Isletter(secretword, letterGuessed);
                    Console.WriteLine(letters);
                }
                else
                {
                    Console.WriteLine("letter not in my word");
                    lives -= 1;
                    Console.WriteLine("you have {0} lives", lives);
                }
                Console.WriteLine();
                if (lives == 0)
                {
                    Console.WriteLine("Game over you lost \n My secret word is [ {0} ] ", secretword);
                    break;
                }
            }
            Console.ReadKey();
        }
        static bool IsWord(string myword , List<string> letterGuessed)
        {
            bool word = false;
            for(int i =0; i < myword.Length; i++)
            {
                string d = Convert.ToString(myword[i]);
                if (letterGuessed.Contains(d))
                {
                    word = true;
                }
                else
                {
                    return word = false;
                }
            }
            return word;
        }
        static string Isletter(string secretword, List<string> letterGuessed)
        {
            string correctletters = "";
            for (int i = 0; i < secretword.Length; i++)
            {
                string d = Convert.ToString(secretword[i]);
                if (letterGuessed.Contains(d))
                {
                    correctletters += d;

                }
                else
                {
                    correctletters += "_";
                }
            }
            return correctletters;
        }
        
            
        
    }
}













