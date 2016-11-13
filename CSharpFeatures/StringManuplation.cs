using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public static class StringManuplation
    {
        public static void Pad(string str, int padding, char pad = '.')
        {
            Console.WriteLine($"String is {str} - length: {str.Length}");
            Console.WriteLine($"String padding right by: {padding}");
            Console.WriteLine(str.PadRight(padding,pad));
           
            Console.WriteLine($"String padding left by: {padding}");
            Console.WriteLine(str.PadLeft(padding, pad));


        }
    }
}
