using System;

void BuildArrow()
{
    Console.WriteLine("We need to build an arrow.");
    Console.WriteLine("What arrow do you want?");
    Console.WriteLine("1 - Elite Arrow");
    Console.WriteLine("2 - Beginner Arrow");
    Console.WriteLine("3 - Marksman Arrow");
    Console.WriteLine("4 - Custom Arrow");

    string arrowTypeSelection = Console.ReadLine();
    Arrow buildSelection = arrowTypeSelection switch
    {
        "1" => Arrow.CreateEliteArrow(),
        "2" => Arrow.CreateBeginnerArrow(),
        "3" => Arrow.CreateMarksmanArrow(),
        _ => CustomArrow()
    };

    Console.WriteLine($"This arrow will cost: {buildSelection.TotalCost} gold");
}

Arrow CustomArrow()
{
    Arrow arrowBuild = new Arrow();
    arrowBuild.GetShaftInput();
    arrowBuild.GetArrowheadInput();
    arrowBuild.GetFletchingInput();
    return arrowBuild;
}

BuildArrow();

public class Arrow
{
    public int ShaftLength { get; set; }
    public Arrowhead ArrowheadType { get; set; }
    public Fletching FletchingType { get; set; }

    public float ShaftCost
    {
        get => 0.05f * ShaftLength;
    }
    public int ArrowheadCost
    {
        get
        {
            return ArrowheadType switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5,
                _ => 0,
            };
        }
    }
    public int FletchingCost
    {
        get
        {
            return FletchingType switch
            {
                Fletching.Plastic => 10,
                Fletching.Turkey => 5,
                Fletching.Goose => 3,
                _ => 0,
            };
        }
    }
    public float TotalCost
    {
        get
        {
            return ShaftCost + ArrowheadCost + FletchingCost;
        }
    }

    public Arrow() : this(60, Arrowhead.Wood, Fletching.Goose)
    {
    }

    public Arrow(int shaftLength, Arrowhead arrowheadType, Fletching fletchingType)
    {
        ShaftLength = shaftLength;
        ArrowheadType = arrowheadType;
        FletchingType = fletchingType;
    }

    public int GetShaftInput()
    {
        Console.WriteLine("How long is the shaft? (60-100)cm");
        return ShaftLength = Convert.ToInt32(Console.ReadLine());
    }

    public Arrowhead GetArrowheadInput()
    {
        Console.WriteLine("For the arrowhead, does it need steel, wood, or obsidian?");
        string arrowheadInput = Console.ReadLine();
        return ArrowheadType = arrowheadInput switch
        {
            "steel" => Arrowhead.Steel,
            "wood" => Arrowhead.Wood,
            "obsidian" => Arrowhead.Obsidian,
        };
    }

    public Fletching GetFletchingInput()
    {
        Console.WriteLine("What kind of fletching does it need? Plastic, turkey (feather), or goose (feather)?");
        string fletchingInput = Console.ReadLine();
        return FletchingType = fletchingInput switch
        {
            "plastic" => Fletching.Plastic,
            "turkey" => Fletching.Turkey,
            "goose" => Fletching.Goose,
        };
    }

    public static Arrow CreateEliteArrow() => new Arrow(95, Arrowhead.Steel, Fletching.Plastic);
    public static Arrow CreateBeginnerArrow() => new Arrow(75, Arrowhead.Wood, Fletching.Goose);
    public static Arrow CreateMarksmanArrow() => new Arrow(65, Arrowhead.Steel, Fletching.Goose);
}

public enum Fletching { Plastic, Turkey, Goose }
public enum Arrowhead { Steel, Wood, Obsidian }