using System;

namespace 类和对象
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(0, 0);
            Point p2 = new Point(10, 20);
            //Console.WriteLine(p2.x); //10
            Point3D b = new Point3D(10, 20, 30);
            //Console.WriteLine(b.z); //30


            Pair<int, string> pair = new Pair<int, string> { First = 1, Second = "two" };
            int i = pair.First;
            string s = pair.Second;
            //Console.WriteLine(s); //two

            Color color = new Color(1, 2, 3);
            // Console.WriteLine(color.r ); //1
            //Console.WriteLine(Color.Black.r); //1,0

            //RefExample.SwapExample(); //2 1
            //OutExample.OutUsage(); // 3 1


            string sx = "x={0} y={1} z={2}";
            object[] argsx = new object[3];
            argsx[0] = 'x';
            argsx[1] = 'y';
            argsx[2] = 'z';
            // Console.WriteLine(sx, argsx); x=x y=y z=z

            //EntityExample.Usage(); //1000 1001 1002

            OverloadingExample.UsageExample();

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
        //继承 Point
        public class Point3D : Point
        {
            public int z;
            public Point3D(int x, int y, int z) :
                base(x, y)
            {
                this.z = z;
            }
        }
        //字段
        public class Color
        {
            public static readonly Color Black = new Color(0, 0, 0);
            public static readonly Color White = new Color(255, 255, 255);
            public static readonly Color Red = new Color(255, 0, 0);
            public static readonly Color Green = new Color(0, 255, 0);
            public static readonly Color Blue = new Color(0, 0, 255);
            public int r, g, b;
            public Color(int r, int g, int b)
            {
                this.r = r;
                this.g = g;
                this.b = b;
            }
        }
        //方法参数
        class RefExample
        {
            static void Swap(ref int x, ref int y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            public static void SwapExample()
            {
                int i = 1, j = 2;
                Swap(ref i, ref j);
                Console.WriteLine($"{i} {j}");    
            }
        }

        class OutExample
        {
            static void Divide(int x, int y, out int result, out int remainder)
            {
                result = x / y;
                remainder = x % y;
            }
            public static void OutUsage()
            {
                Divide(10, 3, out int res, out int rem);
                Console.WriteLine("{0} {1}", res, rem); 
            }
        }
        //静态和实例方法
        class Entity
        {
            static int nextSerialNo;
            int serialNo;
            public Entity()
            {
                serialNo = nextSerialNo++;
            }
            public int GetSerialNo()
            {
                return serialNo;
            }
            public static int GetNextSerialNo()
            {
                return nextSerialNo;
            }
            public static void SetNextSerialNo(int value)
            {
                nextSerialNo = value;
            }
        }
        class EntityExample
        {
            public static void Usage()
            {
                Entity.SetNextSerialNo(1000);
                Entity e1 = new Entity();
                Entity e2 = new Entity();
                Console.WriteLine(e1.GetSerialNo());            
                Console.WriteLine(e2.GetSerialNo());            
                Console.WriteLine(Entity.GetNextSerialNo());    
            }
        }
        //方法重载
        class OverloadingExample
        {
            static void F()
            {
                Console.WriteLine("F()");
            }
            static void F(object x)
            {
                Console.WriteLine("F(object)");
            }
            static void F(int x)
            {
                Console.WriteLine("F(int)");
            }
            static void F(double x)
            {
                Console.WriteLine("F(double)");
            }
            static void F<T>(T x)
            {
                Console.WriteLine("F<T>(T)");
            }
            static void F(double x, double y)
            {
                Console.WriteLine("F(double, double)");
            }
            public static void UsageExample()
            {
                F();            // Invokes F()
                F(1);           // Invokes F(int)
                F(1.0);         // Invokes F(double)
                F("abc");       // Invokes F<string>(string)
                F((double)1);   // Invokes F(double)
                F((object)1);   // Invokes F(object)
                F<int>(1);      // Invokes F<int>(int)
                F(1, 1);        // Invokes F(double, double)
            }
        }

        // TODO
        //其他函数成员
    }
}
