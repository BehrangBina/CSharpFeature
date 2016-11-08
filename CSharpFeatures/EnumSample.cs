using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public class EnuamSample
    {
        public static void PrintDirection(Orientation orientation)
        {
            switch(orientation)
            {
                case Orientation.East:
                    Console.WriteLine(orientation);
                    break;
                case Orientation.North:
                    Console.WriteLine(orientation);
                    break;
                case Orientation.South:
                    Console.WriteLine(orientation);
                    break;
                case Orientation.West:
                    Console.WriteLine(orientation);
                    break;


            }
        }
    }
    public enum Orientation : byte
    {
        North=1,
        South=2,
        East=3,
        West=4
    }
}
