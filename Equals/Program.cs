using System;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var text = "This text is a test";
            var test = 33;
            //Compare object
            Console.WriteLine(test.Equals(32));
            //Compare text
            Console.WriteLine(text.Equals("This text is a test"));
            Console.WriteLine(text.Equals("this text is a test"));//False because Case Sensitive
            Console.WriteLine(text.Equals("This text is a test", StringComparison.OrdinalIgnoreCase));//Convert text to upper;
        }
    }
}
