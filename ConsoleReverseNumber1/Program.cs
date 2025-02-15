using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReverseNumber1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(num));
        }
        static int ReverseNumber(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                int last = num % 10;
                reverse=reverse*10 + last;
                num /= 10;
            }
            return reverse;
        }


    }
}
