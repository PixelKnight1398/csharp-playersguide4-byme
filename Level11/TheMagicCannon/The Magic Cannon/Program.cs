using System;

bool fireGemActive;
bool electricGemActive;

for (int i = 1; i <= 100; i++)
{
    fireGemActive = false;
    electricGemActive = false;

    fireGemActive = i % 3 == 0 ? true : false;
    electricGemActive = i % 5 == 0 ? true : false;

    if(fireGemActive && electricGemActive)
    {
        //combined
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}: Combined");
    }
    else if(fireGemActive && !electricGemActive)
    {
        //fire blast
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
    else if(!fireGemActive && electricGemActive)
    {
        //electric blast
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
    }
    else
    {
        //normal
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{i}: Normal");
    }
}