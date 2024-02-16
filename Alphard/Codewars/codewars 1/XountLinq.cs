var names = new List<string> { "Jonathan", "Liandi", "Pangestu" };

names.Sort();
Console.WriteLine(names.IndexOf("Liandi"));
// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

var numbers = new List<int> {444,24,42,1,09,324};
Console.WriteLine(numbers.IndexOf(09));
numbers.Sort();
Console.WriteLine(numbers.IndexOf(09));