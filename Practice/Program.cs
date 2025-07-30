// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int age = 21;
// float rating = 4.5f;
// double price = 19.99;
// char grade = 'A';
// bool isPass = true;

// Console.WriteLine($"Age: {age}");
// Console.WriteLine($"Rating: {rating}");         
// Console.WriteLine($"Price: {price}");
// Console.WriteLine($"Grade: {grade}");   
// Console.WriteLine($"Is Pass: {isPass}"); 

// int mark = 100;

// if (mark >= 90)
// {
//     Console.WriteLine("Grade: A");
// }
// else if (mark >= 80)
// {
//     Console.WriteLine("Grade: B");
// }
// else if (mark >= 70)
// {
//     Console.WriteLine("Grade: C");
// }
// else if (mark >= 60)
// {
//     Console.WriteLine("Grade: D");
// }
// else
// {
//     Console.WriteLine("Grade: F");
// }

// int day = 5;

// switch (day)
// {  
//    case 1:
//         Console.WriteLine("Monday");
//         break;
//     case 2:
//         Console.WriteLine("Tuesday");
//         break; 
//     default:Console.WriteLine("Another day");
//         break;
// }

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Number : " + i);
// }

// int a = 10;

// if (a % 2 == 0)
// {
//     Console.WriteLine("Even Number");
// }
// else
// {
//     Console.WriteLine("Odd Number");
// }

// int i = 0;
// while (i < 5)
// {
//     Console.WriteLine($"Number : " + i);
//     i++;
// }

// inheritance example
// using System;

// public class Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Animal is eating");
//     }
// }

// public class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("Dog is barking");
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Dog dog = new Dog();
//         dog.Eat(); // Inherited method
//         dog.Bark(); // Dog's own method
//     }
// }

// Polymorphism example
//  1. Method Overloading (Compile-Time Polymorphism)

// public class MathHelper
// {
//     public int Add(int a, int b) => a + b;
//     public double Add(double a, double b) => a + b;
//     public int Add(int a, int b, int c) => a + b + c; // Overloaded method with three parameters
// }
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         MathHelper math = new MathHelper();
//         Console.WriteLine(math.Add(5, 10)); // Calls Add(int, int)
//         Console.WriteLine(math.Add(5.5, 10.5)); // Calls Add(double, double)
//         Console.WriteLine(math.Add(1, 2, 3)); // Calls Add(int, int, int)
//     }
// }

// 2. Method Overriding (Run-Time Polymorphism)

// using System;

// public class Animal
// {
//     public virtual void Sound()
//     {
//         Console.WriteLine("Animal sound");
//     }
// }

// public class Cat : Animal
// {
//     public override void Sound()
//     {
//         Console.WriteLine("Meow");
//     }
// }

// public class Dog : Animal
// {
//     public override void Sound()
//     {
//         Console.WriteLine("Bark");
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Animal myCat = new Cat();
//         Animal myDog = new Dog();

//         myCat.Sound(); // Outputs: Meow
//         myDog.Sound(); // Outputs: Bark

//         // Demonstrating polymorphism with a method that takes an Animal parameter
//         MakeSound(myCat);
//         MakeSound(myDog);
//     }

//     public static void MakeSound(Animal animal)
//     {
//         animal.Sound(); // Calls the overridden method based on the actual object type
//     }
// }   

// Abstract Class Example

// public abstract class Vehicle
// {
//     public abstract void Start();
// }

// public class Bike : Vehicle
// {
//     public override void Start()
//     {
//         Console.WriteLine("Bike is starting");
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Vehicle v = new Bike();
//         v.Start();
//     }
// }

// Encapsulation Example

// public class Student
// {
//     private int age;

//     // setter method whith validation
//     public void SetAge(int a)
//     {
//         if (a >= 0)
//             age = a;
//         else
//             Console.WriteLine("Age cannot be negative");
//     }

//     public int GetAge()
//     {
//         return age;
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         Student s = new Student();
//         s.SetAge(20);
//         Console.WriteLine("Student Age: " + s.GetAge());

//         s.SetAge(-5); // Attempt to set a negative age
//         Console.WriteLine("Student Age after invalid input: " + s.GetAge());
//     }
// }