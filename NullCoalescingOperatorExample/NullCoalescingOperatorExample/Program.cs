using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCoalescingOperatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "a";
            string b = "b";
            string result = null;

            result = a ?? b;

            Console.WriteLine($"El resultado es '{result}'");
            Console.Read();
            
        }
    }
}
