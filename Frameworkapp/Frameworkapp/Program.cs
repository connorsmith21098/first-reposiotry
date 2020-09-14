using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworkapp
{
    class Program
    {
        static void Main(string[] args)
        {

            short num1, num2;
            int addAns;
            //num1 = 3;
            //num2 = 2;
            Console.WriteLine("Enter Number: ");
            num1 = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number: ");
            num2 = short.Parse(Console.ReadLine());

            addAns = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " is equal to " + addAns);

            Console.Read();
        }
    }
}
