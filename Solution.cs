using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors_demo_cs
{
    class Solution
    {
        // Encapsulates the main demo logic
        public void Run()
        {
            // Create two Human objects with name and age using constructor
            Human Human1 = new Human("Jacky", 22);
            Human Human2 = new Human("Mason", 23);

            // Demonstrate Human behaviors
            Human1.Eat();
            Human1.Sleep();

            Human2.Eat();
            Human2.Sleep();

            // Create two Car objects with make, model, year, and color using constructor
            Car Car1 = new Car("Ford", "F-150", 2022, "Red");
            Car1.Drive();

            Car Car2 = new Car("Chevy", "Corvette", 2021, "Blue");
            Car2.Drive();
        }
    }

    // Human class with properties and behaviors
    public class Human
    {
        public String Name; // Human name
        public int Age;     // Human age

        // Constructor to initialize Human object
        public Human(String Name, int age)
        {
            this.Name = Name; // Assign name
            this.Age = age;   // Assign age
        }

        // Simulates the human eating
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        // Simulates the human sleeping
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
    }

    // Car class with properties and behavior
    public class Car
    {
        public String Make;   // Brand of the car
        public String Model;  // Model name
        public int Year;      // Year of manufacture
        public String Color;  // Color of the car

        // Constructor to initialize Car object
        public Car(String Make, String Model, int Year, String Color)
        {
            try
            {
                // Assign constructor parameters to class fields
                this.Make = Make;
                this.Model = Model;
                this.Year = Year;
                this.Color = Color;
            }
            catch (Exception Issue)
            {
                // Catch any assignment errors (unlikely in this case)
                Console.WriteLine($"[ERROR]: {Issue.Message}");
            }
        }

        // Simulates driving the car
        public void Drive()
        {
            try
            {
                Console.WriteLine($"This is the car you drive: ");
                Console.WriteLine($"MAKE: {Make}");
                Console.WriteLine($"MODEL: {Model}");
            }
            catch (Exception Issue)
            {
                // Catch unexpected issues during Drive (e.g., null properties)
                Console.WriteLine($"[ERROR]: {Issue.Message}");
            }
        }
    }
}
