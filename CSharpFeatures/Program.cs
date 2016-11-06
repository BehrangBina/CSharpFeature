﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Increment(10);
            Decrement(10);
            Console.Read();
        }

        public static void Increment(int originalValue)
        {
            // Test Increment 
            Console.WriteLine($"Original Values= Value1:{originalValue} | value2={originalValue}");

            var temp1 = ++originalValue;
            Console.WriteLine($"Value:{originalValue} | PlaceHolde={temp1} | ++Value");

            var temp2 = originalValue++;
            Console.WriteLine($"Value:{originalValue} | PlaceHolde={temp2} | Value++");
        }

        public static void Decrement(int originalValue)
        {
            // Test  Decrement
            Console.WriteLine($"Original Values= Value1:{originalValue} | value2={originalValue}");

            var temp1 = --originalValue;
            Console.WriteLine($"Value:{originalValue} | PlaceHolde={temp1} | --Value");

            var temp2 = originalValue--;
            Console.WriteLine($"Value:{originalValue} | PlaceHolde={temp2} | Value--");
        }
    }
}
