# Inheritance Practice Questions

This repository contains C# solutions for common inheritance and polymorphism exercises. Each question demonstrates key object-oriented programming concepts using .NET 8 and C# 12.

---

## 🧪 Q4. Shape Area

**Objective:**  
Implement a base class `Shape` with a `Display()` method.  
Create two child classes:
- `Cricle` (note: typo, should be `Circle`)  
  - Method: `Area(double radius)` returns the area of a circle.
- `Square`  
  - Method: `Area(double width, double height)` returns the area of a square.

**Features:**
- Demonstrates method overriding with the `override` keyword.
- Shows polymorphic behavior via the `Display()` method.

---

## 🧪 Q5. Employee Types

**Objective:**  
Create a base class `Employee` with properties for `Name`, `ID`, and a method `CalculateSalary()`.

Child classes:
- `FullTimeEmployee`  
  - Salary calculation: basic salary + bonus.
- `PartTimeEmployee`  
  - Salary calculation: hourly rate × hours worked.

**Features:**
- Demonstrates inheritance and polymorphism.
- Tests both employee types using base class references.

---

## 🧪 Q6. Vehicle Hierarchy

**Objective:**  
Create a base class `Vehicle` with a `Drive()` method.

Child classes:
- `Car`  
  - Additional method: `PlayMusic()`
- `Truck`  
  - Additional method: `LoadCargo()`

**Features:**
- Inherits and overrides the `Drive()` method.
- Adds new functionality in derived classes.

---

## How to Run

1. Open the solution in Visual Studio 2022.
2. Build the project targeting .NET 8.
3. Run the application to see console output demonstrating inheritance and polymorphism.

---

## Notes

- All classes are implemented in a clear, beginner-friendly style.
- The code is organized by question for easy reference.
- Typo in class name `Cricle` should be corrected to `Circle` for clarity.

---

## License

This project is provided for educational purposes.