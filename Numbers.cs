using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            int min;
            if (number1 < number2)
            {
                min = number1;
            }
            else
            {
                min = number2;
            }
            return min;
        }

        public int FindMinimum(int number1, int number2, int number3)
        {

            int[] nilai = { number1, number2, number3 };
            int min = nilai[0];
            for (int i = 0; i < 3; i++)
            {
                if (nilai[i] < min)
                {
                    min = nilai[i];
                }
            }


            return min;
        }

        public int FindMaximum(int number1, int number2)
        {
            int min;
            if (number1 > number2)
            {
                min = number1;
            }
            else
            {
                min = number2;
            }
            return min;
        }

        public int FindMaximum(int number1, int number2, int number3)
        {

            int[] nilai = { number1, number2, number3 };
            int min = nilai[0];
            for (int i = 0; i < 3; i++)
            {
                if (nilai[i] > min)
                {
                    min = nilai[i];
                }
            }


            return min;
        }

    }
}