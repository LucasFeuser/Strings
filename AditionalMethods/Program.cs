using System;

namespace AditionalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mytext = "This text is a test";
            var Lowertxt = "text lower";
            var Uppertxt = "TEXT UPPER";
            Console.WriteLine(Uppertxt.ToLower());
            Console.WriteLine(Lowertxt.ToUpper());
            //Index = position / Value = value to insert.
            Console.WriteLine(Mytext.Insert(5, "Eae")); //Insert a character
            Console.WriteLine(Mytext.Remove(5, 3)); //Remove a character
            Console.WriteLine("U text have " + Mytext.Length + " Character"); //Count quantity of character
        }
    }
}
