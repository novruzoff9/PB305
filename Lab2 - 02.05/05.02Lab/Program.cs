namespace _05._02Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tam ədədlər ardıcıllığı verilir. Ardıcıllığın hər bir mənfi olmayan elementini 2 vahid artırmalı. (input vasitəsilə, əvvəlcə ardıcıllığın ölçüsünü alırıq daha sonra isə elementlərini)
            // 5
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] newArr = UpdateArray(arr);


            foreach (int num in newArr)
            {
                Console.WriteLine(num);
            }
            // n-ci fibonacci ededini cixisa veren proqram
            // 6
            // 0 1 1 2 3 5 8 13 21

            int n = Convert.ToInt32(Console.ReadLine()); // 6
            int[] fiArr = new int[n]; // {0, 1 ,0 ,0 , 0, 0}
            fiArr[0] = 0;
            fiArr[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fiArr[i] = fiArr[i - 1] + fiArr[i - 2];
            }
            Console.WriteLine(fiArr[n - 1]);

            //Tələbənin məlumatları (adı, soyadı, universiteti, yasi) 1 dəyişəndə veriləcək. Bütün bu məlumatları özündə saxlayan string yaratmaq.

            //Yagmur adli telebe 20 yasinda UNEC-de oxuyur
            var student = new
            {
                Name = "Yagmur",
                Age = 20,
                Uni = "UNEC"
            };
            string data = $"Adi: {student.Name}, Yasi: {student.Age}, Uni: {student.Uni}";
            Console.WriteLine(data);

            //Statik olaraq məhsullar siyahısı veriləcək. (Məhsulun adı, qiyməti, stok miqdarı)

            var products = new[]
            {
                new
                {
                    Name = "Ananas",
                    Price = 10.0,
                    Stock = 1,
                },
                new
                {
                    Name = "Banan",
                    Price = 5.0,
                    Stock = 4,
                },
                new
                {
                    Name = "Alma",
                    Price = 3.0,
                    Stock = 5,
                },
                new
                {
                    Name = "Nar",
                    Price = 7.0,
                    Stock = 1,
                },
                new
                {
                    Name = "Armud",
                    Price = 4.0,
                    Stock = 0,
                },
            };
            //Hər bir məhsulun məlumatını string formatda çıxışa versin.

            foreach (var product in products)
            {
                string productData = $"Adi: {product.Name}, Qiymeti: {product.Price}, Stok: {product.Stock}";
                Console.WriteLine(productData);
            }

            //Əgər məhsul bitibsə ekrana “xxx adlı məhsul bitib. Yeniləyin!”, əgər 1 ədəd qalıbsa “xxx adlı məhsul bitmək üzrədir.” Əks halda isə “xxx adlı məhsuldan xeyli mövcuddur” yazısı çıxışa verilsin

            foreach (var product in products)
            {
                switch (product.Stock)
                {
                    case 0:
                        Console.WriteLine($"{product.Name} adli mehsul bitib");
                        break;
                    case 1:
                        Console.WriteLine($"{product.Name} adli mehsul bitmek uzredir");
                        break;
                    default:
                        Console.WriteLine($"{product.Name} adli mehsul xeyli movcuddur");
                        break;
                }
            }




            //Loglama metodu yaradilacaq. Metoda mətn və log səviyyəsi (Info, Warn, Error) göndəriləcək. Çıxışda əvvəlcə səviyyə, sonra isə mətn görsənəcək.
            //İstifadəçi log səviyyəsini göndərməsə Info olacaq.

            Log("Sistem çökdü", "Error"); //Default value olmadan
            Log("Istifadəçi qeydiyyatdan keçdi"); // Default value ilə

            //Metod-a əvvəlcə operatoru (toplama və ya vurma) yazacam. Daha sonra istədiyim qədər elementləri. Elementlər arasında həmin operatoru işlədən proqram
            Calculate('*', 4, 6, 7, 1, 19,5,2);
        }

        public static int Calculate(char operate, params int[] numbers)
        {
            switch (operate){
                case '+':
                    int result = 0;
                    foreach (int item in numbers)
                    {
                        result += item;
                    }
                    return result;
                case '*':
                    int result2 = 1;
                    foreach (int item in numbers)
                    {
                        result2 *= item;
                    }
                    return result2;
                default:
                    Console.WriteLine("Duzgun operator daxil edin");
                    return 0;
            }
        }

        public static void Log(string text, string level = "Info")
        {
            Console.WriteLine($"{level} : {text}");
        }

        public static int[] UpdateArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i] += 2;
                }
            }
            return arr;
        }
    }
}
