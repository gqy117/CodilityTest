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
            int blockCount = 0;
            IList<int> stack = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int height = H[i];

                //// If there is no block, then we have no choice but to add one
                if (!stack.Any())
                {
                    stack.Add(height);
                    blockCount++;
                }
                else if (height == stack.Last())
                {
                    /*The last block is exact the same as the current height
                       Do nothing, since they can share the block*/
                    continue;
                }
                else
                {
                    /*Keep removing the last block, 
                     * until is LOWER or the SAME as the current height*/

                    while (stack.Any() && stack.Last() > height)
                    {
                        //// Remove last one
                        stack.RemoveAt(stack.Count - 1);
                    }

                    //// If it' the same
                    if (stack.Any() && height == stack.Last())
                    {
                        continue;
                    }
                    else
                    {
                        /* If it's lower, 
                         * we add a new block based on the lower one*/

                        stack.Add(height);
                        blockCount++;
                    }
                }
            }

            return blockCount;
        }
    }
}