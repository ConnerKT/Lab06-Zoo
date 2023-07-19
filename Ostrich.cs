using System;
namespace Lab6
{
	class Ostrich : Bird, IWalks
	{
		public int Legs { get; set; }

		public void Walk()
		{
			Console.WriteLine("Meep Meep");
		}
	}

}