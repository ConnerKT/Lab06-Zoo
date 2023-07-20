using System;
namespace Lab6
{
    public class Dog : Mammal, IWalks, IBreathe
    {
        public int Legs { get; set; }
        public void Walk()
        {
            Console.WriteLine("Zooom");
            
        }
        public void BreatheIn()
        {
            Console.WriteLine("*Dog breathing in noises*");
        }
        public void BreatheOut()
        {
            Console.WriteLine("*Dog breathing out noises*");
        }
    }
}

