using System;
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
            MyObject myObject = new MyObject();
            Console.WriteLine("The calculation is " + myObject.Calculate(10, 5));
            Console.ReadLine();
        }
    }

}
