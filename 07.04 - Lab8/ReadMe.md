# Lab 8 - 4 Iyul
## N-Tier Arxitektura Console App
N-Tier arxitektura ilə Sadə bir Console App layihəsənin hazırlanması

>[!Note]
>Aşağıda bir neçə sadə layihə ideyası mövcuddur.

1. N-Tier arxitektura üçün layihələrin qurulması və referansların verilməsi
2. Core layer-da database modellərinin yazılması
3. Data Access Layer-da Database ilə əlaqənin qurulması və konfiqurasiyaların yazılması
4. Generic Repository-lərin yazılması (Mümkün olduğu qədər Async)
5. Business Layer-da servislərin yazılması (Mümkün olduğu qədər Async)
6. Servisləri DTO-larla istifadə etmək
7. Presentation Layer-da Servisləri çağıraraq əməliyyatları icra etmək

## Sadə Layihə İdeyaları

Aşağıda N-Tier arxitektura üçün sadə, lakin sonradan genişləndirilə bilən layihə ideyaları verilmişdir:

1. **Maşın Brendləri və Modelləri**
    - `Brand` və `Model` class-ları.
    - Bir brendin bir neçə modeli ola bilər.

2. **Ölkələr və Şəhərləri**
    - `Country` və `City` class-ları.
    - Bir ölkənin bir neçə şəhəri ola bilər.

3. **Kitablar və Müəllifləri**
    - `Author` və `Book` class-ları.
    - Bir müəllifin bir neçə kitabı ola bilər.

4. **Kateqoriyalar və Məhsulları**
    - `Category` və `Product` class-ları.
    - Bir kateqoriyada bir neçə məhsul ola bilər.

5. **Universitetlər və Fakültələri**
    - `University` və `Faculty` class-ları.
    - Bir universitetin bir neçə fakültəsi ola bilər.

Bu ideyalar başlanğıc üçün sadədir və gələcəkdə əlavə xüsusiyyətlər və əlaqələr əlavə etməklə böyüdülə bilər.