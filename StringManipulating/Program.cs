using System;

namespace StringManipulating
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = " This is my power text ";
            //Look change oldValue to newValue
            Console.WriteLine(text.Replace("This", "Wtf"));
            Console.WriteLine(text.Replace("p", "P")); //Replace all character lower to upper

            Console.WriteLine("");

            var division = text.Split(" ");//Change list of character to list of strings
            Console.WriteLine(division[0]);
            Console.WriteLine(division[1]);
            Console.WriteLine(division[2]);
            Console.WriteLine(division[3]);
            Console.WriteLine(division[4]);

            var result = text.Substring(5, text.LastIndexOf("s"));
            Console.WriteLine(result);

            Console.WriteLine(text.Trim());//Get and remove start and end spaces between
        }
    }
}
