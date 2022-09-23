using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int loopsNumber = 0;
            int x = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    loopsNumber++;
                }
            }
            int[] newArray = new int[loopsNumber];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    newArray[x] = numbers[i];
                    x++;
                }
            }
            return newArray;
        }
    }
}
