using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.Lecture.Mopdels;

public class Group
{
    private Student[] _students = new Student[0];
    private static int _no;
    public int No { get; private set; }
    public void AddStudent(Student student)
    {
        Array.Resize(ref _students, _students.Length + 1);
        _students[_students.Length - 1] = student;
    }

    public Student[] SortStudents()
    {
        Student[] newStudents = (Student[])_students.Clone();
        Array.Sort(newStudents);
        return newStudents;
    }
}


