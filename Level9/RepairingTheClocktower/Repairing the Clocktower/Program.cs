using System;

Console.Write("Pick a number: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

if(inputNumber % 2 != 0)
{
    Console.WriteLine("Tock");
}
else
{
    Console.WriteLine("Tick");
}