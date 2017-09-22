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

            MyLibrary.ICalculate function = new MyLibrary.AddCalculate();
            MyLibrary.ICalculate sustractFunction = new MyLibrary.SubstractCalculate();
            MyLibrary.ICalculate multiplyFunction = new MyLibrary.MultiplyCalculate();

            var results = function.PerformCal(10, 10);

            Console.WriteLine(results);
            
            Console.ReadLine();
        }
    }

}
