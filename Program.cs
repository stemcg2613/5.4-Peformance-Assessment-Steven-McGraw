/*******************************************************************
* Name: Steven McGraw
* Date: 2026-04-05
* Assignment: SDC220 Performance Assessment - Inheritance & Overriding
*
* Main application (program) class.
* This application demonstrates inheritance and overriding by creating
* Animal and Cat objects, printing their properties, updating them,
* and printing again.
*/
public class App
{
    static void Main(string[] args)
    {
        // Print header line
        Console.WriteLine("Steven McGraw - Week 5 PA Inheritance & Overriding");

        // Create instances of each class
        Animal a = new Animal("Roo", 2);
        Cat c = new Cat("Fluffy", 4, "meow");

        // Print each object's properties
        a.PrintAnimal();
        c.PrintAnimal();

        // Update properties to different values
        a.Name = "Flipper";
        a.Legs = 0;
        c.Name = "Garfield";
        c.Legs = 4;
        c.Sound = "I'm HUNGRY";

        // Print each object's properties again
        a.PrintAnimal();
        c.PrintAnimal();
    }
}