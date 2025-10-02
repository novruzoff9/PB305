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
    
    // Add constructor with UserId
    public Order(string customerName, string customerEmail, DateTime orderDate, Address address, string userId) : base()
    {
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        OrderDate = orderDate;
        Address = address;
        UserId = userId;
    }
    
    public DateTime OrderDate { get; private set; }
    public string CustomerName { get; private set; }
    public string CustomerEmail { get; private set; }
    public Address Address { get; set; }
    
    // Foreign key to AppUser
    public string? UserId { get; set; }
    
    // Navigation property
    public AppUser? User { get; set; }
}
