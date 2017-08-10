using System;
using Living_Beings;

public class Human
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Sunjeet";
        person.Introduce_yourself();

        //string[] currency = new string[3];

        var currency = new string[3];

        currency[0] = "rupee";
        currency[1] = "dolla dolla";
        currency[2] = "franc";

        foreach (string s in currency)
        {
            Console.WriteLine(s);
        }

        bool_array();

        var name = "Sunjeet";

        Console.WriteLine("My name is " + "  " + name);

        //Combine  all the numbers of any integer array
        var numbers = new int[3] {22,45,101};
        string list = string.Join(",", numbers);
        Console.WriteLine(list);

        //Verbatim string - tells the compiler to take the string literally , hence we dont need escape characters
        string path = @"D:\DLD\Bahubali 2 2017 Hindi 720p DVDRip x264-LOKI-M2Tv ExCluSivE";
        string path1 = "D:\\DLD\\Bahubali 2 2017 Hindi 720p DVDRip x264-LOKI-M2Tv ExCluSivE";
        Console.WriteLine(path+"\n"+path1);



        Console.WriteLine("Press any key to stop...");
        Console.ReadKey();
    }

    public static void bool_array()
    {
        var bool_arr = new bool[3];
        bool_arr[0] = true;
        bool_arr[1] = false;
        bool_arr[2] = true;

        foreach (bool b in bool_arr)
        {
            Console.WriteLine(b);
        }
    }
}
