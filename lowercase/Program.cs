using System;

namespace lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Char c = Convert.ToChar(Console.ReadLine());
            tolower(c);
            Console.Read();
        }
        static void tolower(char c)
        {
            c = Convert.ToChar(c + 32);
            Console.WriteLine(c);
        }
    }
}
