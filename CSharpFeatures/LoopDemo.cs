using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public static class LoopDemo
    {
        public static void DoWhileSample(int condition)
        {
            do
            {
                Console.Write("{0}", condition++);
            } while (condition > 0 && condition < 10);
        }

        public static void While(int condition)
        {
            while (condition > 0 && condition < 10)
            {
                Console.Write("{0}", condition++);
            }
        }

        public static void WhileBreak(int value)
        {
            Console.Write($"Value: {value} loop breaks at 6");
            var i = 1;
            while (i<value)
            {
                if (i == 6)
                    break;
                Console.Write($"{i++}, ");
            }
        }
    }
}
