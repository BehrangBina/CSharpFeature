using System;
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
            IncrementDecrement.Increment(10);
            IncrementDecrement.Decrement(10);
            Console.WriteLine(TernaryOperator.GreaterThanValue(5, 10));
            Console.WriteLine(TernaryOperator.LessThanValue(5, 5));
            //SwitchGoto.PrintFive(0);
            LoopDemo.DoWhileSample(10);
            Console.WriteLine();
            LoopDemo.WhileBreak(100);
            //== Implicit Cast by Check
            ImplicitCast.CheckUncheck();
            Console.Read();
        }
    }
}
