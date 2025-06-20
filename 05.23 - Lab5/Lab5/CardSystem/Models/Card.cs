using System.Text.RegularExpressions;

namespace CardSystem.Models;

public abstract class Card
{
    public int Id { get; set; }
    public double Balance { get; set; }
    public double Bonus { get; set; }
    string _cardNumber;
    public string CardNumber
    {
        get
        {
            return _cardNumber;
        }
        set
        {
            bool reg = Regex.IsMatch(value, @"^\d{16}$");
            if (reg)
            {
                _cardNumber = value;
            }
        }
    }
    public Bank Bank { get; set; }

    public abstract bool WithDraw(double price);
    public override string ToString()
    {
        return $"Card Number: {this.MaskCardNumber()}, Balance: {Balance}, Bonus: {Bonus}";
    }
}
