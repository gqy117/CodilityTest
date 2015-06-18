namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EquiLeader
    {
        private const int NoneLeader = -2000000000;

        public static int Solution(int[] A)
        {
            int N = A.Length;
            Dictionary<int, int> countA = new Dictionary<int, int>();
            int[] leaderLeft = new int[N];
            int[] leaderRight = new int[N];

            Stack<int> leaderCandidate = new Stack<int>();

            for (int S = 0; S < N - 1; S++)
            {
                CountNumber(countA, A[S]);

                PushOrPopLeftStack(A, leaderCandidate, S);

                var leader = GetLeftLeader(leaderCandidate, countA, S);

                leaderLeft[S] = leader;
            }

            leaderCandidate = new Stack<int>();
            countA = new Dictionary<int, int>();
            for (int S = N - 1; S >= 1; S--)
            {
                CountNumber(countA, A[S]);

                PushOrPopRightStack(A, leaderCandidate, S);

                var leader = GetRightLeader(leaderCandidate, countA, S, A.Count());

                leaderRight[S] = leader;
            }

            int count = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (leaderLeft[i] == leaderRight[i + 1] && leaderLeft[i] != NoneLeader)
                {
                    count++;
                }
            }

            return count;
        }

        private static void CountNumber(Dictionary<int, int> countA, int value)
        {
            if (!countA.ContainsKey(value))
            {
                countA.Add(value, 1);
            }
            else
            {
                countA[value]++;
            }
        }

        private static void PushOrPopStack(int value, Stack<int> leaderCandidate)
        {
            if (!leaderCandidate.Any() ||
                value == leaderCandidate.Peek())
            {
                leaderCandidate.Push(value);
            }
            else
            {
                leaderCandidate.Pop();
            }
        }

        private static void PushOrPopLeftStack(int[] A, Stack<int> leaderCandidate, int S)
        {
            PushOrPopStack(A[S], leaderCandidate);
        }

        private static void PushOrPopRightStack(int[] A, Stack<int> leaderCandidate, int S)
        {
            PushOrPopStack(A[S], leaderCandidate);
        }

        private static int GetLeftLeader(Stack<int> leaderCandidate, Dictionary<int, int> countA, int S)
        {
            return GetLeader(leaderCandidate, countA, S + 1);
        }

        private static int GetRightLeader(Stack<int> leaderCandidate, Dictionary<int, int> countA, int S, int count)
        {
            return GetLeader(leaderCandidate, countA, count - S);
        }

        private static int GetLeader(Stack<int> leaderCandidate, Dictionary<int, int> countA, int currentLength)
        {
            int leader = NoneLeader;

            if (leaderCandidate.Any())
            {
                int possibleLeader = leaderCandidate.Peek();

                if (countA.ContainsKey(possibleLeader) &&
                    countA[possibleLeader] > currentLength / 2)
                {
                    leader = possibleLeader;
                }
            }

            return leader;
        }
    }
}
