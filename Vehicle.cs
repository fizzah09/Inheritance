using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Vehicle
	{

		public virtual void Drive()
		{
			Console.WriteLine("The vehicle is driving.");
		}
	}
	public class Car : Vehicle
	{
		public override void Drive()
		{
			Console.WriteLine("The car is driving.");
		}
		public void PlayMusic()
		{
			Console.WriteLine("Playing music in the car.");
		}
	}
	public class Truck : Vehicle
	{
		public override void Drive()
		{
			Console.WriteLine("Driving truck...");
		}

		public void LoadCargo()
		{
			Console.WriteLine("Loading cargo in the truck.");
		}
	}

}
