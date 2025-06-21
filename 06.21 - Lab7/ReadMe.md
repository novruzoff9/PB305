# Lab 7 - 21 Iyun
## SQL Hospital Management System
1. Aşağıdakı cədvəllər yaradılacaq:
    - Patients 
        - FirstName - maksimum 20 simvol, 
        - LastName - maksimum 25 simvol, 
        - BirthDate - gələcək zaman ola bilməz,
        - Email - təkrarlanmamalıdır
    - Departments 
        - Name - maksimum 40 simvol, təkrarlanmamalıdır,
    - Doctors 
        - FirstName - maksimum 20 simvol, 
        - LastName - maksimum 25 simvol, 
        - Experience (il) - mənfi ola bilməz 
2. Qurulmalı olan relationlar:
    - Bir həkim bir çox departamentdə çalışa bilər. Bir həkimin eyni departamentə təkrar qoşulmasının qarşısı alınmalıdır.
    - Bir xəstə bir çox həkimlə görüşmüş ola bilər. Görüşün tarixi və Görüş nəticəsi qeyd olunmalıdır.
3. Hər cədvəl üçün bir neçə insert sorğusu
4. Join sorğuları:
    - Həkimlərin şöbələri ilə birlikdə siyahısı
    - Xəstələrin tibbi qeydləri və müalicə edən həkimlər
5. View-lar:
    
6. Store Procedures:
    - Pasient-in Id-si göndəriləcək və ona hansı tarixdə hansı həkim tərəfindən nə diaqnoz qoyulduğu göstəriləcək
    - Həkim-in Id-si göndəriləcək və bu gün kimlərlə görüşməli olduği siyahı olaraq çıxacaq
7. Əlavə cədvəllər:
    - Dərman:
        - Adı
8. Əlavə Relationlar:
    Hər bir görüşün nəticəsi olaraq pasiyentə bir neçə dərman yazıla bilər.
9. Join sorğuları:
    - Hər bir pasiyentə ona yazılmış dərmanların siyahısı
    - Həkimlərin hansı xəstələrə hansı dərmanları yazdığnı göstər