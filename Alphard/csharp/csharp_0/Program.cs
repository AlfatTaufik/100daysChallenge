// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Alfat!");

string firstFriend = "     Maria";
string secondFriend = "Hania   ";
string status = "   Gfriend    ";
status = status.Trim();
secondFriend = secondFriend.TrimEnd();
firstFriend = firstFriend.TrimStart();    

Console.WriteLine($"I have two friends that is {firstFriend} and {secondFriend} and {secondFriend} is My {status}");