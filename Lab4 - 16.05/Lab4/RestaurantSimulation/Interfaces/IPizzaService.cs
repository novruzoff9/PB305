using RestaurantSimulation.Models;

namespace RestaurantSimulation.Interfaces;

public interface IPizzaService
{
    Pizza CreatePizza(string name, int radius, bool ishot, int calory);
    Pizza Bigger(Pizza[] arr);
}
