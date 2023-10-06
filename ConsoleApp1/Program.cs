using Namespace;
Console.WriteLine("Welcome to the Tamagotchi");

Tamagotchi caly = new Tamagotchi();

Console.WriteLine ("Choose a new name for your Tamagotchi");

caly.name = Console.Readline();

Console.WriteLine($"{caly.name} is a good name!");

