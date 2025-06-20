using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Lecture.Mopdels;

public class Student : IComparable<Student>
{
    public Student(string name, string surName, int age, int point)
    {
        Name = name;
        SurName = surName;
        Age = age;
        Point = point;
    }

    public string Name { get; set; }
    public string SurName { get; set; }
    public int Age { get; set; }
    public int Point { get; set; }

    public int CompareTo(Student? other)
    {
        return this.Point.CompareTo(other.Point);
    }

    public override string ToString()
    {
        return $"Name {Name}, Surname {SurName}, Age {Age}";
    }

    public string ShowInfo()
    {
        return $"Name {Name}, Surname {SurName}, Age {Age}";
    }
}
