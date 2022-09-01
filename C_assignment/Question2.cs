using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_assignment
{
    internal class Question2
    {
        public static void Main2()
        {
            Console.WriteLine("Enter first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of two number is :" + (num1 + num2));
            Console.ReadKey();

        }
    }
}
