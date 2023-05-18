using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    public class Customer
    {
        public int a, b;
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public Customer()
        {
            Id = 120;
            Name = "Mansi";
        }
        public Customer(int id)
        {
            this.Id = id;
        }
        public void CustomerMethod()
        {

        }
        public void CustomerMethod(string name)
        {

        }
    }
}
