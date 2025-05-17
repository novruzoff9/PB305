using RestaurantSimulation.Interfaces;
using RestaurantSimulation.Models;
using RestaurantSimulation.Services;

namespace RestaurantSimulation;

internal class Program
{
    static void Main(string[] args)
    {
        Pizza pizza = new Pizza();
        pizza.Name = "Doble";
        pizza.Radius = 12;
        pizza.Created = DateTime.Now;
        pizza.PrepareTime = TimeSpan.FromMinutes(5);


        Pizza[] pizzas = new Pizza[5]
        {
            new Pizza { Name = "Margherita", Radius = 12, Calory = 250, IsHot = false, PrepareTime = TimeSpan.FromMinutes(15), Created = DateTime.Now },
            new Pizza { Name = "Pepperoni", Radius = 14, Calory = 320, IsHot = true, PrepareTime = TimeSpan.FromMinutes(18), Created = DateTime.Now },
            new Pizza { Name = "BBQ Chicken", Radius = 16, Calory = 400, IsHot = true, PrepareTime = TimeSpan.FromMinutes(20), Created = DateTime.Now },
            new Pizza { Name = "Veggie", Radius = 10, Calory = 220, IsHot = false, PrepareTime = TimeSpan.FromMinutes(12), Created = DateTime.Now },
            new Pizza { Name = "Hawaiian", Radius = 13, Calory = 280, IsHot = false, PrepareTime = TimeSpan.FromMinutes(17), Created = DateTime.Now }
        };

        IFoodService foodService = new FoodService();
        Console.WriteLine(foodService.PrepareTime(pizza));
        Console.WriteLine(foodService.Count(pizzas, 300));

        PizzaService newpizza = new PizzaService();
        Pizza a = newpizza.CreatePizza("Margarita", 10, true, 200);
        Console.WriteLine(a);
        Console.WriteLine(newpizza.Bigger(pizzas));
    }
}