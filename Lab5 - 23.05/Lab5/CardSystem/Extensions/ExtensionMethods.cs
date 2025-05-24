namespace CardSystem.Extensions;

public static class ExtensionMethods
{
    public static string MaskCardNumber(this Card card)
    {
        string result = string.Empty;

        result = card.CardNumber.Substring(0, 4) + "********" + card.CardNumber.Substring(12);

        return result;
    }

    public static void ExpenseWithBonus(this Card card, double amount)
    {
        if (card.WithDraw(amount))
        {
            double bonus = card.Bank switch
            {
                Bank.ABB => amount * 0.02,
                Bank.Leo => amount * 0.04,
                Bank.Kapital => amount * 0.05,
                _ => 0
            };
            card.Bonus += bonus;
        }
        else Console.WriteLine("Odenis teesufler olsun ki ugursuz oldu :( ");
    }
}
