using System;

namespace StringInterpol
{
    class Program
    {
        static void Main(string[] args)
        {
        //Insert value in String / Mix String to otter values.
        Console.Clear();
        var price = 10.2 + 9; //Price is double
        var text = "O preço do produto é " + price + " este valor é apenas na promoção \n" ; //This process insert + call is interpol.

        var buy = true;

        var stringFor = string.Format("O preço do produto é {0} apenas na promoção {1} \n", true, price);
        //In this case, need to add in final of the string two values, or after compile program, show a exception //Use to format string / Insert value into string.

        var StringCifroni = $@"O preço do produto é {price}"; //Add @ ignore special character, ou $ to add other value type. \n = line break;

        Console.WriteLine(text);
        Console.WriteLine(buy + "\n" );
        Console.WriteLine(stringFor);
        Console.WriteLine(StringCifroni);
        }
    }
}
