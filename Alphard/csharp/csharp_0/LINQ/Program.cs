List<int> numbers = [12, 312, 42, 5, 643, 7];

IEnumerable<string> lessThan = 
    from number in numbers
    where number < 100
    orderby number descending
    select $"The number that less than 80 is {number}";

int count = lessThan.Count();
    foreach (string item in lessThan)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine(count);

List<string> names = ["Bambang", "Susilo", "Yudhoyono", "Joko"];

IEnumerable<string> susilo =
    from name in names
    where name == "Susilo"
    select name;


foreach (var item in susilo)
{
    Console.WriteLine($"{item.ToLower()}");
}

