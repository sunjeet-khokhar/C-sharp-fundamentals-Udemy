using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelloWorld
{
    class Variables
    {
        static void Main(string[] args)
        {
            byte num = 3;
            int count = 1234;
            float index = 34.5678f;
            string my_name = "is not khan";
            bool truth = false;
            Console.WriteLine(num);
            Console.WriteLine(count);
            Debug.WriteLine(index);
            Debug.WriteLine(my_name);
            Debug.WriteLine(truth);

            var num_1 = "12345";
            try
            {
                byte b = Convert.ToByte(num_1);
            }
            
            catch (Exception)
            {
                Console.WriteLine("Conversion failed");
            }
            //Console.WriteLine(b);
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();



        }

    }

    class Cast_Practice
    {
        static void Try_Casting()
            {

            int i = 341;
            // casting 
            byte b = (byte)i;

            //Console.WriteLine();
            Console.WriteLine(b);

                float f = 1.0f;
                int i1 = (int)f;
                Console.WriteLine(i1);

           
                    Console.WriteLine("Press any key to stop...");
                    Console.ReadKey();
            }

    }

}


