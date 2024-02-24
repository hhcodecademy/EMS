using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    internal class Student:Person
    {
        public float Grade { get; set; }
        public void Learn()
        {
            Console.WriteLine($"{this.Name}  is learning ");
        }
        public void PrepareHomework() {

            Console.WriteLine($"{this.Name}  prepare homework ");
        }
    }
}
