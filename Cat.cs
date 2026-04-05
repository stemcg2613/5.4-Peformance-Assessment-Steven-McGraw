/*******************************************************************
* Name: Steven McGraw
* Date: 2026-04-05
* Assignment: SDC220 Performance Assessment - Inheritance & Overriding
*
* Cat class.
* This is the derived class that represents a Cat. It inherits from
* Animal and adds a Sound property. The printAnimal function is
* overridden to include the cat's sound in the output.
*/
public class Cat : Animal
{
    // Additional property
    public string Sound { get; set; }

    // Constructor
    public Cat(string name, int legs, string sound) : base(name, legs)
    {
        Sound = sound;
    }

    // Override printAnimal to include the Cat's sound
    public override void PrintAnimal()
    {
        Console.WriteLine("The Cat's name is {0}, it has {1} legs and is making a {2} sound.",
            Name, Legs, Sound);
    }
}
