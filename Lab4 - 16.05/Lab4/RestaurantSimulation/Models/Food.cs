using RestaurantSimulation.Interfaces;

namespace RestaurantSimulation.Models;

public abstract class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
    private DateTime _created;
    public DateTime Created 
    {
        get { return _created; }
        set
        {
            if (value > DateTime.Now)
                Console.WriteLine("Gelecek zaman daxil etmek olmaz");
            else
                _created = value;
        }
    }
    public TimeSpan PrepareTime { get; set; }
    private double _calory;
    public double Calory 
    {
        get
        {
            return _calory;
        }
        set
        {
            if (value > 0)
                _calory = value;
            else
                Console.WriteLine("Müsbet eded daxil edin");
        }
   }
    public abstract double CalcPrice();
}
