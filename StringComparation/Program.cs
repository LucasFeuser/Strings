using System;

namespace StringComparation
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();
           var text = "Test";
           var text2 = "This text is a test";
           //Case sensitive = T != t;
           Console.WriteLine(text.CompareTo("Test"));
           Console.WriteLine(text.CompareTo("test"));

           Console.WriteLine(text2.Contains("test"));//Verify if var text2, contain "test" defined in u value;
           Console.WriteLine(text2.Contains("Test"));//In this case, test set a T Upper, remember C# is a case sensitive;

        }
    }
}
