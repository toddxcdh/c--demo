using System;

namespace 数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10]; //长度10
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i * i;
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }

            //多维数组
            int[,] a2 = new int[10, 5]; //10*5个元素
            int[,,] a3 = new int[10, 5, 2];

            //数组给值
            int[] a4 = new int[] { 1, 2, 3 };//int[] a4 = {1, 2, 3};
        }
    }
}
