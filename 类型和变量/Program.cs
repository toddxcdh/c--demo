using System;

namespace 类型和变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;    // Boxing
            int j = (int)o;  // Unboxing
            Console.WriteLine(j);
        }
    }
}
