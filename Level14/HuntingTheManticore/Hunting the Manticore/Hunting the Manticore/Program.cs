using System;

int manticoreHealth = 10;
int cityHealth = 15;

int currentRound = 0;

int pilotNumber = -1;

do
{
    Console.Write("Manticore pilot, it is your turn. Enter a number between 0 and 100: ");
    pilotNumber = Convert.ToInt32(Console.ReadLine());
}
while (pilotNumber < 0 || pilotNumber > 100);

Console.Clear();

int hunterNumber = -1;

do
{
    Console.WriteLine("-----------------------------------------------------------");

    currentRound += 1;

    Console.WriteLine($"Status - Round: {currentRound}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10");

    Console.Write("Defender, enter cannon range: ");
    hunterNumber = Convert.ToInt32(Console.ReadLine());

    if (hunterNumber < pilotNumber)
    {
        Console.WriteLine($"{hunterNumber} fell short. The manticore damages the city.");
        cityHealth -= 1;
    }
    else if (hunterNumber > pilotNumber)
    {
        cityHealth -= 1;
        Console.WriteLine($"{hunterNumber} overshot. The manticore damages the city.");
    }
    else
    {
        int cannonDamage = 0;
        if(currentRound % 3 == 0 && currentRound % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A firey electric storm rages into the manticore!  Huge damage!");
            cannonDamage = 10;
        }
        else if(currentRound % 3 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A fire cannon blast burns into the manticore!  It's hurt.");
            cannonDamage = 3;
        }
        else if(currentRound % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("An electrical shock cannons through the manticore! Good shot");
            cannonDamage = 3;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("A cannon shot strikes the manticore!  It's damaged.");
            cannonDamage = 1;
        }
        manticoreHealth -= cannonDamage;
    }

    Console.ForegroundColor = ConsoleColor.Gray;
}
while (cityHealth > 0 && manticoreHealth > 0);

if(cityHealth <= 0)
{
    Console.WriteLine("The city has fallen to the manticore. Game over.");
}
else if (manticoreHealth <= 0)
{
    Console.WriteLine("The manticore erupts in an explosion of metal and fire.  The city has been defended successfully.");
}