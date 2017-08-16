using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequnecy_of_chars_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test_arr = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            count_freq_of_chars(test_arr);
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }

        static void count_freq_of_chars(int[] seq)
        {
            var count_dict = new Dictionary<int, int>();
             foreach(int i in seq)
            {
                if (count_dict.ContainsKey(i))
                    count_dict[i]++;
                else
                    count_dict[i] = 1;
            }

             foreach(var pair in count_dict)
            {
                if ((pair.Value) % 2 != 0)
                {
                    //Console.WriteLine(pair.Key.ToString(),pair.Value);
                    Console.WriteLine(pair.Key);
                }
            }
        }

    }

}
