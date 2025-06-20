using System.ComponentModel.DataAnnotations;

namespace Reflection.Models;

public class Person
{
    public readonly int ReadOnlyInt;
    public static int Staticint { get; set; }
    public int Id { get; private set; }

    [Required]
    [MaxLength(15)]
    public string Name { get; set; }

    private string Surname { get; set; }

    public Person()
    {
        Surname = "YeniSurnname";
        ReadOnlyInt = 10;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }

    public void Add(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine(sum);
    }

    public void Print(string name)
    {
        Console.WriteLine(name);
    }
}
