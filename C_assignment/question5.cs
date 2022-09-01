using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_assignment
{
    internal class question5
    {
        public static void Main5()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap");
            Console.WriteLine("The first number :" + num1 + " The second number:"+num2);
            int num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("After swap");
            Console.WriteLine("The first number : " + num1 + " The second number: " + num2);
            Console.ReadKey();



        }
    }
}
