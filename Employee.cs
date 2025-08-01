using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Employee
	{
		public string Name { get; set; }
		public int ID { get; set; }

		public Employee(string name, int id)
		{
			Name = name;
			ID = id;
		}
		public virtual double  CalculateSalary ()
		{
			return 0;

		}
	}
	public class FullTimeEmployee : Employee
	{
		public double BasicSalary { get; set; }
		public  double Bonus { get; set; }
		public FullTimeEmployee(string name, int id , double basicsalary, double bonus): base(name,id) {
			BasicSalary = basicsalary;
			Bonus = bonus;
		}
		public override double CalculateSalary()
		{
			return BasicSalary + Bonus;
		}

	}
	public class PartTimeEmployee : Employee
	{
		public double Hourly{ get; set; }
		public int HoursWorked { get; set; }

		public PartTimeEmployee(string name, int id,double hourly , int hoursWorked): base(name,id)
		{
			Hourly = hourly;
			HoursWorked = hoursWorked;

		}
		public override double CalculateSalary()
		{
			return Hourly * HoursWorked;
		}
	}
}
