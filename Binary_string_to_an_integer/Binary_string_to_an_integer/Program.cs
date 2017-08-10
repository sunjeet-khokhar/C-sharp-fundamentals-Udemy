using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_string_to_an_integer
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 1, 1, 0 };
            var str = string.Join("", arr);
            Console.WriteLine(str);
            convert_bin_to_int(str);
        }

        static void convert_bin_to_int(string binary_string)
        {
            int sum = 0;
            sum = Convert.ToInt32(binary_string, 2);
            Console.WriteLine(sum);
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }
    }
}
