using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Gecko: Reptile
    {
       
        public override void Sound()
        {
            Console.WriteLine("Hissssss");
        }

        void SellInsurance()
        {
            Console.WriteLine("15 minutes can save you 15 percent or more on car insurance!!");
        }
    }
}
