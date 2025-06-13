using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector.Models;

public class Person : IDisposable
{
    public int Id { get; set; }
    public Person(int id)
    {
        Id = id;
        Console.WriteLine($"{Id} ID-li obyekti yaradildi");
    }

    ~Person()
    {
        Console.WriteLine($"{Id} ID-li obyekti silinir");
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
