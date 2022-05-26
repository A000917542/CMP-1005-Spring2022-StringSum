using System;

namespace CMP_1005_Spring2022_StringSum
{
    public static class StringSum
    {
        

        public static int Add(string numbers)
        {
            int sum = 0;

            if (numbers.Contains(" "))
            {
                string[] strNums = numbers.Split(' ');
                foreach(string num in strNums)
                {
                    sum = sum + int.Parse(num);
                }

                return sum;
            }
            else
            {
                return int.Parse(numbers);
            }
        }
    }
}
