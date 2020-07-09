using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClass
{
    public class player
    {
        List<char> guesses = new List<char>();
        private int correct = 0;
        public int Correct
        {
            get { return correct; }
            set { correct = value; }
        }
        private int incorrect = 0;
        public int Incorrect
        {
            get { return incorrect; }
            set { incorrect = value; }
        }

    }

    
}
