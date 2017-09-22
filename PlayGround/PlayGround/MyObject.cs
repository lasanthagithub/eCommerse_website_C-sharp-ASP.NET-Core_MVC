using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    class MyObject
    {
        // inetrnal properties
        int _number1 = 0;
        int _number2 = 0;

        //
        public int number1 { get; set; }
        public int number2 { get; set; }
        public int number3 { get; set; }

        // method
        public int Calculate(int number1, int number2)
        {
            return number1 + number2;
        }

        public string MyMethod()
        {
            return "Some value";
        }
    }
}
