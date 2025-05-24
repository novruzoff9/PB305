using CardSystem.Exceptions;

namespace CardSystem.Services;

public interface ICardService
{
    void AddToCardList(Card card);
    Card this [string cardNumber] { get;}
}
public class CardService : ICardService
{
    public static Card[] Cards = new Card[0];
    public Card this[string cardNumber]
    {
        get
        {
            foreach (var item in Cards)
            {
                if (item.CardNumber == cardNumber)
                {
                    return item;
                }
            }
            return null;
        }
    }
    public void AddToCardList(Card card)
    {
        if (this[card.CardNumber] == null )
        {
            Array.Resize(ref Cards, Cards.Length + 1);
            Cards[Cards.Length - 1] = card;
        }
        else
            throw new ConflictException("CardNumber already exists");
    }
}
