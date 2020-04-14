using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 语句
{
    class Program
    {
        //局部变量声明：
        static void Main(string[] args)
        {
            int a;
            int b = 2, c = 3;
            a = 1;
            Console.WriteLine(a + b + c);
        }
        //局部常量声明：
        static void Main1(string[] args)
        {
            const float pi = 3.1415927f;
            const int r = 25;
            Console.WriteLine(pi * r * r);
        }
        //表达式语句：
        static void Main2(string[] args)
        {
            int i;
            i = 123;                
            Console.WriteLine(i);  
            i++;                    
            Console.WriteLine(i);   
        }
        //if 语句：
        static void If(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            else
            {
                Console.WriteLine("One or more arguments");
            }
        }
        //switch语句：
        static void Main3(string[] args)
        {
            int n = args.Length;
            switch (n)
            {
                case 0:
                    Console.WriteLine("No arguments");
                    break;
                case 1:
                    Console.WriteLine("One argument");
                    break;
                default:
                    Console.WriteLine($"{n} arguments");
                    break;
            }
        }
        //while语句：
        static void Main4(string[] args)
        {
            int i = 0;
            while (i <= args.Length)
            {
                Console.WriteLine("null");
                i++;
            }
        }
        //Do语句
        static void Main5(string[] args)
        {
            string s;
            do
            {
                s = Console.ReadLine();
                Console.WriteLine(s);
            } while (!string.IsNullOrEmpty(s));
        }
        //for 语句：
        static void Main6(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        //foreach 语句：
        static void Main7(string[] argss)
        {
            int[] args = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (int s in args)
            {
                Console.WriteLine(s);
            }
        }
        //break 语句：
        static void Main8(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                    break;
                Console.WriteLine(s);
            }
        }
        //Main
        static void Main9(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                    continue;
                Console.WriteLine(args[i]);
            }
        }
        //goto 语句
        static void Main10(string[] args)
        {
            int i = 0;
            goto check;
        loop:
            Console.WriteLine(args[i++]);
        check:
            if (i < args.Length)
                goto loop;
        }
        //return语句
        static int Add(int a, int b)
        {
            int s = a + b;
            return s;
        }
        static  void Main11(string[] args)
        {
            Console.WriteLine(Add(1, 2));
           
        }
        //yield 语句：
        static System.Collections.Generic.IEnumerable<int> Range(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                yield return i;
            }
            yield break;
        }
        static void Main12(string[] args)
        {
            foreach (int i in Range(-10, 10))
            {
                Console.WriteLine(i);
            }
        }
        //throw 和 try 语句：
        static double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }
        static void Main13(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Two numbers required");
                }
                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Divide(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
        //checked 和 unchecked 语句：
        static void Main14(string[] args)
        {
            int x = int.MaxValue;
            unchecked
            {
                Console.WriteLine(x + 1);  // Overflow -2147483648
            }
            checked
            {
                Console.WriteLine(x + 1);  // Exception
            }
        }
        //lock 语句：
        class Account
        {
            decimal balance;
            private readonly object sync = new object();
            public void Withdraw(decimal amount)
            {
                lock (sync)
                {
                    if (amount > balance)
                    {
                        throw new Exception(
                            "Insufficient funds");
                    }
                    balance -= amount;
                }
            }
        }
        //using 语句：
        static void Main15(string[] args)
        {
            using (TextWriter w = File.CreateText("test.txt"))
            {
                w.WriteLine("Line one");
                w.WriteLine("Line two");
                w.WriteLine("Line three");
            }
        }

    }


}
