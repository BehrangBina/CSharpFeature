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
            //enum
            var  directionByte = (byte)Orientation.West;
            Console.WriteLine($"{Orientation.West} - {directionByte}");
            //strut
            route myRoute;
            myRoute.direction = Orientation.East;
            myRoute.distance=5.4;
            Console.WriteLine($"{myRoute.direction} - {myRoute.distance}");
            // multi array
            int[,] twoArray = { { 1, 2, 3, 4 }, { 2, 3, 4, 5 }, { 3, 4, 5, 6 } };
            MultiDimensionalArray.PrintTwoDimension(twoArray);
            // String pad left right
            StringManuplation.Pad("Aligned",8);
          

            Console.Read();
        }


    }
}
