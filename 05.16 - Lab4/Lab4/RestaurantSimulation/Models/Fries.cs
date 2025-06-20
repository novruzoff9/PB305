namespace RestaurantSimulation.Models;

public class Fries : Food
{
    public bool IsSalt { get; set; }
    public int Weight { get; set; }

    public override double CalcPrice()
    {
        double price = Weight;
        if (IsSalt)
            price += 0.8;
        return price;
    }

    public override string ToString()
    {
        string info = $"Name: {Name} Price: {CalcPrice()}Azn Weight: {Weight}";
        return info;
    }
}


