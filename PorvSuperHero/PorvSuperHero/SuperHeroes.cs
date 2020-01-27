using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorvSuperHero
{
	class SuperHeroes
	{
		protected static Random generator = new Random(); //Skapar en random generator som kan användas i de andra klasserna
		protected int speed = 0; //ints som lagrar siffror som endast kan ändras från den klass eller klasser som ärver
		protected int strenght = 0;
		protected int IQ = 0;
		
	}
}
