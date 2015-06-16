namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Nesting
    {
        private enum Direction
        {
            Left = 0,
            Right = 1
        }

        public static int Solution(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return 1;
            }

            IList<char> s = S.ToCharArray().ToList();
            IList<Bracket> leftBrackets = new List<Bracket>();
            IList<Bracket> rightBrackets = new List<Bracket>();

            for (int i = S.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                Bracket bracket = GetBracket(c, i);

                switch (bracket.Direction)
                {
                    case Direction.Left:
                        leftBrackets.Add(bracket);
                        break;
                    case Direction.Right:
                        rightBrackets.Add(bracket);
                        break;
                }

                if (leftBrackets.Any() && rightBrackets.Any()
                    && leftBrackets.Last().Index < rightBrackets.Last().Index)
                {
                    leftBrackets.RemoveAt(leftBrackets.Count - 1);
                    rightBrackets.RemoveAt(rightBrackets.Count - 1);
                }
            }

            if (!leftBrackets.Any() && !rightBrackets.Any())
            {
                return 1;
            }

            return 0;
        }

        private static Bracket GetBracket(char c, int i)
        {
            Bracket bracket = new Bracket() { Index = i };

            switch (c)
            {
                case '(':
                    bracket.Direction = Direction.Left;
                    break;
                case ')':
                    bracket.Direction = Direction.Right;
                    break;
                default:
                    throw new Exception("Invalid char!");
            }

            return bracket;
        }

        private class Bracket
        {
            public Direction Direction { get; set; }

            public int Index { get; set; }
        }
    }
}
