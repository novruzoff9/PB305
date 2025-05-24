namespace CardSystem;

internal class Program
{
    static void Main(string[] args)
    {
        //Card card = new Card();
        //card.CardNumber = "123423456785678";

        Card card = new CreditCard();
        card.CardNumber = "4169234567856784";
        card.Balance = 100;
        card.Bonus = 0;
        card.Bank = Bank.Kapital;

        Card card1 = new CreditCard();
        card1.CardNumber = "1111234567856784";
        card1.Balance = 100;
        card1.Bonus = 0;
        card1.Bank = Bank.Kapital;

        CardService card4 = new CardService();
        card4.AddToCardList(card);
        card4.AddToCardList(card1);
        Card searchCard = card4["4169234567856784"];

        Console.WriteLine(searchCard);
    }
}
