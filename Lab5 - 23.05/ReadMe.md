# Lab 5 - 23 may
## Kart Sistemi:
1. `Card` adında abstrakt class yaradırıq:
    - Id
    - Balance
    - Bonus
    - CardNumber (mütləq 16 rəqəmdən ibarət olmalıdır)
    - Bank (enum) (dəyərlər 3-cü sualda var)
    - Kartdan pul çıxılması üçün bir `WithDraw` adında abstrakt metod olmalıdır. Bu metod parametr olaraq çıxılacaq məbləği qəbul edəcək. Və əgər proeses uğurla tamamlanarsa, `true` əks halda `false` dəyəri qaytaracaq.
2. `DebitCard` və `CreditCard` Miras alan classlar olmalıdır (bu class-lardan miras alına bilməməlidir)
    - `DebitCard`
        - `WithDraw` metodunda sadəcə balansdan pul çıxardılsın
    - `CreditCard`:
        - Limit (müsbət olmalıdır)
        - `WithDraw` metodu balansda olan pulu çıxacaq. Əgər məbləğ yetərli olmazsa və limit-də yetərli qədər məbləğ varsa, çatmayan məbləği limitdən çıxılsın.
    - Hər 2 class üçün `ToString` metodunu override edin
3. `Bank` enum:
    - ABB, Kapital, Leo
4. `ICardService` interfeysi:
    - Siyahıya kart əlavə etmək üçün metod
    - Card nömrəsi qəbul edib, ona əsasən Card-ı qaytaran Indexer
5. `CardService`
    - `Card[]` massivi statik olaraq saxlayır ki, biz öz məlumatlarımızı saxlaya bilək
    - Indexer istifadə edərək, göndərilən `CardNumber`-ə uyğun onun məlumatlarını qaytaran metod
        ```cs
        Card searchCard = cardService["1234567812345678"];
        Console.WriteLine(searchCard); // kartın məlumatları
        ```
    - Massivə yeni kart əlavə edən metod. (Əgər eyni `CardNumber` əlavə olunmağa çalışılarsa `ConflictException` exception versin)
6. Extension metodlar
    - `MaskCardNumber()` bu metod kart-ın nömrəsini gizləyərək `1234 **** **** 5678` formatında qaytaracaq
    - `ExpenseWithBonus()` metodu, özlüyündə xərclənən məbləği qəbul edəcək. Kartın bu ödənişi edib, edə bilməyəcəyini yoxlandıqdan sonra kartın hansı bank-a aid olmasına görə onun `Bonus` property-sinin dəyərini artıracaq. Bonuslar belədir:
        - `Abb` kartı üçün 2%
        - `Leo` kartı üçün 4%
        - `Kapital` kartı üçün 5%
    