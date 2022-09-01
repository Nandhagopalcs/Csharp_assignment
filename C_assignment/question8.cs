using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_assignment
{
    internal class question8
    {
        public static void Main8()
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<11;i++)
            {
                Console.WriteLine(num + "*" + i+"=" + (num * i));
            }
            Console.ReadKey();
        }


    }
}
