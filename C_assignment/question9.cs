using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_assignment
{
    internal class question9
    {
        public static void Main9()
        {
            Console.WriteLine("Enter the first Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth Number:");
            int num4 = Convert.ToInt32(Console.ReadLine());

            float avg= (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of " + num1 + "," + num2 + "," + num3+"," + num4 + "=" + avg);
            Console.ReadKey();
        }
    }
}
