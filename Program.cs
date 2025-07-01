// 1. Syntax of printing Hello World in C#
    // Method 1: Traditional Console.WriteLine
using System;

namespace Print
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1: Using Console.WriteLine
            Console.WriteLine("Hello World!");
        }
    }
}

    // Method 2: Using string interpolation
// System.Console.WriteLine("Hello World!");

// 2. Variable and Data Types: int, double, char, string, bool
int number = 42; // Integer variable
double pi = 3.14; // Double variable
char letter = 'A'; // Character variable
string message = "Hello, C#"; // String variable
bool isTrue = true; // Boolean variable

// 3. Constant: If you don't want to change the value of a variable, you can use a constant.
const int myNum = 15;
myNum = 20; // error

// 4. Display variables and constants
string name = "John";
Console.WriteLine("Hello " + name); // Output: Hello John

int x = 5;
int y = 6;
Console.WriteLine(x + y); // Print the value of x + y, i.e., 11

// 5. In C#, there are two types of casting:
    // Implicit Casting(automatically) -converting a smaller type to a larger type size
    // char -> int -> long -> float -> double

    // Explicit Casting (manually) - converting a larger type to a smaller size type
    // double -> float -> long -> int -> char

    // Implicit Casting Example
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9

    // Explicit Casting Example
double myDouble = 9.78;
int myInt = ***(int)*** myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9

// 6. Reading user input
Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine()); // Input: 100
Console.WriteLine("Your age is: " + age); // Output: Your age is: 100

// 7. Arithmetic Operators: +, -, *, /, %, ++, --
Console.WriteLine("Arithmetic Operators:");
Console.WriteLine("Addition: " + (5 + 3)); // Output: 8
Console.WriteLine("Subtraction: " + (5 - 3)); // Output: 2
Console.WriteLine("Multiplication: " + (5 * 3)); // Output: 15
Console.WriteLine("Division: " + (5 / 3)); // Output: 1 (integer division)
Console.WriteLine("Modulus: " + (5 % 3)); // Output: 2 (remainder)
Console.WriteLine("Increment: " + (2++)); // Ouputt: 3 (post-increment)
Console.WriteLine("Decrement: " + (2--)); // Output: 1 (post-decrement)

// 8. Assignment Operators: =, +=, -=, *=, /=, %=, &=, |=, ^=, <<=, >>=
Console.WriteLine("Assignment Operators:");
Console.WriteLine("x = 5: " + (x = 5)); // Output: 5
Console.WriteLine("x += 3: " + (x += 3)); // Output: 8
Console.WriteLine("x -= 2: " + (x -= 2)); // Output: 6
Console.WriteLine("x *= 2: " + (x *= 2)); // Output: 12
Console.WriteLine("x /= 3: " + (x /= 3)); // Output: 4
Console.WriteLine("x %= 2: " + (x %= 2)); // Output: 0
Console.WriteLine("x &= 1: " + (x &= 1)); // Output: 0  This is a bitwise AND operation, 0 & 1 = 0
Console.WriteLine("x |= 1: " + (x |= 1)); // Output: 1  This is a bitwise OR operation, 0 | 1 = 1
Console.WriteLine("x ^= 1: " + (x ^= 1)); // Output: 0  This is a bitwise XOR operation, 1 ^ 1 = 0
Console.WriteLine("x <<= 1: " + (x <<= 1)); // Output: 0  This is a left shift operation, 0 << 1 = 0
Console.WriteLine("x >>= 1: " + (x >>= 1)); // Output: 0  This is a right shift operation, 0 >> 1 = 0

// 9. Comparison Operators: ==, !=, >, <, >=, <=
Console.WriteLine("Comparison Operators:");
Console.WriteLine("5 == 5: " + (5 == 5)); // Output: True
Console.WriteLine("5 != 3: " + (5 != 3)); // Output: True
Console.WriteLine("5 > 3: " + (5 > 3)); // Output: True
Console.WriteLine("5 < 3: " + (5 < 3)); // Output: False
Console.WriteLine("5 >= 5: " + (5 >= 5)); // Output: True
Console.WriteLine("5 <= 3: " + (5 <= 3)); // Output: False

// 10. Logical Operators: &&, ||, !
int x = 3;
Console.WriteLine("Logical Operators:");
Console.WriteLine("true && false: " + (x < 5 && x < 10)); // Output: True
Console.WriteLine("true || false: " + (x < 5 || x < 4)); // Output: True
Console.WriteLine("!true: " + （!(x < 5 && x < 10))); // Output: False

// 11. If-Else Statements
using System;

namespace Test
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            int age = 17;
            int legalAge = 18;

            if (age < legalAge)
            {
                Console.WriteLine("Younger than 18 years old.");
            }
            else if (age = legalAge)
            {
                Console.WriteLine("Same age as 18 years old.");
            }
            else
            {
                Console.WriteLine("Older than 18 years old.");
            }
        }
    }
}

    // Shortened version of the above code
int age = 17;
string message = age < 18 ? "Younger than 18 years old." : age == 18 ? "Same age as 18 years old." : "Older than 18 years old.";

// 12. Switch Statements, While Loops, For Loops, Do-While Loops, Foreach Loops
int day = 3;
string dayName;
    // Switch statement
switch (day)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    case 3:
        dayName = "Wednesday";
        break;
    default:
        dayName = "Unknown";
        break;
}
Console.WriteLine("Today is: " + dayName);

    // While loop
int i = 0;
while (i < 5)
{
    Console.WriteLine("While Loop: " + i);
    i++;
}

    // For loop
for (int j = 0; j < 5; j++)
{
    Console.WriteLine("For Loop: " + j);
}

    // Do-While loop: The loop will execute at least once, even if the condition is false, because the condition is checked after the loop body.
int k = 0;
do
{
    Console.WriteLine("Do-While Loop: " + k);
    k++;
} while (k < 5);

    // Foreach loop
string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (string fruit in fruits)
{
    Console.WriteLine("Foreach Loop: " + fruit); // Output: Apple, Banana, Cherry
}

// 13. Continue and Break Statements
    // Continue statement: Skips the current iteration and continues with the next iteration
for (int i = 0; i < 5; i++)
{
    if (i == 2)
    {
        continue; // Skip the iteration when i is 2
    }
    Console.WriteLine("Continue Example: " + i); // Output: 0, 1, 3, 4
}
    // Break statement: Exits the loop entirely
for (int j = 0; j < 5; j++)
{
    if (j == 3)
    {
        break; // Exit the loop when j is 3
    }
    Console.WriteLine("Break Example: " + j); // Output: 0, 1, 2

// 14. Arrays
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Console.WriteLine(cars[0]); // Outputs Volvo

int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
Console.WriteLine(numbers[0, 2]);  // Outputs 2

// 15. Sorting Arrays
    // Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
    {
        Console.WriteLine(i);
    }

// 16. Methods
    // Method 1
static void MyMethod()
    {
        Console.WriteLine("I just got executed!");
    }

static void Main(string[] args)
    {
        MyMethod(); // Outputs "I just got executed!"
    }

    // Method 2
static void MyMethod(string fname, int age)
{
    Console.WriteLine(fname + " is " + age);
}

static void Main(string[] args)
{
    MyMethod("Liam", 5);
    MyMethod("Jenny", 8);
    MyMethod("Anja", 31);
}

// Liam is 5
// Jenny is 8
// Anja is 31

// 17. Method Overloading
static int PlusMethod(int x, int y)
{
    return x + y;
}

static double PlusMethod(double x, double y)
{
    return x + y;
}

static void Main(string[] args)
{
      int myNum1 = PlusMethod(8, 5);
      double myNum2 = PlusMethod(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
}

// 18. Objects and Classes
class Car
{
    string color = "red";

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine(myObj.color);
    }
}

// 19. Object method
class Car
{
    string color;                 // field
    int maxSpeed;                 // field
    public void fullThrottle()    // method
    {
        Console.WriteLine("The car is going as fast as it can!");
    }

    static void Main(string[] args)
    {
        Car myObj = new Car();
        myObj.fullThrottle();  // Can only be called after creating an object of the class
    }
}

// 20. Constructors
class Car
{
    public string model;

    // Create a class constructor with a parameter
    public Car(string modelName)
    {
        model = modelName;
    }

    static void Main(string[] args)
    {
        Car Ford = new Car("Mustang");
        Console.WriteLine(Ford.model); // Outputs "Mustang"
    }
}

// 21. Access Modifiers
/*
public	    The code is accessible for all classes
private	    The code is only accessible within the same class
protected	The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
internal	The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
 */

// 22. Properties
class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}

// 23. Inheritance
class Vehicle  // base class (parent), if you don't want other classes to inherit from a class, use the sealed keyword (sealed class Vehicle)
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}

class Program
{
    static void Main(string[] args)
    {
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}

// 24. Polymorphism
class Animal  // Base class (parent) 
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Dog : Animal  // Derived class (child) 
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object

        myAnimal.animalSound(); // The animal makes a sound
        myPig.animalSound(); // The pig says: wee wee
        myDog.animalSound(); // The dog says: bow wow
    }
}

// 25. Abstract Classes and Methods
// Abstract class
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // Create a Pig object
        myPig.animalSound();  // Call the abstract method
        myPig.sleep();  // Call the regular method
    }
}

// 26. Interfaces
// Interface
interface IAnimal
{
    void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();  // Create a Pig object
        myPig.animalSound();
    }
}

// 27. Enums
enum Level
{
    Low,
    Medium,
    High
}
class Program
{
    static void Main(string[] args)
    {
        Level myVar = Level.Medium;
        Console.WriteLine(myVar); // Output: Medium
    }
}
