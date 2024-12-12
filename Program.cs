// See https://aka.ms/new-console-template for more information
using System;

class Animal
{
    // Private attributes
    private string Name;
    private string Breed;
    private int Age;

    // Constructor to initialize attributes
    public Animal(string name, string breed, int age)
    {
        Name = name;
        Breed = breed;
        Age = age;
    }

    // Setters
    public void SetName(string name)
    {
        Name = name;
    }

    public void SetBreed(string breed)
    {
        Breed = breed;
    }

    public void SetAge(int age)
    {
        Age = age;
    }

    // Getters
    public string GetName()
    {
        return Name;
    }

    public string GetBreed()
    {
        return Breed;
    }

    public int GetAge()
    {
        return Age;
    }

    // Bark method
    public virtual void Bark()
    {
        Console.WriteLine("Animal sound!");
    }
}

class Dog : Animal
{
    // Additional private attribute
    private string FavoriteToy;

    // Constructor to initialize attributes (including inherited ones)
    public Dog(string name, string breed, int age, string favoriteToy) : base(name, breed, age)
    {
        FavoriteToy = favoriteToy;
    }

    // Setter for FavoriteToy
    public void SetFavoriteToy(string favoriteToy)
    {
        FavoriteToy = favoriteToy;
    }

    // Getter for FavoriteToy
    public string GetFavoriteToy()
    {
        return FavoriteToy;
    }

    // Override Bark method
    public override void Bark()
    {
        Console.WriteLine($"{GetName()} says: Woof! Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Animal and set attributes
        Animal animal = new Animal("Generic Animal", "Unknown", 5);
        animal.SetName("Lion");
        animal.SetBreed("Wild");
        animal.SetAge(8);

        // Call Bark() for the Animal object
        animal.Bark();

        // Print attributes of the Animal object
        Console.WriteLine($"Animal Details: Name = {animal.GetName()}, Breed = {animal.GetBreed()}, Age = {animal.GetAge()}");

        // Create an instance of Dog and set attributes
        Dog dog = new Dog("Buddy", "Golden Retriever", 3, "Rubber Ball");
        dog.SetName("Charlie");
        dog.SetBreed("Labrador");
        dog.SetAge(4);
        dog.SetFavoriteToy("Tennis Ball");

        // Call Bark() for the Dog object
        dog.Bark();

        // Print attributes of the Dog object
        Console.WriteLine($"Dog Details: Name = {dog.GetName()}, Breed = {dog.GetBreed()}, Age = {dog.GetAge()}, Favorite Toy = {dog.GetFavoriteToy()}");
    }
}
