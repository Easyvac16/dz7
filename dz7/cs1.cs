using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }
    interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
    class Array : ICalc , IOutput2 , ICalc2
    {
        private int[] values;

        public Array(int[] values)
        {
            this.values = values;
        }

        public int CountDistinct()
        {
            return values.Distinct().Count();
        }

        
        public int EqualToValue(int valueToCompare)
        {
            return values.Count(x => x == valueToCompare);
        }

        public void ShowEven() 
        {
            Console.WriteLine("Парні числа в масиві:");
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    Console.Write(values[i] + " ");
                }

            }
            Console.WriteLine();
        }

        public void ShowOdd() 
        {
            Console.WriteLine("Непарні числа в масиві:");
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 != 0)
                {
                    Console.Write(values[i] + " ");
                }

            }
            Console.WriteLine();
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
    internal class cs1
    {
        public static void task_1()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[] values = { 1, 2, 3, 4, 5 , 6 , 7 , 8, 8, 8};
            Array array = new Array(values);
            string valuesString = string.Join(",", values);
            Console.WriteLine(valuesString);
            Console.WriteLine($"Чисел в массиві меньше ніж 3:{array.Less(3)}");
            Console.WriteLine($"Чисел в массиві більших ніж 5:{array.Greater(5)}");
            array.ShowOdd();
            Console.WriteLine();
            array.ShowEven();
            Console.WriteLine();
            Console.WriteLine($"Унікальні числа в масиві:{array.CountDistinct()}");
            Console.WriteLine($"Кількість чисел в масиві рівна 2:{array.EqualToValue(8)} ");
        }
    }
}
