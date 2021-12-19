using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikroszimulacio10.Entities
{
    public class Person
    {
        public int BirthYear { get; set; } //prop
        public Gender Gender { get; set; }
        public int NbrOfChildren { get; set; }
        public bool IsAlive { get; set; }

        public Person() //ctor
        {
            IsAlive = true;  
        }

    }
}
