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

            IList<int> smallLeftBracket = new List<int>();
            IList<int> smallRightBracket = new List<int>();
            IList<int> middleLeftBracket = new List<int>();
            IList<int> middleRightBracket = new List<int>();
            IList<int> largeLeftBracket = new List<int>();
            IList<int> largeRightBracket = new List<int>();
            IList<char> s = S.ToCharArray().ToList();

            for (int i = S.Length - 1; i >= 0; i--)
            {
                switch (s[i])
                {
                    case '{':
                        if (middleLeftBracket.Any() || middleRightBracket.Any()
                            || smallLeftBracket.Any() || smallRightBracket.Any())
                        {
                            return 0;
                        }

                        largeLeftBracket.Add(i);
                        break;
                    case '}':
                        largeRightBracket.Add(i);
                        break;
                    case '[':
                        if (smallLeftBracket.Any() || smallRightBracket.Any())
                        {
                            return 0;
                        }

                        middleLeftBracket.Add(i);
                        break;
                    case ']':
                        middleRightBracket.Add(i);
                        break;
                    case '(':
                        smallLeftBracket.Add(i);
                        break;
                    case ')':
                        smallRightBracket.Add(i);
                        break;
                }

                if (largeLeftBracket.Any() && largeRightBracket.Any()
                    && largeLeftBracket.Last() < largeRightBracket.Last())
                {
                    largeLeftBracket.RemoveAt(largeLeftBracket.Count - 1);
                    largeRightBracket.RemoveAt(largeRightBracket.Count - 1);
                }

                if (middleLeftBracket.Any() && middleRightBracket.Any()
                    && middleLeftBracket.Last() < middleRightBracket.Last())
                {
                    middleLeftBracket.RemoveAt(middleLeftBracket.Count - 1);
                    middleRightBracket.RemoveAt(middleRightBracket.Count - 1);
                }

                if (smallLeftBracket.Any() && smallRightBracket.Any()
                    && smallLeftBracket.Last() < smallRightBracket.Last())
                {
                    smallLeftBracket.RemoveAt(smallLeftBracket.Count - 1);
                    smallRightBracket.RemoveAt(smallRightBracket.Count - 1);
                }
            }

            if (!smallLeftBracket.Any() && !smallRightBracket.Any()
                && !middleLeftBracket.Any() && !middleRightBracket.Any()
                && !largeLeftBracket.Any() && !largeRightBracket.Any())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
