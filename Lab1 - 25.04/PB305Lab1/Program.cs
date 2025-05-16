namespace PB305Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input-la adi daxil et. “Salam Yagmur” cixis verilsin.
            // Salam Yagmur
            string ad = Console.ReadLine();
            Console.WriteLine("Salam " + ad);

            // İnputda yaş qəbul et:
            // 0 - 18: usaq
            // 18 - 65 yetiskin
            // 65 > yasli 
            int yas = Convert.ToInt32(Console.ReadLine());

            if (yas < 18)
            {
                Console.WriteLine("usaq");
            }
            else if (yas < 65)
            {
                Console.WriteLine("yetiskin");
            }
            else
            {
                Console.WriteLine("yasli");
            }

            //switch case ile, input olunan qiymete uygun cixis ver:
            //(2 - “Pis”, 3- “Kafi”, 4- “Yaxsi”, 5-”Ela”,
            // Eks halda “2- 5 arasi eded daxil edin”)

            int qiymet = Convert.ToInt32(Console.ReadLine());
            switch (qiymet)
            {
                case 2:
                    Console.WriteLine("Pis");
                    break;
                case 3:
                    Console.WriteLine("Kafi");
                    break;
                case 4:
                    Console.WriteLine("Yaxsi");
                    break;
                case 5:
                    Console.WriteLine("Ela");
                    break;
                default:
                    Console.WriteLine("2- 5 arasi eded daxil edin");
                    break;
            }

            //input edilmis ededin faktorialini alma
            // 5
            // 120

            int faktorial = 1;
            int f = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= f; i++)
            {
                faktorial *= i;
            }
            Console.WriteLine(faktorial);


            //n-den m-e qeder olan sonu ‘0’-la biten ededlerin cemi
            // 15  36
            // 20 + 30 = 50

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = n; i < m; i++)
            {
                if (i % 10 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);


            //Istifadeci ‘0’ daxil edene qeder, daxil edilen ededlerin hasilinin tapilmasi
            // 5 7 8 0
            // 5 * 7 * 8 = 280

            int hasil = 1;
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                hasil *= num;
            }
            Console.WriteLine(hasil);

            //Sizə x və y tam ədədləri verilir.
            //Siz 0 ilə x arasında yerləşən və y-ə tam bölünən ən böyük ədədi tapmalısınız. Əgər belə bir ədəd yoxdursa, ekranda -1 çap olunmalıdır.

            // 49
            // 5
            // -1
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int maks = -1;
            for (int i = 1; i <= x; i++)
            {
                if (i % y == 0)
                {
                    maks = i;
                }
            }
            Console.WriteLine(maks);

            //Baslangicda login ucun bir parol teyin olunsun. Istifadeci duzgun daxil edene qeder inputa versin

            // parol = salam123
            // I: salam
            // O: Parol Sehvdir, tekrar yoxlayin
            // I: salam1
            // O: Parol Sehvdir, tekrar yoxlayin
            // I: salam123
            // O: Giris ugurlu oldu

            string password = "salam123";
            while (true)
            {
                string login = Console.ReadLine();
                if (login == password)
                {
                    Console.WriteLine("Giris ugurlu oldu");
                    break;
                }
                Console.WriteLine("Parol yanlisdir, tekrar yoxlayin");
            }

            // şans sayi artirmaqla olan veriyasi:
            string pass = "salam123";
            int sans = 3;
            while (true)
            {
                string login = Console.ReadLine();
                if (login == pass)
                {
                    Console.WriteLine("Giris ugurlu oldu");
                    break;
                }
                sans--;
                if (sans == 0)
                {
                    Console.WriteLine("Parol yanlisdir. Sansiniz bitdi");
                    break;
                }
                Console.WriteLine("Parol yanlisdir, tekrar yoxlayin " + sans + " sansiniz qaldi");
            }
        }
    }
}
