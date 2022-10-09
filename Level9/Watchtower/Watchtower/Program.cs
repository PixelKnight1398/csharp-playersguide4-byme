using System;

Console.Write("What degree is the enemy from west to east? (-180 to 180) - ");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("What degree is the enemy from south to north? (-180 to 180) - ");
int yCoord = Convert.ToInt32(Console.ReadLine());

if(xCoord < 0)
{
    if(yCoord < 0)
    {
        Console.WriteLine("Enemy is to the Northwest!");
    }
    else if (yCoord == 0)
    {
        Console.WriteLine("Enemy is to the West!");
    }
    else if (yCoord > 0)
    {
        Console.WriteLine("Enemy is to the Southwest!");
    }
}
else if (xCoord == 0)
{
    if (yCoord < 0)
    {
        Console.WriteLine("Enemy is to the North!");
    }
    else if (yCoord == 0)
    {
        Console.WriteLine("Enemy is here!");
    }
    else if (yCoord > 0)
    {
        Console.WriteLine("Enemy is to the South!");
    }
}
else if (xCoord > 0)
{
    if (yCoord < 0)
    {
        Console.WriteLine("Enemy is to the Northeast!");
    }
    else if (yCoord == 0)
    {
        Console.WriteLine("Enemy is to the East!");
    }
    else if (yCoord > 0)
    {
        Console.WriteLine("Enemy is to the Southeast!");
    }
}