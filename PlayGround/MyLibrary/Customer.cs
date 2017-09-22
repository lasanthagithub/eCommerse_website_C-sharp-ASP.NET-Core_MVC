using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public abstract class Person  // abstract - to get only the specific class 
    {
        public string Name { get; set; }

        public void UpdateName(string newName)
        {
            Name = newName;
        }
    }
    public class Customer : Person // Inheritance
    {
        public int CustomerID { get; set; }
    }
    public class Supplier : Person
    {
        public int SupplierID { get; set; }

    }
}
