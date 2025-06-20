using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class OnlineOrder : Order
    {
        public int Distance;

        public OnlineOrder(int Id, string Name, int Price, int Quantity, int Distance) : base(Id, Name, Price, Quantity)
        {
            this.Distance = Distance;
        }

        public string ShowFullInfo()
        {
            string fullInfo = ShowInfo();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Məsafə {Distance}");
            sb.AppendLine($"Çatıdırlma {DistancePrice()}");
            sb.AppendLine($"Ümumi Məbləğ Çatdırılma ilə {TotalPrice() + DistancePrice()}");

            string distanceDetails = sb.ToString();
            return fullInfo + distanceDetails;
        }

        public int DistancePrice()
        {
            int price = (Distance / 5) * 2;
            if(Distance % 5 != 0)
            {
                price += 2;
            }

            return price;
        }
    }
}
