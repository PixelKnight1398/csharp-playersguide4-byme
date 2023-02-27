void Main()
{
    ColoredItem<Sword> blueSword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
    blueSword.Display();
    ColoredItem<Bow> redBow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
    redBow.Display();
    ColoredItem<Axe> greenAxe = new ColoredItem<Axe> (new Axe(), ConsoleColor.Green);
    greenAxe.Display();
}

Main();

public class ColoredItem<T> where T : class
{
    T Item { get; set; }
    ConsoleColor Color { get; set; }

    public ColoredItem(T item, ConsoleColor color)
    {
        Item = item;
        Color = color;
    }

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item.ToString());
    }
}

public class Sword { }
public class Bow { }
public class Axe { }