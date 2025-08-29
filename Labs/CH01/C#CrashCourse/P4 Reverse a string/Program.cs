string name = "Evan";

for (int i = name.Length-1; i >= 0; i--)
{
    Console.WriteLine(name[i]);
}

// starting i at 3 (since it goes 0,1,2,3 for locations) and then getting the letters based off the index location and incrementing down in a for loop