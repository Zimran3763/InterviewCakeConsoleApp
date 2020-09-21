using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class BracketValidator
    {
        public static bool IsValid(string code)
        {
            #region my solution
            //    // Determine if the input code is valid
            //    char[] arr = code.ToCharArray();
            //    Stack<char> stk = new Stack<char>();
            //    for (int i = 0; i < code.Length; i++)
            //    {
            //        if (arr[i] == '{')
            //        {
            //            stk.Push('}');
            //        }
            //        if (arr[i] == '[')
            //        {
            //            stk.Push(']');
            //        }
            //        if (arr[i] == '(')
            //        {
            //            stk.Push(')');
            //        }
            //        else if (arr[i] == '}' || arr[i] == ']' || arr[i] == ')')
            //        {
            //            if (stk.Count == 0)
            //            {
            //                return false;
            //            }

            //            char c = stk.Pop();
            //            if (arr[i] != c)
            //            {
            //                return false;
            //            }
            //        }
            //    }
            //    //if count == 0 it would return true else false
            //    return stk.Count==0;
            //}
            #endregion
            var openersToClosers = new Dictionary<char, char>
            {
                { '(', ')' },
                { '[', ']' },
                { '{', '}' }
            };

            var openers = new HashSet<char>(openersToClosers.Keys);
            var closers = new HashSet<char>(openersToClosers.Values);

            var openersStack = new Stack<char>();

            foreach (char c in code)
            {
                if (openers.Contains(c))
                {
                    openersStack.Push(c);
                }
                else if (closers.Contains(c))
                {
                    if (openersStack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char lastUnclosedOpener = openersStack.Pop();

                        // If this closer doesn't correspond to the most recently
                        // seen unclosed opener, short-circuit, returning false
                        if (openersToClosers[lastUnclosedOpener] != c)
                        {
                            return false;
                        }
                    }
                }
            }
            return openersStack.Count == 0;
        }
    }
}
