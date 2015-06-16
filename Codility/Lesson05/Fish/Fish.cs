namespace Codility
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Fish
    {
        public static int Solution(int[] A, int[] B)
        {
            int N = A.Length;
            IList<FishInfo> stackUp = new List<FishInfo>();
            IList<FishInfo> stackDown = new List<FishInfo>();
            int deadFishes = 0;

            for (int i = N - 1; i >= 0; i--)
            {
                var fish = new FishInfo { Index = i, Value = A[i] };
                bool isUpStream = 0 == B[i];
                if (isUpStream)
                {
                    stackUp.Add(fish);
                }
                else
                {
                    stackDown.Add(fish);
                }

                /* Make sure that Up Team & Down Team will have a fight :)
                 */
                while (stackUp.Any() && stackDown.Any()
                    && stackUp.Last().Index > stackDown.Last().Index)
                {
                    int fishUp = stackUp.Last().Value;
                    int fishDown = stackDown.Last().Value;

                    if (fishUp > fishDown)
                    {
                        stackDown.RemoveAt(stackDown.Count - 1);
                    }
                    else
                    {
                        stackUp.RemoveAt(stackUp.Count - 1);
                    }

                    deadFishes++;
                }
            }

            return N - deadFishes;
        }

        private class FishInfo
        {
            public int Index { get; set; }

            public int Value { get; set; }
        }
    }
}
