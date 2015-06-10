namespace Codility
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FrogJmp
    {
        public static int Solution(int X, int Y, int D)
        {
            double roundUp = Math.Ceiling((Y - (double)X) / D);

            return (int)roundUp;
        }
    }
}