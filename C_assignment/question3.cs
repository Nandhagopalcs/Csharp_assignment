using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_assignment
{
    internal class question3
    {
        public static void Main3()
        {
            Console.WriteLine("Enter the first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Answer is :" + num1 / num2);
            Console.ReadKey();
        }
    }
}
