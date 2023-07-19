using System;
namespace Lab6
{
	class Frog : Animal
	{
		public Frog(string Sound)
		{
            Console.WriteLine(Sound);
		}
        public override void Move()
        {
            Console.WriteLine("Hop Hop Hop");
        }
        public override void Sleep()
        {
            Console.WriteLine("Ribbit Ribbit Ribbit (Sleep Sounds)");
        }
    }
}

