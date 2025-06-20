using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList;

public class Student : Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}

public class StudentDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string FullName { get; set; }
}