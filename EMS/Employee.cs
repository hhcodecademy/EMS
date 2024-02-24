using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    internal class Employee:Person
    {
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public virtual void Work()
        {
            Console.WriteLine($"{this.Name} is working");
        }
    }
}
