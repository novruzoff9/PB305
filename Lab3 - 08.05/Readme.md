# Lab 3 - 8 may
## Tapşırıqlar:
#### String Metodlar:
1. Verilən e-poçt adresinin doğruluğunu yoxlayan metod:
    - Boş dəyər olması halında istifadəçiyə məlumat verməli
    - içərisində `@` simvolu olmalı
    - `@` simvolundan sonra `.` simvolu olmalı
    Əgər bütün bunlar ödənərsə, istifadəçiyə `true` əks halda `false` qaytarsın.
2. `email` dəyişənindən `@` işarəsindən sağ tərəfdə olan hissəni return etsin. Dəyişən özündə sadəcə sol tərəfi saxlasın.
    ```cs
    string email = "test.user@code.edu.az";
    string domain = FixEmail(...);
    Console.WriteLine(email);  //test.user
    Console.WriteLine(domain); //code.edu.az
    ```
3. Özündə adları saxlayan zədələnmiş string var. Ona aşağıdakı düzəlişləri edən metodu yazmaq lazımdır:
    - `?` yerinə `a` hərfləri yazılmalı
    - Hər birinin ilk hərfi böyük, digər hərflər kiçik olmalı
    - Adlar bir birindən `;` simvolu ilə ayrılıb. Gələn nəticədə adlar vergüllə ayrılmış string kimi qaytarılmalı
        ```cs
        string wreckedNames = "?yX?N;F?tEH;yuSif;k?MR?n";
        Console.WriteLine(RepairNames(wreckedNames));
        //Ayxan, Fateh, Yusif, Kamran
        ```
#### Class:
1. `Order` adında class yaratmalı
2. Fieldlar:
    - Id
    - Məhsulun adı
    - Məhsulun sayı
    - Məhsulun qiyməti
3. Dəyərlər Construcor ilə verilməlidir. 2 ədəd constructor olmalıdır:
    1. Əgər Obyekt yaradılarkən Məhsulun sayı göndərilərsə, `Məhsul sayı` field-ı həmin dəyərə bərabər olmalıdır.
    2. Əgər göndərilməzsə 1-ə
4. Yaradılmalı olan metodlar
    1. Sifarişin ümumi məbləğini geri qaytaran metod
    2. Metoda `n` dəyəri göndəriləcək. Sifarişdə olan məhsulun sayını `n` qədər artıran metod. Əgər `n` göndərilməsə 1 vahid artırılacaq.
    3. `String Builder` istifadə edərək Sifariş məlumatlarını ekrana yazdıram metod:
    Çıxış nümunəsi:
        ```
        Sifariş ID: 1
        Məhsul: Kitab
        Sayı: 2
        Qiymət: 15 AZN
        Ümumi Məbləğ: 30 AZN
        ```
    4. `diff` adında dəyəri olmayan bir dəyişən təyin edəcəm. Məhsulun qiymətini dəyişmək üçün elə bir metod yaradın ki, metod-a məhsulun yeni qiymətini göndərim və o metod həm məhsulun qiymətini dəyişsin, həm də məhsulun köhnə qiyməti ilə yeni qiyməti arasındakı fərqi mənə `diff` dəyişəni vasitəsilə qaytarsın.
        ```cs
        int diff;
        order1.ChangePrice(....);
        Console.WriteLine(diff); // Yeni və köhnə qiymət arasındakı fərq
        Console.WriteLine(order1.Price); // Yeni qiymət
        ```
        **Şərti başa düşməyən təkrar soruşsun*
5. `Order` class-ından miras alan, `OnlineOrder` class-ı yaratmalı
6. Fieldlar:
    - Id
    - Məhsulun adı
    - Məhsulun sayı
    - Məhsulun qiyməti
    - Sifarişin məsafəsi
7. Dəyərlər constructor vasitəsilə verilməlidir
8. Yaradılmalı olan metodlar:
    1. Hər 5km məsafə üçün 2 manat çatdırılma ödənişi alınmalıdır. Çatdırılma üçün olan ümumi ödənişi geri qaytaran metod.
    2. Çatıdırılma məbləği ilə birlikdə ümumi məbləği detallı şəkildə göstərən metod. `StringBuilder` ilə.
    Çıxış nümunəsi:
        ```
        Sifariş ID: 1
        Məhsul: Kitab
        Sayı: 2
        Qiymət: 15 AZN
        Ümumi Məbləğ: 30 AZN
        Məsafə: 12 Km
        Çatıdırlma: 3 AZN
        Ümumi Məbləğ Çatdırılma ilə: 33 AZN
        ```