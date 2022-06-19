using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task1. Reverse int array.*/
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Task1. The initial array1:");
            foreach (int i in array1)
            {
                Console.Write("{0} ", i);
            }
            int temp1 = 0;
            for (int i = 0; i < array1.Length / 2; i++)
            {
                temp1 = array1[i];
                array1[i] = array1[array1.Length - i - 1];
                array1[array1.Length - i - 1] = temp1;
            }
            Console.WriteLine("\nThe result of the array1 reversing: ");
            foreach (int i in array1)
            {
                Console.Write("{0} ", i);
            }

            /**********************************************************/
            /*Task2. Reverse max and min in the array.*/
            int[] array2 = { 10, 322, 56, 790, 67, 789 };
            Console.WriteLine("\nTask2. The initial array2:");
            foreach (int i in array2)
            {
                Console.Write("{0} ", i);
            }
            int max = array2[0];
            int min = array2[0];
            int maxIndex = 0;
            int minIndex = 0;
            int temp2 = 0;
            for (int i = 1; i < array2.Length; i++)
            {
                if (max < array2[i])
                {
                    max = array2[i];
                    maxIndex = i;
                }
                if (min > array2[i])
                {
                    min = array2[i];
                    minIndex = i;
                }

            }
            temp2 = array2[minIndex];
            array2[minIndex] = array2[maxIndex];
            array2[maxIndex] = temp2;
            Console.WriteLine("\nThe result of the reverse min and max elements in the array2: ");
            foreach (int i in array2)
            {
                Console.Write("{0} ", i);
            }

            /**********************************************************/
            /*Task3. Reverse max and min in the array.*/
            char[] array3 = {'a', 'c', 'f', 'd', 'f', 'd', 't', 't', 'f', 'a', 'g', 'f', 'A', 'g'};
            Console.WriteLine("\nTask3. The initial array3:");
            foreach (char c in array3)
            {
                Console.Write("{0} ", c);
            }
            int maxCount = 0;
            char character = array3[0];
            for (int i = 0; i < array3.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array3.Length; j++)
                {
                    if (array3[i] == array3[j])
                    {
                        count++;                    
                    }

                }
                if (maxCount < count)
                {
                    maxCount = count;
                    character = array3[i];
                }
            }
            Console.WriteLine("\nThe most common character in the array3 is '{0}' with quantity = {1}.", character, maxCount);
        }
    }
}
