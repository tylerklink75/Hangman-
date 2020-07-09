using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManclasses
{
    public class Game
    {
        List<string> WordBank = new List<string> { "bread", "racecar", "spaceship", "boat", "orange", "float", };
        string _secretWord;
        public string ReturnWord()
        {
            Random rand = new Random();
            int index = rand.Next(WordBank.Count);
            _secretWord = WordBank[index];
            return _secretWord;
        }
        


       

    }
}
