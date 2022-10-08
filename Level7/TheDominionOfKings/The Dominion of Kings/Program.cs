using System;

Console.WriteLine("How many provinces do you have?");
int provinceCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchies do you have?");
int duchiesCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many estates do you have?");
int estateCount = Convert.ToInt32(Console.ReadLine());

int points = 0;
points += provinceCount * 6;
points += duchiesCount * 3;
points += estateCount;

Console.WriteLine("Your kingdom is worth " + points + " points.");