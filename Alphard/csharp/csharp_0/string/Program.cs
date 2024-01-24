// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Alfat!");

string firstFriend = "     Maria";
string secondFriend = "Hania   ";
string status = "   Gfriend    ";
status = status.Trim();
secondFriend = secondFriend.TrimEnd();
firstFriend = firstFriend.TrimStart();    
string friends = $"I have two friends that is {firstFriend} and {secondFriend} and {secondFriend} is My {status}";

// Ini gaakan create new instance dan value default masih maria
Console.WriteLine(friends.Replace("Maria", "Ikhsan"));
// Create new instance
friends = friends.Replace("Maria", "Ikhsan");
Console.WriteLine($"{friends}");

string apakah = friends.Contains("Ikhsan") ? "Yes" : "No";
string pacar = friends.Contains("Hania") ? "yes" : "No";
Console.WriteLine($"ada ikhsan {apakah} ada Hania {pacar}");
Console.WriteLine($"{secondFriend.ToUpper()} {firstFriend.ToLower()}");
Console.WriteLine($"Jumlah huruf {secondFriend.Length}");
// Cek true and false significant white space

Console.WriteLine($"{firstFriend.StartsWith("Ma")}");
