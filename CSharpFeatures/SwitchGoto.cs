using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public static class SwitchGoto
    {
        public static void PrintFive(int value)
        {
            switch (value)
            {
                case (0):
                    {
                        Console.WriteLine(value);
                        goto case 1;
                    }
                case (1):
                    {
                        for (var i = 0; i < 5; i++)
                        {
                            Console.WriteLine(i);
                        }
                        for (var i = 0; i > -5; i--)
                        {
                            Console.WriteLine(i);
                        }

                        break;
                    }
                default:
                    Console.WriteLine(value);
                    Console.WriteLine("Try 0");
                    break;
            }
        }
    }
}
