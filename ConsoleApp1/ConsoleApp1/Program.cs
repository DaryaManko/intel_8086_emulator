using System;

namespace project
{
    class Program
    {

        private static void BubbleSort(int[] array)
        {
            for (int i = 2; i < 7; i++)
            {
                for (int j = i; j < 7; j++)
                    if (array[i] < array[j])
                    {
                        int t = array[i ];
                        array[i] = array[j];
                        array[j] = t;

                    }
            }
                
        }
        public static void Main()
        {
            int[] array = { 2,1, 3, 6, 4, 3, 5, 3, 1,8 };
            BubbleSort(array);
            foreach (int e in array)
                Console.Write(e);

            Console.ReadKey();
        }
    }
}