namespace Codility
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class StoneWall
    {
        public static int Solution(int[] H)
        {
            int N = H.Length;
            IList<int> stack = new List<int>();
            int block = 0;

            for (int i = 0; i < N; i++)
            {
                // Current Height
                int height = H[i];

                if (!stack.Any() || stack.Last() != height)
                {
                    // Try to find a low block to stand on
                    stack = stack.Where(x => x <= height).ToList();

                    // The last block is not satisfied the required height
                    if (height != stack.LastOrDefault())
                    {
                        // Add a block of the same height as required
                        stack.Add(height);

                        // Use a new block
                        block++;
                    }
                }
            }

            return block;
        }
    }
}