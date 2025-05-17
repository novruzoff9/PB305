using RestaurantSimulation.Interfaces;
using RestaurantSimulation.Models;

namespace RestaurantSimulation.Services;

public class PizzaService : IPizzaService
{
    public Pizza Bigger(Pizza[] pizzaArr)
    {
        Pizza pizza = pizzaArr[0];
        foreach (var item in pizzaArr)
        {
            if (item.Radius > pizza.Radius)
            {
                pizza = item;
            }
        }
        return pizza;
    }

    public Pizza CreatePizza(string name, int radius, bool ishot, int calory)
    {
        Pizza newPizza = new Pizza
        {
            Name = name,
            Radius = radius,
            IsHot = ishot,
            Calory = calory
        };
        return newPizza;
    }
}
