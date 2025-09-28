using Pb305OnionArc.Domain.ValueObjects;

namespace Pb305OnionArc.Domain.Models;

public class Order : BaseEntity
{
    private Order() : base() { } // For EF Core
    public Order(string customerName, string customerEmail, DateTime orderDate, Address address) : base()
    {
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        OrderDate = orderDate;
        Address = address;
    }
    public DateTime OrderDate { get; private set; }
    public string CustomerName { get; private set; }
    public string CustomerEmail { get; private set; }
    public Address Address { get; set; }
}
