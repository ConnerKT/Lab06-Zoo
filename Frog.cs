using System;
namespace Lab6
{
	public class Frog : Animal, IBreathe
	{
		public Frog()
		{
            Console.WriteLine("Ribbit!!!!!");
		}
        public override void Move()
        {
            Console.WriteLine("Hop Hop Hop");
        }
        public override void Sleep()
        {
            Console.WriteLine("Ribbit Ribbit Ribbit (Sleep Sounds)");
        }
        public void BreatheIn()
        {
            Console.WriteLine("Croak Croak (breathing in noises)");
        }
        public void BreatheOut()
        {
            Console.WriteLine("croack croack (breathing out noises)");
        }
    }
}

