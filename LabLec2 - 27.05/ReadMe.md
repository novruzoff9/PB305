# Lab Lecture 2
## Task idarəetmə sistemi
1. `TaskStatus` adlı enum
    - ToDo
    - InProgress
    - Done
2. `Task` adında class yaradılacaq
    - Id
    - Başlıq
    - İzahat
    - Created
    - DeadLine (tarix və saat olaraq)
    - TaskStatus (enum)
    - `Id` dəyəri Constructor vasitəsilə Guid olaraq avtomatik veriləcək, `Created` dəyəri constructor-da hazırki vaxtı göstərəcək.
    - `ToString()` override edilməli
3. `ITaskService` interfeysi yaradırıq
    - 3.1. Siyahıya Task əlavə etmək üçün metod. (eyni başlıqlı Task artırılsa `ConflictException` qaytaracaq)
    - 3.2 Title-a görə Siyahıdan task-i tapan metod
    - 3.3 Göndərilən Status-da olan task-ları tapan metod
    - 3.4 Göndərilən Id-də olan elementi siyahıdan silmək üçün metod
4. `TaskService` class-ı yaradırıq
    - Task-lar üçün List saxlayır özündə
    - 3.1-deki tapsirigda Siyahıya Task əlavə etmək üçün metodda eyni başlıqlı Task artırılsa `ConflictException` qaytaracaq
    - 3.2 -deki Title-a görə Siyahıdan task-i tapan metod-da eger hec bir task tapilmasa `NotFoundException` qaytarsın
    - **3.3 string-i enum-a cevirmeyi goster**
    - 3.4 -də göndərilən Id-də element tapılmasa `NotFoundException`
5. Extension metodlar `TaskHelper` class-ı
    - Task-ın bitməyinə nə qədər müddət qaldığını qaytaran metod
    - Task üçün nə qədər vaxt ayrıldığını göstərən metod\