int shaftInputValue;
Arrowhead arrowheadInputValue;
Fletching fletchingInputValue;

void BuildArrow()
{
    Console.WriteLine("We need to build an arrow.");
    shaftInputValue = GetShaftInput();
    arrowheadInputValue = GetArrowheadInput();
    fletchingInputValue = GetFletchingInput();

    Arrow arrowBuild = new Arrow(shaftInputValue, arrowheadInputValue, fletchingInputValue);
    Console.WriteLine($"This arrow will cost: {arrowBuild.GetCost()} gold");
}

BuildArrow();

int GetShaftInput()
{
    Console.WriteLine("How long is the shaft? (60-100)cm");
    return Convert.ToInt32(Console.ReadLine());
}

Arrowhead GetArrowheadInput()
{
    Console.WriteLine("For the arrowhead, does it need steel, wood, or obsidian?");
    string arrowheadInput = Console.ReadLine();
    return arrowheadInput switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian,
    };
}

Fletching GetFletchingInput()
{
    Console.WriteLine("What kind of fletching does it need? Plastic, turkey (feather), or goose (feather)?");
    string fletchingInput = Console.ReadLine();
    return fletchingInput switch
    {
        "plastic" => Fletching.Plastic,
        "turkey" => Fletching.Turkey,
        "goose" => Fletching.Goose,
    };
}

public class Arrow
{
    private int _shaftLength;
    private Arrowhead _arrowheadType;
    private Fletching _fletchingType;

    public Arrow(int shaftLength, Arrowhead arrowheadType, Fletching fletchingType)
    {
        _shaftLength = shaftLength;
        _arrowheadType = arrowheadType;
        _fletchingType = fletchingType;
    }

    public float GetCost()
    {
        float finalCost = 0;

        finalCost += GetShaftCost();
        finalCost += GetArrowheadCost();
        finalCost += GetFletchingCost();

        return finalCost;
    }

    public int GetArrowheadCost()
    {
        return _arrowheadType switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5,
            _ => 0,
        };
    }

    public int GetFletchingCost()
    {
        return _fletchingType switch
        {
            Fletching.Plastic => 10,
            Fletching.Turkey => 5,
            Fletching.Goose => 3,
            _ => 0,
        };
    }

    public float GetShaftCost()
    {
        return 0.05f * _shaftLength;
    }
}

public enum Fletching { Plastic, Turkey, Goose }
public enum Arrowhead { Steel, Wood, Obsidian }