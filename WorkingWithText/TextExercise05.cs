using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    public class TextExercise05
    {
        /*
            5- Write a program and ask the user to enter an English word. Count the number of 
            vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program 
            should display 6 on the console.
         */


        public static int Vowels(string sentence)
        {
            int total = 0;

            if (!string.IsNullOrWhiteSpace(sentence))
            {
                //int counter = 0;
                string lower = sentence.ToLower();
                var words = lower.ToCharArray();
                foreach (var word in words)
                {
                    if ((word == 'a') || (word == 'e') || (word == 'i') || (word == 'o') || (word == 'u'))
                    {
                        total += 1;
                    }
                }
                return total;
            }

            return total;
        }
    }
}
