namespace RestaurantSimulation.Models;

public class Pizza: Food
{
    public int Radius { get; set; }
    public bool IsHot { get; set; }

    public override string ToString()
    {
        string info = $"Name: {Name} Price: {CalcPrice()}Azn Radius: {Radius}";
        return info;
    }
    public override double CalcPrice()
    {
        double area = Math.PI * Radius * Radius;
        double price = area * 0.1;
        if (IsHot)
            price += 1.15;
        return price;
    }

}