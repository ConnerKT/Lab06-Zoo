using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Rhino: Mammal
    {
        public void Charge()
        {
            Console.WriteLine("Charrrgee!!!!");
        }

        //public override void Walk()
        //{
        //    Console.WriteLine("Walk on HOOVES");
        //}
        //public override void Breathe()
        //{
        //    Console.WriteLine("Walk on HOOVES");
        //}
        public override void Move()
        {
            Console.WriteLine("Walk on HOOVES");
        }
    }
}
