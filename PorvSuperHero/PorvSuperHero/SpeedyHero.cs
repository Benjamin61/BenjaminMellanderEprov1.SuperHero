using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorvSuperHero
{
	class SpeedyHero : SuperHeroes
	{
		public SpeedyHero()
		{
			IQ = generator.Next(80, 120); //Genererar IQ från superheroes klassen med hjälp av generatorn som skapades tidigare
			speed = generator.Next(75, 100);
			strenght = generator.Next(40, 60);

			Console.WriteLine("Stats"); //Skriver ut alla stats
			Console.WriteLine("IQ: " + IQ);
			Console.WriteLine("Strenght: " + strenght);
			Console.WriteLine("Speed: " + speed);
		}
		
	}
}
