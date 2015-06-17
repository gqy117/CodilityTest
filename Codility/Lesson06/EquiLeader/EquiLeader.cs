namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EquiLeader
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            IList<int> listA = A.ToList();
            int[] leaderLeft = new int[N - 1];
            int[] leaderRight = new int[N - 1];

            Stack<int> leaderCandidate = new Stack<int>();

            for (int S = 0; S < N - 1; S++)
            {
                PushOrPopLeftStack(A, leaderCandidate, S);

                var leader = GetLeftLeader(leaderCandidate, listA, S);

                leaderLeft[S] = leader;
            }

            leaderCandidate = new Stack<int>();
            for (int S = N - 2; S >= 0; S--)
            {
                PushOrPopRightStack(A, leaderCandidate, S);

                var leader = GetRightLeader(leaderCandidate, listA, S);

                leaderRight[S] = leader;
            }

            int count = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (leaderLeft[i] == leaderRight[i] && leaderLeft[i] != -1)
                {
                    count++;
                }
            }

            return count;
        }

        private static void PushOrPopLeftStack(int[] A, Stack<int> leaderCandidate, int S)
        {
            if (!leaderCandidate.Any() ||
                A[S] == leaderCandidate.Peek())
            {
                leaderCandidate.Push(A[S]);
            }
            else
            {
                leaderCandidate.Pop();
            }
        }

        private static void PushOrPopRightStack(int[] A, Stack<int> leaderCandidate, int S)
        {
            if (!leaderCandidate.Any() ||
                A[S + 1] == leaderCandidate.Peek())
            {
                leaderCandidate.Push(A[S + 1]);
            }
            else
            {
                leaderCandidate.Pop();
            }
        }

        private static int GetLeftLeader(Stack<int> leaderCandidate, IList<int> listA, int S)
        {
            int leader = -1;

            if (leaderCandidate.Any())
            {
                int possibleLeader = leaderCandidate.Peek();
                int currentLength = S + 1;
                if (listA.Take(currentLength).Count(x => x == possibleLeader) > currentLength / 2)
                {
                    leader = possibleLeader;
                }
            }

            return leader;
        }

        private static int GetRightLeader(Stack<int> leaderCandidate, IList<int> listA, int S)
        {
            int leader = -1;

            if (leaderCandidate.Any())
            {
                int possibleLeader = leaderCandidate.Peek();
                int currentLength = listA.Count - S - 1;
                if (listA.Skip(S + 1).Take(currentLength).Count(x => x == possibleLeader) > currentLength / 2)
                {
                    leader = possibleLeader;
                }
            }

            return leader;
        }
    }
}
