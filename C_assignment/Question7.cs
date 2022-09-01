using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_assignment
{
    internal class Question7
    {
        public static void Main7()
        {
            Console.WriteLine("Input the First Number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second Numbe :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of two numbers is:"+(num1+num2));
            Console.WriteLine("The subtraction of two numbers is :"+(num1-num2));
            Console.WriteLine("The Multiplication of two numbers is :"+(num1*num2));
            Console.WriteLine("The division of two number is :"+(num1/num2));
            Console.WriteLine("The modulation of two number is :"+(num1%num2));
            Console.ReadKey();
        }

    }
}
