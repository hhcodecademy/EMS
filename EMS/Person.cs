using EMS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    internal abstract class Person
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public PersonType Type { get; set; }
        public static int Count { get; set; }
        public Person() {

            Count++;
        }
        public virtual void come() {
            Console.WriteLine($"{this.Name} is coming...");
        }
  
     

    }
}
