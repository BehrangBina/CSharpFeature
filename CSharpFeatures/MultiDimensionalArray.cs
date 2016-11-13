using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public static class MultiDimensionalArray
    {
        public static void PrintTwoDimension(int[,] twoDimensionArray)
        {
            foreach (var height in twoDimensionArray)
            {
                Console.Write("{0},", height);
                
            }
            Console.WriteLine();
        }
        public static void PrintThreeDimension(int[,,] threeDimensionArray)
        {
            foreach (var height in threeDimensionArray)
            {
                Console.Write("{0},", height);

            }
            Console.WriteLine();
        }
    }
}
