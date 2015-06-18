namespace Codility
{
    using System;

    public class MinPerimeterRectangle
    {
        public static int Solution(int N)
        {
            int perimeter = int.MaxValue;

            int A = 1;

            while (Math.Pow(A, 2) <= N)
            {
                if (N % A == 0)
                {
                    int B = N / A;
                    perimeter = Math.Min((A + B) * 2, perimeter);
                }

                A++;
            }

            return perimeter;
        }
    }
}