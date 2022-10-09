using System;

int pilotNumber = -1;

do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    pilotNumber = Convert.ToInt32(Console.ReadLine());
}
while (pilotNumber < 0 || pilotNumber > 100);
Console.Clear();

int hunterNumber = -1;

do
{
    Console.Write("User 2, guess the number: ");
    hunterNumber = Convert.ToInt32(Console.ReadLine());

    if (hunterNumber < pilotNumber)
        Console.WriteLine($"{hunterNumber} is too low");
    else if (hunterNumber > pilotNumber)
        Console.WriteLine($"{hunterNumber} is too high");
    else
        Console.WriteLine("You guessed it!");
}
while (hunterNumber != pilotNumber);