using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorvSuperHero
{
	class StrongHero : SuperHeroes
	{
		public StrongHero()
		{
			IQ = generator.Next(80, 120);
			strenght = generator.Next(70, 100);
			speed = generator.Next(40, 60);

			Console.WriteLine("Stats");
			Console.WriteLine("IQ: " + IQ);
			Console.WriteLine("Strenght: " + strenght);
			Console.WriteLine("Speed: " + speed);
		}
	}
}
