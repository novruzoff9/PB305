namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(1, "Alma", 12, 5);

            Console.WriteLine(order1.Id);

            //Ümumi məbləğin tapılması
            int totalPrice = order1.TotalPrice();
            Console.WriteLine(totalPrice);

            //Sifarişin sayını artırmaq
            order1.IncreaseQuantity(2);
            Console.WriteLine(order1.Quantity);

            //Məhsulun məlumatlarını göstərmək
            Console.WriteLine(order1.ShowInfo());

            //Qiymətin dəyişdirilməsi
            int diff;
            order1.ChangePrice(10, out diff);
            Console.WriteLine(diff);
            Console.WriteLine(order1.Price);

            // Inheritance alınmış class-ın istifadəsi
            OnlineOrder online = new OnlineOrder(1, "Alma", 12, 5, 3);
            Console.WriteLine(online.DistancePrice());
            Console.WriteLine(online.ShowFullInfo());
        }
    }
}
