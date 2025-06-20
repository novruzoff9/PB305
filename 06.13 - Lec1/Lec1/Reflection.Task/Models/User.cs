using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Task.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

public class UserDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}
