//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villians = { "Voldemort", "Darthhero Vader", "Dracula", "Jokker", "Sauron" };

string folderPath = @"C:\Data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

string[] weapon = { " magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" };
string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainsWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainsWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{ Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}
