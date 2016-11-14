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

        public static void SplitPath(string path, out string dir, out string name)
        {
            var length = path.Length;
            while (length > 0)
            {
                var ch = path[length - 1];
                if (ch == '\\' || ch == '/' || ch == ':') break;
                length--;
            }
            dir = path.Substring(0, length);
            name = path.Substring((length));

        }
    }
}
