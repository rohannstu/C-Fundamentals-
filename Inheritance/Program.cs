class Animal
{
    public virtual void Speak()
    {
        System.Console.WriteLine("The animal makes a sound.");
    }
    public virtual void Flying () 
    {
        System.Console.WriteLine("The animal is flying.");
    }
}

class Penguin : Animal
{
    public override void Speak()
    {
        System.Console.WriteLine("The penguin makes a sound.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.Speak(); // Output: The animal makes a sound.
        myAnimal.Flying(); // Output: The animal is flying.

        Penguin myPenguin = new Penguin();
        myPenguin.Speak(); // Output: The penguin makes a sound.
        myPenguin.Flying(); // Output: The animal is flying.
    }
}