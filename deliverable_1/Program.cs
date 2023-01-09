using System;



bool runProgram = true;

while (runProgram == true)
{
    Console.WriteLine("How many people are we making PB&J sandwiches for?");
    int people = int.Parse(Console.ReadLine());

    int breadSlices = people * 2;
    Console.WriteLine("You need  slices of bread" + breadSlices);

    int jellyTeaspoons = people * 4;
    Console.WriteLine("You need  teaspoons of jelly" + jellyTeaspoons);

    int peanutbutterTablespoons = people * 2;
    Console.WriteLine("You Need  tablespoons os peanutbutter" + peanutbutterTablespoons);

    double loafBread = breadSlices / 28;
    Console.WriteLine("Which is  loaves of bread" + loafBread);

    double jarJ = jellyTeaspoons / 48;
    Console.WriteLine("Which is  jars of jelly" + jarJ);

    double jarPB = peanutbutterTablespoons / 32;
    Console.WriteLine("Which is  jars of peanutbutter" + jarPB);

    Console.WriteLine("Would you like to start over?");
    string choice = Console.ReadLine();

    if (choice == "yes" || choice == "y")
    {
        
    }
    else
    {
        runProgram = false;
    }


}

