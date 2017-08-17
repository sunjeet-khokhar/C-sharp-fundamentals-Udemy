using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Inverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test_arr = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            math_inverse(test_arr);
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }

        public static void math_inverse(int[] seq)
        {
            for (int i = 0; i < (seq.Length); i++)
            {
                seq[i] = -(seq[i]);
                Console.WriteLine(seq[i]);
            }
        }
    }
}
