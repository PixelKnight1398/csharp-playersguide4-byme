using System.Data;

void Main()
{
    Coordinate[] coordinateArray = new Coordinate[10];
    Random random = new Random();
    for(int i = 0; i < coordinateArray.Length; i++)
    {
        coordinateArray[i] = new Coordinate(random.Next(6), random.Next(6));
        Console.WriteLine($"{coordinateArray[i].Row}, {coordinateArray[i].Column}");
    }

    foreach(Coordinate coord in coordinateArray)
        Console.WriteLine($"{coord.Row}, {coord.Column} coord has an adjacent coord: {coord.hasAdjacent(coordinateArray)}");
}

Main();

public struct Coordinate
{
    public int Row { get; }
    public int Column { get; }

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public bool hasAdjacent(Coordinate[] coordArray)
    {
        foreach(Coordinate coord in coordArray)
        {
            if (((coord.Row == (Row - 1) || coord.Row == (Row + 1)) && coord.Column == Column) ||
                ((coord.Column == Column - 1 || coord.Column == Column + 1) && coord.Row == Row))
                return true;
        }

        return false;
    }
}