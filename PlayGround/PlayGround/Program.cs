using System;
//using MyLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary.MyObject myObject = new MyLibrary.MyObject();
            Console.WriteLine("The calculation is " + myObject.Calculate(10, 5));

            var customer = new MyLibrary.Customer();

            var calc = new MyLibrary.Calculate();

            var results = calc.PerformCal(10, 10);
            
            Console.ReadLine();
        }
    }

}
