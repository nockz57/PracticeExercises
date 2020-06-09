using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    public class TextExercise04
    {
        /* 
            4- Write a program and ask the user to enter a few words separated by a space. 
            Use the words to create a variable name with PascalCase. For example, 
            if the user types: "number of students", display "NumberOfStudents". 
            Make sure that the program is not dependent on the input. So, if the user 
            types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

         */

        public static string PascalCase(string sentence)
        {
            var words = sentence.Split(' ');
            var w = new List<string>();

            //Ensure the user enter few words
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                foreach (var word in words)
                {
                    //format the string to lower case first
                    var l = word.ToLower();
                    //capitalise first letter then concatinate to the remaining letters
                    w.Add(char.ToUpper(l[0]) + l.Substring(1));
                }

                //join the words with no space in between
                var newWord = String.Join("", w);
                return newWord;
            }

            var error = "no input";
            return error;
        }
    }
}
