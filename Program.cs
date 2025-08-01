namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.Display();
            Shape circle = new Cricle();
            circle.Display();
            Cricle cricle = new Cricle();
			string circleArea = cricle.Area(5);
			Shape square = new Square();
            square.Display();
            Square squareShape = new Square();
            string squareArea = squareShape.Area(4, 5);
            Console.WriteLine(circleArea);
            Console.WriteLine(squareShape);
			Employee emp1 = new FullTimeEmployee("Asma", 1, 50000, 5000);
			Employee emp2 = new PartTimeEmployee("Fahad", 2, 200, 20);

			Console.WriteLine($"{emp1.Name} Salary: {emp1.CalculateSalary()}");
			Console.WriteLine($"{emp2.Name} Salary: {emp2.CalculateSalary()}");
            Vehicle vehicle = new Car();
            vehicle.Drive();
            ((Car)vehicle).PlayMusic();
            Vehicle mytRUCK = new Truck();
            mytRUCK.Drive();
		}

    }
}
