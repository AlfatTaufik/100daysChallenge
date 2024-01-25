

public abstract class Vehicle(string type)
{
    public string type { get; } = type;

    public abstract string Sound();

    public override string ToString()
    {
        return $"My vehicle are {GetType().Name} im gonna make sound like {Sound()}";
    }
}


public class Human(string name, int Age)
{
    public string name { get; } = name;
    public int age {get;} = Age;

    List<Vehicle> vehicle = new();

    // public override string ToString
    public override string ToString()
    {
        return $"Bello my name is {name} i am a {age} YO";
    }
}


public class Motor(string type) : Vehicle(type)
{
    public override string Sound() => "brenggg";
}

public class Car(string type) : Vehicle(type)
{
    public override string Sound() => "mbrummm";
}

public class Plane(string type) : Vehicle(type)
{
    public override string Sound() => "Whusshhh";
}