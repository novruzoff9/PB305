using Reflection.Models;
using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person); // typeof(T) class-ın tipini tapır
            Console.WriteLine(personType.Name); // Tipin adının çıxşa verir

            PropertyInfo[] props = personType.GetProperties(); // Tipin bütün public property-lərini alır

            foreach (var item in props)
            {
                // item.Name - property-nin adını alır
                // item.PropertyType - property-nin tipini alır
                Console.WriteLine($"{item.Name}, {item.PropertyType}");
            }

            Person person1 = new();
            person1.Name = "Test1";
            Type type = person1.GetType();

            PropertyInfo nameProp = type.GetProperty("Name");

            //GetValue - property-nin dəyərini alır
            Console.WriteLine(nameProp.GetValue(person1));

            //nameProp.SetValue(person1, "Test2"); // property-nin dəyərini dəyişir
            nameProp.SetValue(person1, "NewValue");
            Console.WriteLine(person1.Name); // Output: NewValue

            //Non-public property-ləri almaq üçün BindingFlags istifadə olunur
            PropertyInfo[] propertyInfos = type.GetProperties(
                BindingFlags.NonPublic | BindingFlags.Instance
                );

            // SurnameProp - person1 tipinin "Surname" adındakı private propertisini alır
            PropertyInfo SurnameProp = type.GetProperty(
                "Surname",
                BindingFlags.NonPublic | BindingFlags.Instance
                );

            //GetValue - property private belə olsa onun dəyərini alır
            Console.WriteLine(SurnameProp.GetValue(person1));

            //SetValue - property private belə olsa dəyərini dəyişir
            SurnameProp.SetValue(person1, "SurnameDeyisdi");
            Console.WriteLine(SurnameProp.GetValue(person1)); // Output: SurnameDeyisdi

            //Həmçinin Readonly property-ləri də dəyişmək mümkündür
            FieldInfo ReadonlyProp = type.GetField("ReadOnlyInt");

            Console.WriteLine(ReadonlyProp.Name);
            ReadonlyProp.SetValue(person1, 20);
            Console.WriteLine(person1.ReadOnlyInt);

            //Method-ləri almaq üçün GetMethods() istifadə olunur
            MethodInfo[] methods = type.GetMethods();

            foreach (var method in methods)
            {
                // item.Name - methodun adını alır
                // item.ReturnType - methodun qaytardığı tipini alır
                Console.WriteLine($"{method.Name}, {method.ReturnType}");
            }

            //Method-lərin dəyərini almaq üçün GetMethod() istifadə olunur
            MethodInfo addMethod = type.GetMethod("Add");

            //Invoke - methodu çağırır, ilk parametr - instance, ikinci parametr - methodun parametrləri
            addMethod.Invoke(person1, new object[] { 10, 20 });

            //CustomAttributes - property-nin üzərindəki atributları alır
            var attrs = nameProp.CustomAttributes;
            foreach (var item in attrs)
            {
                Console.WriteLine(item.AttributeType.Name);
            }


            //Method-lərin atributlarını almaq üçün GetCustomAttributes() istifadə olunur
            var methodAttrs = addMethod.GetCustomAttributes(true);
            foreach (var item in methodAttrs)
            {
                Console.WriteLine(item.GetType().Name);
            }
        }
    }
}
