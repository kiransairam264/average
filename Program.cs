using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            float average;
            Console.WriteLine("enter three numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            average = (n1 + n2 + n3) / 3;
            Console.WriteLine("average of three numbers is" + average);


        }
    }
}
