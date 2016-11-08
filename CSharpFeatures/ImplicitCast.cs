using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public static class ImplicitCast
    {
        public static void CheckUncheck()
        {
            byte destinationVar = 0;
            short sourceVar = 281;
            Console.WriteLine();
            Console.WriteLine($"Casting {sourceVar.GetType()} to {destinationVar.GetType()}");
            Console.WriteLine($"sourceVar val: {sourceVar}");
            try
            {
                destinationVar = checked((byte) sourceVar);
            }
            catch (Exception e)
            {

                Console.WriteLine("Could not Cast" + e.Message);
            }
            finally
            {
                destinationVar = unchecked ((byte)sourceVar);
                Console.WriteLine($"destinationVar val: {destinationVar}");
            }
        }
    }
}
