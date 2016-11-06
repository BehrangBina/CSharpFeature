using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public static class TernaryOperator
    {
        public static string GreaterThanValue(int value, int condition)
       
        {
            // ?   :
            Console.WriteLine($"Working with ? : - value:{value} | Condition {condition}" );
            var resultString = (value > condition) ? "Greater than"
                                  : "less than or equal to";
            return resultString;
        }

        public static string LessThanValue(int value, int condition)
        {
            Console.WriteLine($"Working with ? : - value:{value} | Condition {condition}");
            var result = (value < condition) ? "Less Than Condition" : "Greater Than  or Equal Condition";
            return result;
        }
    }
}
