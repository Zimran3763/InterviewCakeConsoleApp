using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
     public class ParenthesisMatching
    {
        public static int GetClosingParen(string sentence, int openingParenIndex)
        {

            int openNestedParens = 0;
            //start with the next index of openingParenthesis Index so we can find when we are going to hit the last index in openParens
            for (int position = openingParenIndex + 1; position < sentence.Length; position++)
            {
                char c = sentence[position];

                if (c == '(')
                {
                    openNestedParens++;
                }
                else if (c == ')')
                {
                    if (openNestedParens == 0)
                    {
                        return position;
                    }
                    else
                    {
                        openNestedParens--;
                    }
                }
            }

            throw new ArgumentException("No closing parenthesis :(", nameof(sentence));
        }
    }
}
