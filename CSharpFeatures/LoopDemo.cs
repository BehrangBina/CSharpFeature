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
            Console.Write($"Value: {value} loop breaks at 6 | ");
            var i = 1;
            while (i < value)
            {
                if (i == 6)
                    break;
                Console.Write($"{i++}, ");
            }
        }

        public static void ReturnContinue()
        {
            Console.WriteLine(" 1-10, continue at 5");
            for (var i = 1; i < 11; i++)
            {
                if (i == 5) continue;
                Console.Write($"{i}, ");

            }
            Console.WriteLine();

            Console.WriteLine(" 1-10, return at 5");
            for (var i = 1; i < 11; i++)
            {
                if (i == 5) return;
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }
    }
}
