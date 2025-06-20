using List.Lecture.Mopdels;

namespace List.Lecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> strings = new List<string>() { "lorem", "ipsum", "test"};

            //List<string> strings2 = new List<string>() { "lorem2", "ipsum", "test2" };

            ////strings.Add("test2");
            ////strings.Remove("ipsum");
            //strings.AddRange(strings2);

            //strings.InsertRange(1, strings2);

            //Console.WriteLine(strings.Count()) ;

            List<Student> students = new();

            Student student1 = new("Test1", "surname1", 12, 25); 
            Student student2 = new("Test2", "surname2", 15, 35);
            Student student3 = new("Test3", "surname3", 1, 45);
            Student student4 = new("Test4", "surname4", 2, 45);

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            var serch = students.LastOrDefault(x => x.Point == 45);

            var adults = students.Where(x => x.Age >= 15);

            //var sortedList = students.OrderByDescending(x => x.Age);

            var reversedList = Enumerable.Reverse(students);

            foreach (var item in reversedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
