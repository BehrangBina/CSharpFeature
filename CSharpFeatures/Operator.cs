using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public static class Operator
    {
        public static bool DoubleEqual(bool a, int b, int c)
        {
            return a = b == c; 
        }
        public static bool EqualEsclation(bool a, int b, int c)
        {
            return a = b != c;
        }
        public static bool LessThan(bool a, int b, int c)
        {
            return a = b<c;
        }
        public static bool GreaterThan(bool a, int b, int c)
        {
            return a = b > c;
        }
        public static bool LessThanEqual(bool a, int b, int c)
        {
            return a = b <= c;
        }
        public static bool GreaterThanEqual(bool a, int b, int c)
        {
            return a = b >= c;
        }
    }
}
