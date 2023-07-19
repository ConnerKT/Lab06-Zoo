using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class Animal
    {
        public virtual void Sleep()
        {
            Console.WriteLine("ZZzzzzz");
        }
       
        public virtual void Move()
        {
            Console.WriteLine("Move Forward!!");
        }
    }
}
