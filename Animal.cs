/*******************************************************************
* Name: Steven McGraw
* Date: 2026-04-05
* Assignment: SDC220 Performance Assessment - Inheritance & Overriding
*
* Animal class.
* This is the base class that represents a generic Animal. It contains
* the animal's name and number of legs, and a printAnimal function
* that prints the animal's properties to the console.
*/
public class Animal
{
    // Properties
    public string Name { get; set; }
    public int Legs { get; set; }

    // Constructor
    public Animal(string name, int legs)
    {
        Name = name;
        Legs = legs;
    }

    // Print the Animal's properties
    public virtual void PrintAnimal()
    {
        Console.WriteLine("The Animal's name is {0} and it has {1} legs.", Name, Legs);
    }
}
