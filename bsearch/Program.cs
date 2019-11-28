using System;
using System.Collections.Generic;

namespace bsearch
{
    /// <summary>
    /// This program demonstrate the sorting function
    /// </summary>
    class Program
    {
        public int[] CreateArray()
        {
            Console.Write("Enter the number of numbers: ");
            int NumOfNums = Int32.Parse(Console.ReadLine());
            int[] array = new int[NumOfNums];
            for (int i = 0; i < NumOfNums; i++)
            {
                bool exceptions = false;
                while (!exceptions)
                {
                    try
                    {
                        Console.Write("Enter numbers: ");
                        array[i] = Int32.Parse(Console.ReadLine());
                        exceptions = true;

                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine($"Error: You entered incorrect value ");
                        exceptions = false;
                        continue;
                    }
                }
            }
            return array;
        }

        public int[] sorting(int[] array)
        {
            int temp;
            for (int a = 0; a < array.Length-1; a++)
            {
                for (int i = a + 1; i < array.Length; i++)
                {
                    if (array[a] >= array[i])
                    {
                        temp = array[a];
                        array[a] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
        public int bsearch(int[] array, int x = 0)
        {
            return array[0];
        }
        static void Main(string[] args)
        {
            int[] array;
            int x;
            Program ob = new Program();
            array = ob.CreateArray();
            array = ob.sorting(array);
            int answer = ob.bsearch(array, x = 2);
            if (answer <= x)
            {
                Console.WriteLine($"the first element of the array ({answer}) is less than or equal to x");
            }
            else if(answer > x)
            {
                Console.WriteLine($"Answer is {answer}");
                Console.Write("Array values - ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
