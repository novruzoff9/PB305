namespace CardSystem.Models;

public sealed class CreditCard : Card
{
    public double Limit { get; set; } = 999;

    public override string ToString()
    {
        return $"Card Number: {CardNumber}, Balance: {Balance}, Bonus: {Bonus}, Limit: {Limit}";
    }
    public override bool WithDraw(double price)
    {
        if (Balance >= price)
        {
            Balance -= price;
            return true;
        }
        else
        {
            price -= Balance;
            if (Limit > price)
            {
                Limit -= price;
                return true;
            }
        }
        return false;
    }
}
