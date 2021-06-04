using System;

namespace IsItALeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool IsItALeapYear(int input)
        {
            return (input % 400 == 0) || ((input%100 != 0) && (input % 4 == 0)) ? true : false;
        }
    }
}
