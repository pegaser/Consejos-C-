using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCoalescingAssignmentOperatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = null;
            int? number = null;

            (numberList ??= new List<int>()).Add(7);
            Console.WriteLine(string.Join("|", numberList));  // output: 7

            numberList.Add(number ??= 22);
            Console.WriteLine(string.Join("|", numberList));  // output: 7|22
            Console.WriteLine(number);  // output: 22
            Console.Read();
        }
    }
}
