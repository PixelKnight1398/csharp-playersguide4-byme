using System;

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");

int itemSelection = Convert.ToInt32(Console.ReadLine());

int itemCost;
string itemName;

itemCost = itemSelection switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};

itemName = itemSelection switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => "Invalid Item"
};

if (itemName == "Invalid Item")
{
    Console.WriteLine("Invalid item selected");
}
else
{
    Console.WriteLine($"{itemName} costs {itemCost} gold.");

    Console.WriteLine("Tortuga laughs, \"Thank you for saving me shop! You've done me a grand favor, allow me to discount something for you!\"");

    Console.WriteLine("\"By the way, what's your name?\", he asks with a cocked eyebrow");
    string playerName = Console.ReadLine();

    Console.Clear();

    Console.WriteLine("The following items are available:");
    Console.WriteLine("1 - Rope");
    Console.WriteLine("2 - Torches");
    Console.WriteLine("3 - Climbing Equipment");
    Console.WriteLine("4 - Clean Water");
    Console.WriteLine("5 - Machete");
    Console.WriteLine("6 - Canoe");
    Console.WriteLine("7 - Food Supplies");
    Console.Write("What number do you want to see the price of? ");

    itemSelection = Convert.ToInt32(Console.ReadLine());

    itemCost = itemSelection switch
    {
        1 => 10,
        2 => 15,
        3 => 25,
        4 => 1,
        5 => 20,
        6 => 200,
        7 => 1,
        _ => 0
    };

    if (playerName == "Dorian")
        itemCost /= 2;

    itemName = itemSelection switch
    {
        1 => "Rope",
        2 => "Torches",
        3 => "Climbing Equipment",
        4 => "Clean Water",
        5 => "Machete",
        6 => "Canoe",
        7 => "Food Supplies",
        _ => "Invalid Item"
    };

    if (itemName == "Invalid Item")
    {
        Console.WriteLine("Invalid item selected");
    }
    else
    {
        Console.WriteLine($"{itemName} costs {itemCost} gold.");
    }
}