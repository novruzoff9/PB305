using System.Text;

namespace Classes
{
    public class Order
    {
        public string Id;
        public string Name;
        public int Price;
        public int Quantity;

        public Order(int Id, string Name, int Price)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Name = Name;
            this.Price = Price;
            this.Quantity = 1;
        }

        public Order(int Id, string Name, int Price, int Quantity) : this(Id, Name, Price)
        {
            this.Quantity = Quantity;
        }

        public void ChangePrice(int newPrice, out int diff)
        {
            diff = newPrice - Price;
            Price = newPrice;
        }
        public int TotalPrice()
        {
            return Price * Quantity;
        }
        
        public void IncreaseQuantity(int n)
        {
            Quantity += n;
        }
        
        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sifariş ID {Id}");
            sb.AppendLine($"Məhsul {Name}");
            sb.AppendLine($"Sayi {Quantity}");
            sb.AppendLine($"Qiymət {Price}");
            sb.AppendLine($"Ümumi Məbləğ {TotalPrice()}");

            string info = sb.ToString();
            return info;
        }
    }
}
