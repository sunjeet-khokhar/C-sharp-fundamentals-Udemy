using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Mailing_Categories
    {
        Snail = 1,
        Ostrich = 10,
        Shark = 50,
        Cheetah = 100
    }
    class Program
    {
        static void Main(string[] args)
        {
            var shipping_method = Mailing_Categories.Ostrich;
            Console.WriteLine((int)shipping_method);

            // We dont really need to call the ToString method here as default Console.WriteLine does that i.e. 
            // converts it's parameters to a string
            Console.WriteLine(shipping_method.ToString());

            var ext_method = 1000;
            Console.WriteLine((Mailing_Categories)ext_method);

            //Converting String to Enum to it's int value
            try
            {
                var new_shipping_method = "Snail";
                var incoming_value = Enum.Parse(typeof(Mailing_Categories),new_shipping_method);
                Console.WriteLine((int)incoming_value);
            }
            catch (Exception)
            {
                Console.WriteLine("Value does not exist in the system");
            }

            //int[] ticket_queue  = new int[] { 25,50,100};

            int queue_result;
            queue_result = ticket_collector(new int[] {25,25,50,50});
            if (queue_result >= 1)
            {
                Console.WriteLine("No Varsya can not seel ticket");
            }

            else
            {
                Console.WriteLine("Yes Varsya can sell ticket");
            }
          
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
        }

        static int ticket_collector(int[] queue)
        {
            int yo = 0;
            int no = 0;
            foreach (int q in queue)
            {
                Console.WriteLine(q);
                

            }

            for (int i = 0; i < ((queue.Length)-1); i++)
            {

                if ((queue[i+1] - queue[i]) <= 25)
                {
                    yo = yo + 1;
                }
                else
                {
                    no = no + 1;
                }

            }

            return (no);

        }
    }
}
