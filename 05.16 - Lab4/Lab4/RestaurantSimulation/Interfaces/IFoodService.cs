using RestaurantSimulation.Models;

namespace RestaurantSimulation.Interfaces;

public interface IFoodService
{
    int Count(Food[] pizzaArr, double n);
    DateTime PrepareTime(Food food);
}
