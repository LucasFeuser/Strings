using System;

namespace StrinStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var text = ("This text is a test");

            Console.WriteLine("Valdiation Start \n");
            Console.WriteLine(text.StartsWith("Este"));
            Console.WriteLine(text.StartsWith("este"));
            Console.WriteLine(text.StartsWith("This"));

            Console.WriteLine("");

            Console.WriteLine("Validation End \n");
            Console.WriteLine(text.EndsWith("This text is a test"));
            Console.WriteLine(text.EndsWith("Magnata"));
            Console.WriteLine(text.EndsWith("oi"));
        }
    }
}
