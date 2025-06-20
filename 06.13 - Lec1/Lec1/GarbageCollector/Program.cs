using GarbageCollector.Models;
using static System.Net.Mime.MediaTypeNames;

namespace GarbageCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Test";
            str1 = "test2";

            using Person person2 = new(4);
            Test();

            GC.Collect();
        }

        public static void Test()
        {
            using Person person1 = new(2);
        }
    }
}
