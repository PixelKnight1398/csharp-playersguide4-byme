void Main()
{
    Pack backpack = new Pack(20, 20f, 20);

    while (true)
    {
        Console.WriteLine($"Pack weight: {backpack.CurrentWeight} - Pack volume: {backpack.CurrentVolume}");

        Console.WriteLine("Which item do you want to add to the pack?");
        Console.WriteLine("1 - Arrow");
        Console.WriteLine("2 - Bow");
        Console.WriteLine("3 - Rope");
        Console.WriteLine("4 - Water");
        Console.WriteLine("5 - Food Rations");
        Console.WriteLine("6 - Sword");

        int playerInput = Int32.Parse(Console.ReadLine());

        InventoryItem addedItem = playerInput switch
        {
            1 => new Arrow(),
            2 => new Bow(),
            3 => new Rope(),
            4 => new Water(),
            5 => new Food(),
            6 => new Sword(),
        };

        if (backpack.Add(addedItem))
            Console.WriteLine("Item added successfully");
        else
            Console.WriteLine("Pack is too full for that item");

        Console.WriteLine($"New pack weight: {backpack.CurrentWeight} - New pack volume: {backpack.CurrentVolume}");
        Console.WriteLine(backpack.ToString());
    }
}

Main();

class Pack
{
    public InventoryItem[] Items { get; set; }
    public float CurrentWeight { get; set; }
    public float MaximumWeight { get; set; }
    public float CurrentVolume { get; set; }
    public float MaximumVolume { get; set; }

    public Pack(int itemCapacity, float maximumWeight, float maximumVolume)
    {
        Items = new InventoryItem[itemCapacity];
        MaximumWeight = maximumWeight;
        MaximumVolume = maximumVolume;
    }

    public bool Add(InventoryItem item)
    {
        RecalculatePackInfo();

        if ((CurrentWeight + item.Weight) > MaximumWeight || (CurrentVolume + item.Volume) > MaximumVolume)
            return false;
        else
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i] == null)
                {
                    Items[i] = item;
                    break;
                }
            }
            return true;
        }
    }

    public void RecalculatePackInfo()
    {
        CurrentWeight = 0;
        CurrentVolume = 0;

        foreach (InventoryItem zItem in Items)
        {
            if (zItem != null)
            {
                CurrentWeight += zItem.Weight;
                CurrentVolume += zItem.Volume;
            }
        }
    }

    public override string ToString()
    {
        string objectString = "Pack contains:\n";

        foreach(InventoryItem zItem in Items)
        {
            if(zItem != null)
                objectString += $"\t-{zItem.ToString()}\n";
        }

        return objectString;
    }
}

class InventoryItem
{
    public float Weight { get; set; }
    public float Volume { get; set; }

    public InventoryItem(float itemWeight, float itemVolume)
    {
        Weight = itemWeight;
        Volume = itemVolume;
    }
}

class Arrow : InventoryItem
{
    public Arrow() : base(0.1f, 0.05f) { }

    public override string ToString()
    {
        return "Arrow";
    }
}

class Bow : InventoryItem
{
    public Bow() : base(1f, 4f) { }

    public override string ToString()
    {
        return "Bow";
    }
}

class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f) { }

    public override string ToString()
    {
        return "Rope";
    }
}

class Water : InventoryItem
{
    public Water() : base(2f, 3f) { }

    public override string ToString()
    {
        return "Water";
    }
}
class Food : InventoryItem
{
    public Food() : base(1f, 0.5f) { }

    public override string ToString()
    {
        return "Food";
    }
}
class Sword : InventoryItem
{
    public Sword() : base(5f, 3f) { }

    public override string ToString()
    {
        return "Sword";
    }
}