using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void Calculation(int a, int b);
    public class Delegatessc1
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
       public  static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        public static void Divison(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);

        }
    }
}
