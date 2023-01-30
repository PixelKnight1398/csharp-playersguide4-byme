using System;

(Seasoning seasoning, Ingredient ingredient, FoodType foodType)[] soupStorage = new (Seasoning, Ingredient, FoodType)[3];

for(int i = 0; i < soupStorage.Length; i++)
{
    Console.WriteLine($"Soup {i+1}, choose the ingredients!");
    Console.WriteLine($"Firstly, the type of food.  Soup, Stew, or Gumbo?");
    string foodTypeInput = Console.ReadLine();
    Console.WriteLine("Great! Now for the main ingredient, mushrooms, tofu, carrots, or potatoes?");
    string mainIngredientInput = Console.ReadLine();
    Console.WriteLine("Excellent, how should we season it? Spicy, salty, or sweet?");
    string seasoningInput = Console.ReadLine();

    FoodType foodTypeOutput = foodTypeInput switch {
        "soup" => FoodType.Soup,
        "stew" => FoodType.Stew,
        "gumbo" => FoodType.Gumbo,
        _ => FoodType.Unknown
    };
    Ingredient ingredientOutput = mainIngredientInput switch
    {
        "mushrooms" => Ingredient.Mushroom,
        "tofu" => Ingredient.Tofu,
        "carrots" => Ingredient.Carrot,
        "potatoes" => Ingredient.Potato,
        _ => Ingredient.Unknown
    };
    Seasoning seasoningOutput = seasoningInput switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet,
        _ => Seasoning.Unknown
    };

    soupStorage[i] = (seasoningOutput, ingredientOutput, foodTypeOutput);
}

foreach(var soup in soupStorage)
{
    Console.WriteLine($"We made {soup.seasoning} {soup.ingredient} {soup.foodType}");
}

enum FoodType { Soup, Stew, Gumbo, Unknown = 0 }
enum Ingredient { Mushroom, Tofu, Carrot, Potato, Unknown = 0 }
enum Seasoning { Spicy, Salty, Sweet, Unknown = 0 }