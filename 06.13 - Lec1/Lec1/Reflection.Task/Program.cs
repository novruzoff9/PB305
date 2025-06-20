using Reflection.Task.Models;
using Reflection.Task.Services;

namespace Reflection.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Id = 1,
                Name = "John",
                Surname = "Doe",
                Age = 30
            };

            Product product = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 999.99m,
                Description = "High performance laptop",
                Category = "Electronics"
            };

            UserDto? userDto = Mapper.Map<User, UserDto>(user);

            ProductDto? productDto = Mapper.Map<Product, ProductDto>(product);

            Console.WriteLine($"Name: {userDto.Name}, Surname: {userDto.Surname}, Age: {userDto.Age}");

            Console.WriteLine($"Product Name: {productDto.Name}, Price: {productDto.Price}, Category: {productDto.Category}");
        }
    }
}
