void Main()
{
    Color color1 = new Color(0, 100, 200);
    Color color2 = Color.Yellow;

    Console.WriteLine(color1.displayColorValues());
    Console.WriteLine(color2.displayColorValues());
}

Main();

class Color
{
    public int RedValue { get; set; }
    public int GreenValue { get; set; }
    public int BlueValue { get; set; }

    public Color() : this(0, 0, 0) { }

    public Color(int red, int green, int blue)
    {
        RedValue = red;
        GreenValue = green;
        BlueValue = blue;
    }

    public string displayColorValues()
    {
        return $"({RedValue}, {GreenValue}, {BlueValue})";
    }

    public static Color White => new Color(255, 255, 255);
    public static Color Black => new Color(0, 0, 0);
    public static Color Red => new Color(255, 0, 0);
    public static Color Orange => new Color(255, 165, 0);
    public static Color Yellow => new Color(255, 255, 0);
    public static Color Green => new Color(0, 128, 0);
    public static Color Blue => new Color(0, 0, 255);
    public static Color Purple => new Color(128, 0, 128);
}