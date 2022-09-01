using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_assignment
{
    internal class question10
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(" + num1 + "+" + num2 + ")" + "." + num3 + "=" + ((num1 + num2) * num3));
            Console.WriteLine(num1 + "." + num2 + "+" + num2 + "." + num3+"="+((num1*num2)+num2*num3));
            Console.ReadKey();
        }
    }
}
