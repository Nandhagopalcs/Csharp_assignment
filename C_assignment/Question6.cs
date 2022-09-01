using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_assignment
{
    internal class Question6
    {
        public static void Main6()
        {
            Console.WriteLine("Input the First number to multiply");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second number to multiply");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Third number to multiply");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Answer is"+num1*num2*num3);
            Console.ReadKey();
        }
    }
}
