using System;

public class Dog
{
    // properties
    public string Name;
    public int Age;

    // constructor
    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // methods
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking");
    }

    public void HaveBirthday()
    {
        Age++;
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog("Max", 5);

        d.Bark();
        d.HaveBirthday();

        Console.WriteLine(d.Age);
    }
}