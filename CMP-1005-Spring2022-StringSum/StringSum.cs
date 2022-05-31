using System;

namespace CMP_1005_Spring2022_StringSum
{
    public static class StringSum
    {
        public static int Add(string numbers)
        {
            int sum = 0;

            string[] strNums = numbers.Split(' ');
            foreach (string num in strNums)
            {
                int pNum = 0;
                if (int.TryParse(num, out pNum))
                {
                    sum = sum + pNum;
                }
                else
                {
                    throw new ArgumentException("Argument is not numbers.");
                }
                    
            }

            return sum;
        }
    }
}
