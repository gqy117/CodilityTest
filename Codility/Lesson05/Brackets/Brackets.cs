namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Brackets
    {
        public static int Solution(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return 1;
            }

            Dictionary<char, char> matchBracket = new Dictionary<char, char>()
            {
                 { ']', '[' },
                 { '}', '{' },
                 { ')', '(' },
            };

            IList<char> leftBrackets = new List<char>()
            {
                '[',
                '(',
                '{'
            };

            Stack<char> stackedLeftBrackets = new Stack<char>();

            foreach (var s in S)
            {
                if (leftBrackets.Contains(s))
                {
                    // Left bracket
                    stackedLeftBrackets.Push(s);
                }
                else
                {
                    // Right bracket

                    // no left bracket
                    if (!stackedLeftBrackets.Any())
                    {
                        return 0;
                    }
                    else
                    {
                        if (stackedLeftBrackets.Pop() != matchBracket[s])
                        {
                            // Not found right bracket
                            return 0;
                        }
                    }
                }
            }

            return stackedLeftBrackets.Any() ? 0 : 1;
        }
    }
}
