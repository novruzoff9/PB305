using RestaurantSimulation.Models;

namespace RestaurantSimulation.Interfaces;

public class FoodService : IFoodService
{
    public int Count(Food[] a, double n)
    {
        int sum = 0;
        foreach (Food item in a)
        {
            if (item.Calory > n)
                sum++;
        }
        return sum;
    }

    public DateTime PrepareTime(Food food)
    {
        return food.Created + food.PrepareTime;


    }
}

