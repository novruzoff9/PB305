# Mini Lab 1 - 3 Iyun
## Soft Delete
Soft delete-in ilkin səviyyədə istifadəsi:

`Product` class-ı:
```cs
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsDeleted { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Adı: {Name}, Qiyməti: {Price} Azn";
    }
}
```
Yuxarıdakı class üçün bir funksionallıq hazırlanmalıdır ki, bu tip üçün olan bir List-də elementi silmək istənildikə bir başa elementin özünü siyahıdan çıxartmaq əvəzinə onun `IsDeleted` dəyərini `true`-ya çevirsin.
Həmin siyahının elementlərini çıxışa vermək istədikdə isə `IsDeleted` dəyərləri `false` olanları çıxışa versin

Hazır List:
```cs
List<Product> products = new List<Product>();
Product product1 = new Product()
{
    Id = 1,
    Name = "Laptop",
    Price = 1200.00m,
    IsDeleted = false
};
Product product2 = new Product()
{
    Id = 2,
    Name = "Smartphone",
    Price = 800.00m,
    IsDeleted = false
};
Product product3 = new Product()
{
    Id = 3,
    Name = "Tablet",
    Price = 500.00m,
    IsDeleted = false
};
products.Add(product1);
products.Add(product2);
products.Add(product3);
```

Sizdən istənilən tapşırıqlar:

> [!WARNING]
> Aşağıda tapşırılan metodlar sadəcə `Product` class-ı üçün deyil, `SoftDelete` edilməli olan bütün class-lara uyğunlaşmalıdır.

1. Struktura, qovluqlara, dəyişənlərin adlandırmasına və kodun səliqəli olmasına önəm verin.
2. Bir başa silmək əvəzinə `SoftDelete` edilməsi:
    ```cs
    products.SoftDelete(product2);
    ```
    Bu metod nəticəsində siyahıda olan `product2` obyektinin `IsDeleted` dəyəri `true` olsun. Əgər məhsul siyahıda yoxdursa `NotFoundException` xətası versin.
3. Aktiv məhsulları əldə etmək:
    ```cs
    var activeProducts = products.GetActiveItems();

    Console.WriteLine("Aktiv məhsullar:");
    foreach (var product in activeProducts)
    {
        Console.WriteLine(product);
    }
    ```