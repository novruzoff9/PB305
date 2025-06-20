using System.Threading.Channels;

namespace CustomList;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        MyCustomList<string> myCustomList = new();

        myCustomList.Add("test");
        myCustomList.Add("test1");
        myCustomList.Add("test2");
        myCustomList.Add("test3");
        myCustomList.Add("test2");
        //myCustomList.Remove("test2");

        myCustomList.Insert(5, "test10");

        

        //myCustomList.Print();
        //ints[1] = 5;


        Student student = new();
        Person person = new();
        student.age
        //student.Walk();
    }
}
