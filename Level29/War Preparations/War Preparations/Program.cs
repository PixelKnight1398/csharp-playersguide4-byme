void Main()
{
    Sword basicSword = new Sword(SwordMaterial.Iron, Gemstone.None, 40.0f, 5.0f);
    Sword sapphireSword = basicSword with { Gem = Gemstone.Sapphire };
    Sword conquererSword = basicSword with { Material = SwordMaterial.Steel, Gem = Gemstone.Bitstone, Length = 60.0f, CrossguardWidth = 10.0f };

    Console.WriteLine(basicSword);
    Console.WriteLine(sapphireSword);
    Console.WriteLine(conquererSword);
}

Main();

public record Sword (SwordMaterial Material, Gemstone Gem, float Length, float CrossguardWidth);

public enum SwordMaterial { Wood, Bronze, Iron, Steel, Binarium }
public enum Gemstone { None, Emerald, Amber, Sapphire, Diamond, Bitstone }