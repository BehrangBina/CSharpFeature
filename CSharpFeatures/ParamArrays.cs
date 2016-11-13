using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
   public  static class ParamArrays
    {
        public static int SumVals(params int[] vals)
        {
            return vals.Sum();
        }
        
    }
}
