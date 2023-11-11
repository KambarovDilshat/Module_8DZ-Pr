using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic8_1
{

    class RangeOfArray
    {
        private int[] array;
        private int lowerIndex;
        private int upperIndex;

        public RangeOfArray(int lower, int upper)
        {
            lowerIndex = lower;
            upperIndex = upper;
            array = new int[upper - lower + 1];
        }

        public int this[int index]
        {
            get
            {
                if (index >= lowerIndex && index <= upperIndex)
                    return array[index - lowerIndex];
                else
                    throw new IndexOutOfRangeException("Index out of range");
            }

            set
            {
                if (index >= lowerIndex && index <= upperIndex)
                    array[index - lowerIndex] = value;
                else
                    throw new IndexOutOfRangeException("Index out of range");
            }
        }

        public void InputArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент массива с индексом {i + lowerIndex}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public void OutputArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Элемент с индексом {i + lowerIndex}: {array[i]}");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            RangeOfArray myArray = new RangeOfArray(1, 5); // Создание массива с индексами от 1 до 5
            myArray.InputArray();
            myArray.OutputArray();
        }
    }

}