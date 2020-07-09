using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanRepository
{
    public class Hangmanrepo
    {
        List<string> WordBank = new List<string> { "bread", "racecar", "spaceship", "boat", "orange", "float", };
        string _secretWord;

        public string secretWord { get; set; }


        // Main Method 
        static public void Main()
        {

            // Declaration of data type 
            bool result;

            // checking for Unicode letter in 
            // a string at a desired position 
            string secretWord = "";
            result = Char.IsLetter(str1, 2);
            Console.WriteLine(result);

            // checking for Unicode letter in a 
            // string at a desired position 
            string str2 = "geeks46forgeeks";
            result = Char.IsLetter(str2, 5);
            Console.WriteLine(result);
        }
    }
}
