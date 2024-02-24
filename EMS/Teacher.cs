using EMS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    internal class Teacher:Employee
    {
      
        public BranchType  Branch { get; set; }
        public override void Work() {

            Console.WriteLine($"{this.Name} is teaching...");
        }
        public void AssignToHomework() {
            Console.WriteLine($"{this.Name} is teacher assign to homework...");
        }

    }
}
