using System;

namespace ArrayReverseDemo
{
    class ArrRev
    {
        internal void RevArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            foreach (int i in arr)
                Console.WriteLine(i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int n = 0;
            Console.Write("Enter Number of Elemntes: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Element {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            new ArrRev().RevArray(arr);
        }
    }
}
