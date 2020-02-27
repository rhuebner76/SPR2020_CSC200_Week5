using System;

namespace Week5ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();
            string name = "something";
            SayHelloTo(name);
            SayGoodbyeTo(name);


            int a = 25;
            int b = 33;
            int c = Sum(a, b);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("Output of sum(a, b) = " + c);
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }

        public static void SayHelloTo(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static void SayGoodbyeTo(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
