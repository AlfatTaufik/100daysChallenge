Console.WriteLine("Hello OOP");

var p1 = new Person("Alfat", "Taufik", new DateOnly(2006, 10, 26));
var p2 = new Person("Hania", "Maharani", new DateOnly(2007,8,12));

p1.Pets.Add(new Dog("Frezzy"));
p2.Pets.Add(new Cat("Fanny"));

List<Person> people = [p1,p2];
foreach (var person in people)
{
    Console.WriteLine(person);
    foreach (var pet in person.Pets)
    {
        Console.WriteLine(pet);
    }    
}


// IEnumerable<Person> listOfPeople = 
//     from person in people
//     select person;

Console.WriteLine($"The number of people is {people.Count}");

public abstract class Pets(string firstname)
{
    public string First {get;} = firstname;

    public abstract string ANoise();

    // public override Pets()
    public override string ToString()
    {
        return $"{First} Iam a {GetType().Name} and I make sounds like {ANoise()}";
    }
}
public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get;} = firstname;
    public string Last { get; } = lastname;
    public DateOnly Birth { get;} = birthday;

    public List<Pets> Pets {get;} = new();

    public override string ToString()
    {
        return $"Hi My name is {First}{Last} My pet";
    }
}

public class Cat(string firstname) : Pets(firstname)
{
    // public string First {get;} = firstname;

    public override string ANoise() => "Meowww";
}

public class Dog(string firstname) : Pets(firstname)
{
    // public string First {get;} = firstn  ame;
    public override string ANoise() => "BarkBarkBark"; 
}
