/*
 * ==================================================
 *   C# Comprehensive Learning Notes
 *   Organized for: WestCoastGod
 *   Date: 2025-07-02
 * ==================================================
 * 
 * Instructions:
 * This file is a self-contained C# program.
 * Each major topic is in its own method (e.g., DemonstrateVariables(), DemonstrateLoops()).
 * To test a specific topic, go to the `Main` method at the top and uncomment the line for the topic you wish to run.
 * 
 */

// The 'using' directive imports namespaces, giving us access to pre-written code.
// 'System' is the most fundamental namespace, containing core types and utilities like Console.
using System;

// A namespace is a container to organize your code and prevent naming conflicts.
namespace CSharpLearningJourney
{
    /// <summary>
    /// This is the main class that holds our learning notes and the program's entry point.
    /// </summary>
    class ComprehensiveNotes
    {
        /// <summary>
        /// The Main method is the starting point of every C# application.
        /// When you run the program, the code inside Main executes first.
        /// </summary>
        static void Main(string[] args)
        {
            // --- Table of Contents ---
            // Uncomment the method call for the section you want to explore.

            // Part 1: The Basics
            // DemonstrateHelloWorld();
            // DemonstrateVariablesAndDataTypes();
            // DemonstrateTypeCastingAndConversion();
            // DemonstrateOperators();

            // Part 2: Program Flow and Logic
            // DemonstrateControlFlow();
            // DemonstrateLoops();

            // Part 3: Data Structures
            // DemonstrateArrays();
            // DemonstrateEnums();

            // Part 4: Building Blocks of Code
            // DemonstrateMethods();

            // Part 5: Object-Oriented Programming (OOP) - The Core of C#
            DemonstrateOOP();
        }

        #region Part 1: The Basics

        public static void DemonstrateHelloWorld()
        {
            Console.WriteLine("\n--- 1. Hello World: Your First C# Code ---");

            // The classic, standard way. All code resides within a class and Main method.
            Console.WriteLine("Hello World! (Traditional)");

            // In modern C# (.NET 6+), you can use "Top-level statements".
            // A file with just `Console.WriteLine("Hello World!");` is a valid program.
            // The compiler generates the class and Main method for you behind the scenes.
        }

        public static void DemonstrateVariablesAndDataTypes()
        {
            Console.WriteLine("\n--- 2. Variables and Common Data Types ---");

            // Variables are named containers for storing data.
            string message = "This is some text";   // For text (strings of characters)
            int wholeNumber = 100;                  // For whole numbers (integers)
            double decimalNumber = 99.9;            // For floating-point (decimal) numbers
            char singleLetter = 'A';                // For a single character
            bool isCSharpFun = true;                // For true/false values

            Console.WriteLine($"string: {message}");
            Console.WriteLine($"int: {wholeNumber}");
            Console.WriteLine($"double: {decimalNumber}");
            Console.WriteLine($"char: {singleLetter}");
            Console.WriteLine($"bool: {isCSharpFun}");

            // The 'const' keyword creates a variable whose value cannot be changed.
            const double PI = 3.14159;
            Console.WriteLine($"constant: PI is always {PI}");
            // PI = 3.0; // This line would cause a compile-time error.
        }

        public static void DemonstrateTypeCastingAndConversion()
        {
            Console.WriteLine("\n--- 3. Type Casting and User Input ---");

            // Implicit Casting (safe, automatic) from a smaller to a larger type.
            int myInt = 10;
            double myDouble = myInt; // No data is lost.
            Console.WriteLine($"Implicit cast from int(10) to double: {myDouble}");

            // Explicit Casting (manual, may lose data) from a larger to a smaller type.
            double anotherDouble = 9.78;
            int anotherInt = (int)anotherDouble; // The .78 part is truncated (lost).
            Console.WriteLine($"Explicit cast from double(9.78) to int: {anotherInt}");

            // Reading user input and converting it.
            Console.WriteLine("\nEnter your age:");
            string input = Console.ReadLine(); // Console.ReadLine() always returns a string.
            // We must convert the string to a number to use it in calculations.
            int age = Convert.ToInt32(input);
            Console.WriteLine($"You will be {age + 1} on your next birthday.");
        }

        public static void DemonstrateOperators()
        {
            Console.WriteLine("\n--- 4. Operators ---");
            int x = 10;
            int y = 3;

            // Arithmetic: +, -, *, /, % (remainder)
            Console.WriteLine($"Arithmetic: {x} + {y} = {x + y}");
            Console.WriteLine($"            {x} / {y} = {x / y} (integer division truncates)");

            // Assignment: =, +=, -=, *=, /=
            x += 5; // Equivalent to x = x + 5;
            Console.WriteLine($"Assignment: x starts at 10, x += 5 results in {x}");

            // Comparison: ==, !=, >, <, >=, <= (results in a boolean)
            bool areEqual = (x == y);
            Console.WriteLine($"Comparison: Is {x} == {y}? {areEqual}");

            // Logical: && (AND), || (OR), ! (NOT)
            bool logicalResult = (x > 0 && y < 5);
            Console.WriteLine($"Logical: Is ({x} > 0 AND {y} < 5)? {logicalResult}");
        }

        #endregion

        #region Part 2: Program Flow and Logic

        public static void DemonstrateControlFlow()
        {
            Console.WriteLine("\n--- 5. Control Flow: If-Else and Switch ---");

            int time = 20;
            if (time < 12)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 18)
            {
                Console.WriteLine("Good afternoon.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            // Ternary Operator (a shorthand for if-else)
            string result = (time < 18) ? "It's still daytime." : "It's evening.";
            Console.WriteLine($"Ternary Operator: {result}");

            // Switch statement is a clean alternative to many if-else if checks.
            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
        }

        public static void DemonstrateLoops()
        {
            Console.WriteLine("\n--- 6. Loops: For, While, Foreach ---");

            // For loop: Executes a block of code a specified number of times.
            for (int i = 0; i < 3; i++)
            {
                if (i == 1) continue; // 'continue' skips the rest of this iteration and goes to the next.
                Console.WriteLine($"For loop iteration: {i}");
            }

            // While loop: Executes as long as a condition is true.
            int j = 0;
            while (j < 3)
            {
                if (j == 2) break; // 'break' exits the loop entirely.
                Console.WriteLine($"While loop iteration: {j}");
                j++;
            }

            // Foreach loop: The simplest way to iterate over all elements in a collection.
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"I like to eat {fruit}.");
            }
        }

        #endregion

        #region Part 3: Data Structures

        public static void DemonstrateArrays()
        {
            Console.WriteLine("\n--- 7. Arrays: Storing Collections ---");
            // An array holds a fixed-size list of elements of the same type.

            // One-dimensional array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine($"The first car is: {cars[0]}"); // Access by index (starts at 0)

            // Sorting an array
            Array.Sort(cars);
            Console.WriteLine($"Sorted cars: {string.Join(", ", cars)}");

            // Two-dimensional array (a grid)
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine($"Element at row 1, column 2 is: {numbers[1, 2]}");
        }

        public static void DemonstrateEnums()
        {
            Console.WriteLine("\n--- 8. Enums: Named Integer Constants ---");

            // An enum is a special type that represents a group of named constants.
            Level myLevel = Level.Medium;
            Console.WriteLine($"Current difficulty level is: {myLevel}");
        }

        // Enum definition
        enum Level { Low, Medium, High }

        #endregion

        #region Part 4: Building Blocks

        public static void DemonstrateMethods()
        {
            Console.WriteLine("\n--- 9. Methods: Reusable Code Blocks ---");

            // Method with no parameters
            GreetUser();

            // Method with parameters and a return value
            int sum = Add(5, 7);
            Console.WriteLine($"Result from Add method: {sum}");

            // Method Overloading: Same method name, different parameters.
            double doubleSum = Add(4.3, 6.26);
            Console.WriteLine($"Result from overloaded Add method: {doubleSum}");
        }

        // A simple method that takes no arguments and returns nothing (void).
        static void GreetUser()
        {
            Console.WriteLine("Hello from inside a method!");
        }

        // A method that takes two integers and returns an integer.
        static int Add(int x, int y)
        {
            return x + y;
        }

        // Overloaded method: Same name, but takes doubles instead of ints.
        static double Add(double x, double y)
        {
            return x + y;
        }

        #endregion

        #region Part 5: Object-Oriented Programming (OOP)

        public static void DemonstrateOOP()
        {
            Console.WriteLine("\n--- 10. Object-Oriented Programming (OOP) ---");

            // 1. Classes and Objects
            // A class is a blueprint. An object is an instance created from that blueprint.
            // We create a 'Car' object using its constructor.
            Console.WriteLine("\nCreating a Car object...");
            Car myCar = new Car("Ford", "Mustang", "Red");

            // 2. Properties and Access Modifiers
            // We can access its public properties.
            Console.WriteLine($"My car is a {myCar.Color} {myCar.Brand} {myCar.Model}.");

            // 3. Methods
            // We can call its methods.
            myCar.StartEngine();

            // 4. Inheritance
            // The Car object can call methods from its base class, 'Vehicle'.
            myCar.Honk();

            // 5. Polymorphism
            // We can treat a derived object (Car) as its base type (Vehicle).
            Console.WriteLine("\nDemonstrating Polymorphism...");
            Vehicle anotherVehicle = myCar;
            // The same method call has a different behavior depending on the object's actual type.
            anotherVehicle.DisplaySound(); // This will call the Car's overridden version.

            Vehicle genericVehicle = new Vehicle("Generic Brand");
            genericVehicle.DisplaySound(); // This will call the Vehicle's base version.

            // 6. Abstract Classes and Interfaces
            Console.WriteLine("\nDemonstrating Abstraction and Interfaces...");
            Pig myPig = new Pig();
            myPig.MakeSound(); // From abstract class
            myPig.Sleep();     // From abstract class
            myPig.Eat();       // From interface
        }
        #endregion
    }

    // --- OOP Class Definitions ---

    // Base class (Parent)
    public class Vehicle
    {
        // Public property with a getter. The setter is 'protected', meaning only this class
        // or its children (like Car) can change it.
        public string Brand { get; protected set; }

        // Constructor for the Vehicle class
        public Vehicle(string brand)
        {
            this.Brand = brand;
            Console.WriteLine("A Vehicle was constructed.");
        }

        public void Honk()
        {
            Console.WriteLine("Beep, beep!");
        }

        // A 'virtual' method can be overridden by derived classes.
        public virtual void DisplaySound()
        {
            Console.WriteLine("Vehicle makes a generic sound.");
        }
    }

    // Derived class (Child) - inherits from Vehicle
    public class Car : Vehicle
    {
        public string Model { get; set; }
        public string Color { get; set; }

        // Constructor for the Car class.
        // ': base(brand)' calls the constructor of the parent (Vehicle) class.
        public Car(string brand, string model, string color) : base(brand)
        {
            this.Model = model;
            this.Color = color;
            Console.WriteLine("A Car was constructed.");
        }

        // A method unique to the Car class
        public void StartEngine()
        {
            Console.WriteLine($"The {Model}'s engine is running.");
        }

        // 'override' provides a new implementation for a 'virtual' method from the base class.
        public override void DisplaySound()
        {
            Console.WriteLine("Car engine goes vroom vroom!");
        }
    }

    // An interface defines a "contract" of what a class can do. It only contains method signatures.
    public interface IFeedable
    {
        void Eat(); // No method body
    }

    // An abstract class cannot be instantiated. It's a blueprint for other classes.
    // It can contain both regular methods and abstract methods.
    public abstract class Animal
    {
        // An abstract method must be implemented by any non-abstract derived class.
        public abstract void MakeSound();

        // A regular method that gets inherited.
        public void Sleep()
        {
            Console.WriteLine("Zzz...");
        }
    }

    // This class inherits from the abstract Animal class AND implements the IFeedable interface.
    public class Pig : Animal, IFeedable
    {
        // We MUST provide an implementation for the abstract method.
        public override void MakeSound()
        {
            Console.WriteLine("The pig says: oink oink");
        }

        // We MUST provide an implementation for the interface method.
        public void Eat()
        {
            Console.WriteLine("The pig is eating.");
        }
    }
}
