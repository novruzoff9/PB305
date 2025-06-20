using SoftDelete.Interfaces;

namespace SoftDelete.Models;

public class Product : ISoftDeletable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsDeleted { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Adı: {Name}, Qiyməti: {Price} Azn, Silinib?: {IsDeleted}";
    }
}
