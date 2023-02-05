﻿void Main()
{
    Point p1 = new Point(2, 3);
    Point p2 = new Point(-4, 0);

    Console.WriteLine($"({p1.X}, {p1.Y})");
    Console.WriteLine($"({p2.X}, {p2.Y})");
}

Main();

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point() : this(0, 0)
    { }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}