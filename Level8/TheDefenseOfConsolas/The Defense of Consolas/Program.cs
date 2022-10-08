using System;

Console.Title = "Defense of Consolas";
Console.Write("Target row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("Deploy to:");
Console.WriteLine($"({targetRow + 1},{targetColumn})");
Console.WriteLine($"({targetRow},{targetColumn + 1})");
Console.WriteLine($"({targetRow - 1},{targetColumn})");
Console.WriteLine($"({targetRow},{targetColumn - 1})");

Console.Beep();
Console.Beep();

Console.ForegroundColor = ConsoleColor.White;