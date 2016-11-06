using System;

namespace CSharpFeatures
{
    public class IncrementDecrement
    {
        public static void Increment(int originalValue)
        {
            // Test Increment 
            Console.WriteLine($"Calculating on {originalValue}");

            var temp1 = ++originalValue;
            Console.WriteLine($"Value:{originalValue} | PlaceHolde={temp1} | ++Value");

            Console.WriteLine($"Calculating on {originalValue}");
            var temp2 = originalValue++;
            Console.WriteLine($"Value:{originalValue} | PlaceHolde={temp2} | Value++");
        }

        public static void Decrement(int originalValue)
        {
            // Test  Decrement
            Console.WriteLine($"Calculating on {originalValue}");

            var temp1 = --originalValue;
            Console.WriteLine($"Value:{originalValue} | PlaceHolde={temp1} | --Value");

            Console.WriteLine($"Calculating on {originalValue}");
            var temp2 = originalValue--;
            Console.WriteLine($"Value:{originalValue} | PlaceHolde={temp2} | Value--");
        }
    }
}