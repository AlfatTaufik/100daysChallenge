#nullable enable

using System.Collections.Generic;

var fooList = new List<FooBar>
{
    new(Id: 1, Name: "Foo"),
    new(Id: 2, Name: "Bar")
};

FooBar fooBar = fooList.Find(f => f.Name == "Bar")!;

// The FooBar type definition for example.
record FooBar(int Id, string Name);