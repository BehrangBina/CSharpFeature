using System;


namespace CSharpFeatures
{
   public static class ReferenceAndValue
    {
        public static void ByValue(int val)
        {
            var  myNumber = 5;
            Console.WriteLine($"myNumber = {myNumber}");
            ShowDouble1(myNumber);
            Console.WriteLine($"myNumber = {myNumber}");
            //
            Console.WriteLine("=== By Ref ===");
            Console.WriteLine($"myNumber = {myNumber}");
            ShowDouble2(ref myNumber);
            Console.WriteLine($"myNumber = {myNumber}");
        }
        private static void ShowDouble1(int val)
        {
            val *= 2;
            Console.WriteLine($"val doubled = {val}");
        }

        private static void ShowDouble2(ref int val)
        {
            val *= 2;
            Console.WriteLine($"val doubled = {val}");

        }
    }
}
