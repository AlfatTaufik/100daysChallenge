List<int> numbers = [12, 312, 42, 5, 643, 7];

IEnumerable<int> greatGrade =
    from number in numbers
    where number > 8
    select number;

foreach (int i in greatGrade)
{
    Console.WriteLine($"{i} is greater than 8");
}

List<string> names = ["Bambang", "Susilo", "Yudhoyono", "Joko"];

IEnumerable<string> susilo =
    from name in names
    where name == "Susilo"
    select name;

foreach (var item in susilo)
{
    Console.WriteLine($"{item.ToLower()}");
}