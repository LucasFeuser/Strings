using System;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var text = "This text is a test";
            //Validation object position;
            Console.WriteLine(text.IndexOf("T"));
            Console.WriteLine(text.IndexOf("a"));
            Console.WriteLine(text.IndexOf("es"));

            //Get a last object position
            Console.WriteLine(text.LastIndexOf("a"));


        }
    }
}
