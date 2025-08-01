using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
//	🧬 Inheritance Practice Questions:
//🧪 Q4.Shape Area
//Create a base class Shape with:

//Method: Display()

//Create two child classes:

//Circle → takes radius, returns area.

//Rectangle → takes width and height, returns area.

//Use override keyword if you're using virtual methods
	public class Shape
	{
		public virtual void Display()
		{
			Console.WriteLine("This is a shape.");

		}
	}
	public class Cricle : Shape
	{
		public override void Display()
		{
			Console.WriteLine("This is a circle.");
		}
		public string Area(double radius)
		{
			return  $"The area of the  cricle is {Math.PI * radius * radius}";
		}
	}
	public class Square : Shape
	{
		public override void Display()
		{
			Console.WriteLine("This is a square.");
		}
		public string Area(double width, double height)
		{
			return $"the area of a square is {width * height}";
		}
	}
}
