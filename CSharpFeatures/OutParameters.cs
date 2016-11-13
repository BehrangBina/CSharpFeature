namespace CSharpFeatures
{
    public static class OutParameters
    {
        public static int MaxValue(int[] intArray, out int maxIndex)
        {
            var maxVal = intArray[0];
            maxIndex = 0;
            for (var i = 0; i < intArray.Length; i++)
            {
                var val = intArray[i];
                if (val > maxVal)
                {
                    maxVal = val;
                    maxIndex = i;
                }
            }
            return maxVal;
        }
    }
}
