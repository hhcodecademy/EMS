using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    internal class Staff:Employee
    {
        public string Position { get; set; }
        public override void Work() {
            Console.WriteLine($"{this.Name} is evaluating");
        }
        public void CallToStudent() {
            Console.WriteLine($"{this.Name} is calling");
        }
    }
}
