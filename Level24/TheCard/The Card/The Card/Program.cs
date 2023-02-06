
void Main()
{
    Card[] cardArray = new Card[56];
    int cardIncrement = 0;
    foreach(CardColors color in Card.CardColorArray)
    {
        foreach(CardRanks rank in Card.CardRankArray)
        {
            Card newCard = new Card(color, rank);
            Console.WriteLine(newCard.cardDescription());
            cardIncrement++;
        }
    }
}

Main();

class Card
{
    public CardColors CardColor { get; set; }
    public CardRanks CardRank { get; set; }

    public static CardColors[] CardColorArray = new CardColors[4] { CardColors.Red, CardColors.Green, CardColors.Blue, CardColors.Yellow };
    public static CardRanks[] CardRankArray = new CardRanks[14] { CardRanks.One, CardRanks.Two, CardRanks.Three, CardRanks.Four, CardRanks.Five, CardRanks.Six, CardRanks.Seven, CardRanks.Eight, CardRanks.Nine, CardRanks.Ten, CardRanks.Dollar, CardRanks.Percent, CardRanks.Caret, CardRanks.Ampersand };

    public Card(CardColors cardColor, CardRanks cardRank) {
        CardColor = cardColor;
        CardRank = cardRank;
    }

    public bool isNumberCard()
    {
        return CardRank switch
        {
            CardRanks.One => true,
            CardRanks.Two => true,
            CardRanks.Three => true,
            CardRanks.Four => true,
            CardRanks.Five => true,
            CardRanks.Six => true,
            CardRanks.Seven => true,
            CardRanks.Eight => true,
            CardRanks.Nine => true,
            CardRanks.Ten => true,
            CardRanks.Dollar => false,
            CardRanks.Percent => false,
            CardRanks.Caret => false,
            CardRanks.Ampersand => false,
            _ => false
        };
    }

    public string cardDescription()
    {
        return $"The {CardColor} {CardRank}";
    }
}

enum CardColors { Red, Green, Blue, Yellow }
enum CardRanks { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand }