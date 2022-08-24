using System;
using System.Text;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "This is my builder test";
            var text2 = text; //Copy to text
            text += " eae";//Concaten
            Console.WriteLine(text);//Use to add value to big power hyper definition;

            Console.WriteLine("");

            var textBuilder = new StringBuilder();
            textBuilder.Append("This my beaultifull text \n");
            textBuilder.Append("Because u are my sunshine \n");
            textBuilder.Append("Bye bye bye \n");
            textBuilder.Append("Look my text");

            textBuilder.ToString();//Converte to string, because textBuilder is a StringBuild and not a String.
            Console.WriteLine(textBuilder);
        }
    }
}
