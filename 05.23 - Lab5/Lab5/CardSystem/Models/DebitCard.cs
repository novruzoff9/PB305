namespace CardSystem.Models;

public sealed class DebitCard : Card
{
    public override string ToString()
    {
        return $"Card Number: {CardNumber}, Balance: {Balance}, Bonus: {Bonus}";
    }
    public override bool WithDraw(double price)
    {
        if(Balance>=price)
        { 
            Balance -= price;
            return true;
        }
        return false;
    }
}
