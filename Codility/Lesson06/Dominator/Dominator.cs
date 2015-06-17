namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dominator
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            Stack<int> leaderNumber = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                // If current one is the same as the last one, then add the current one to the stack
                if (!leaderNumber.Any() 
                    || leaderNumber.Peek() == A[i])
                {
                    leaderNumber.Push(A[i]);
                }
                else
                {
                    //// If the last one is different from the current one, then we remove both

                    leaderNumber.Pop();
                }
            }

            // There is a possible leader
            if (leaderNumber.Any())
            {
                int possibleLeader = leaderNumber.Pop();

                /*If the number appears more than half of the array, 
                 * then it's the true leader, 
                 * and we find its index*/
                if (A.Count(x => x == possibleLeader) > N / 2)
                {
                    return A.ToList().FindIndex(x => x == possibleLeader);
                }
            }

            return -1;
        }
    }
}