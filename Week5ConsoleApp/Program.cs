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

            string phrase = "This is a test phrase to count from 1,2,3...";
            
            int whitespaceCount = GetWhitespaceCount(phrase);
            Console.WriteLine("Phrase: \"" + phrase  + "\"\ncontains " +  whitespaceCount + " whitespace characters.");


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

        public static int GetWhitespaceCount(string phrase)
        {
            int count = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i].Equals(' '))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
