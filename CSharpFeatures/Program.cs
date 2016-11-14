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
            LoopDemo.ReturnContinue();
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
            // Param Array
            Console.WriteLine("======== Param Array can be value or no value ========");
            var sum = ParamArrays.SumVals(1, 5, 2, 9, 8);
            Console.WriteLine($"Summed Values = {sum}");
            Console.WriteLine($"Summed Values = {ParamArrays.SumVals()}");
            // Ref Val
            Console.WriteLine("======== By val By Ref ========");
            ReferenceAndValue.ByValue(5);
            //out param 
            Console.WriteLine("======== Outparam ========");
            int[] myArray = { 1,5,4,3,2};
            int maxIndex;
            Console.WriteLine($"The maximum value in myArray is {OutParameters.MaxValue(myArray, out maxIndex)}");
            Console.WriteLine($"The first occurrence of this value is at element { maxIndex + 1}");
            //
            string dir, name;
            OutParameters.SplitPath("c:\\Windows\\System\\hello.txt", out dir, out name);
            Console.WriteLine(dir);
            Console.WriteLine(name);
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


            Console.Read();
        }


    }
}
