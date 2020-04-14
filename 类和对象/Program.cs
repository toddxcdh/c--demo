using System;

namespace 类和对象
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Point p1 = new Point(0, 0);
            Point p2 = new Point(10, 20);
            Console.WriteLine(p2.x); //10

            Pair<int, string> pair = new Pair<int, string> { First = 1, Second = "two" };
            int i = pair.First;     // TFirst is int
            string s = pair.Second; // TSecond is string
        }
    }
    public class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    //参数类型
    public class Pair<TFirst, TSecond>
    {
        public TFirst First;
        public TSecond Second;
    }
}
