# PB305 Programming Course Repository

Bu repositorya PB305 kursunun bütün praktiki məşğələlərini və layihələrini ehtiva edir. Kursda C# proqramlaşdırma dilinin əsasları öyrədilir və müxtəlif mövzular üzrə praktiki tapşırıqlar yerinə yetirilir.

## 📚 Kurs Məzmunu

### 🔹 C# Programming Fundamentals

| Tarix | Mövzu | Əlavə |
|-------|--------|-------|
| [25 Aprel](#lab-1---25-aprel) | C# Əsasları, Variable-lar, Loop-lar | [📁 Lab1](./04.25%20-%20Lab1) |
| [2 May](#lab-2---2-may) | Metodlar, Parametrlər, ref/out keywords | [📁 Lab2](./05.02%20-%20Lab2) |
| [8 May](#lab-3---8-may) | String Metodları və Class Konsepti | [📁 Lab3](./05.08%20-%20Lab3) |
| [16 May](#lab-4---16-may) | OOP - Abstract Classes, Inheritance | [📁 Lab4](./05.16%20-%20Lab4) |
| [23 May](#lab-5---23-may) | OOP - Interfaces, Indexers, Extensions | [📁 Lab5](./05.23%20-%20Lab5) |
| [26 May](#lab-lecture-1---26-may) | Collections - List, LINQ | [📁 LabLec1](./05.26%20-%20LabLec1) |
| [27 May](#lab-lecture-2---27-may) | Exception Handling, Custom Exceptions | [📁 LabLec2](./05.27%20-%20LabLec2) |
| [30 May](#lab-6---30-may) | Generics, Custom Collections | [📁 Lab6](./05.30%20-%20Lab6) |
| [3 İyun](#mini-lab-1---3-iyun) | Soft Delete Pattern, Extensions | [📁 LabMini](./06.03%20-%20LabMini) |
| [13 İyun](#lecture-1---13-iyun) | Reflection, Garbage Collection | [📁 Lec1](./06.13%20-%20Lec1) |

### 🔹 SQL Database Fundamentals

| Tarix | Mövzu | Əlavə |
|-------|--------|-------|
| [21 İyun](#lab-7---21-iyun) | SQL DDL/DML, JOINs, Views, Procedures | [📁 Lab7](./06.21%20-%20Lab7) |

### 🔹 ORM Fundamentals

| Tarix | Mövzu | Əlavə |
|-------|--------|-------|
| [4 İyul](#lab-8---04-iyul) | N-Tier, Repository, DTO, ModelConfiguration | [📁 Lab8](./07.04%20-%20Lab8) |

### 🔹 Front-End Development

| Tarix | Mövzu | Əlavə |
|-------|--------|-------|
| [18 İyul](#lab-9---18-iyul) | HTML/CSS, Bootstrap, Responsive Design | [📁 Lab9](./07.18%20-%20Lab9) |
| [25 İyul](#lab-10---25-iyul) | JavaScript Alqoritmlər, Array/String Methods | [📁 Lab10](./07.25%20-%20Lab10) |
| [1 Avqust](#lab-11---01-avqust) | JavaScript DOM, Events, Projects | [📁 Lab11](./08.01%20-%20Lab11) |

### 🔹 ASP.NET MVC

| Tarix | Mövzu | Əlavə |
|-------|--------|-------|
| [15 Avqust](#lab-12---15-avqust) | MVC Pattern, Razor Pages, Views | [📁 Lab12](./08.15%20-%20Lab12) |
| [19 Sentyabr](#lab-13---19-sentyabr) | MVC Advanced, EF Core, CRUD | [📁 Lab13](./09.19%20-%20Lab13) |

### 🔹 Advanced Architecture

| Tarix | Mövzu | Əlavə |
|-------|--------|-------|
| [26 Sentyabr](#lab-14---26-sentyabr) | Onion Architecture, Docker, PostgreSQL | [📁 Lab14](./09.26%20-%20Lab14) |

### 🔹 Final Projects

| Tarix | Mövzu | Əlavə |
|-------|--------|-------|
| [Final Project](#final-project---next-js) | Next.js, TypeScript, Shadcn UI, Authentication | [📁 FinalFront](./FinalFront) |

---

## 📋 Dərs Detayları

### Lab 1 - 25 Aprel
**📖 C# Əsasları - Variables, Conditions, Loops**
- Variable-ların elanı və istifadəsi
- Conditional statements (if/else, switch)
- Loop strukturları (for, while)
- Faktorial hesablama, Fibonacci ardıcıllığı
- Parol yoxlama sistemi

**🔗 Folder:** [04.25 - Lab1](./04.25%20-%20Lab1)

---

### Lab 2 - 2 May
**📖 Metodlar və Parametrlər**
- Metodların yazılması və çağırılması
- `params` keyword-unun istifadəsi
- `ref` və `out` parametrləri
- Default parametrlər
- Array manipulyasiyası

**🔗 Folder:** [05.02 - Lab2](./05.02%20-%20Lab2)

---

### Lab 3 - 8 May
**📖 String Metodları və Class Konsepti**
- String manipulyasiya metodları
- Email validasiyası və format düzəltmə
- İlk Class yaratma (`Order` class)
- Constructor-lar
- Inheritance (`OnlineOrder : Order`)

**🔗 Folder:** [05.08 - Lab3](./05.08%20-%20Lab3)

---

### Lab 4 - 16 May
**📖 OOP - Abstract Classes və Inheritance**
- Abstract class konsepti (`Food` abstract class)
- Property validasiyası və encapsulation
- Concrete class-lar (`Pizza : Food`)
- Interface-lər (`IFoodService`, `IPizzaService`)
- Service pattern implementasiyası

**🔗 Folder:** [05.16 - Lab4](./05.16%20-%20Lab4)

---

### Lab 5 - 23 May
**📖 OOP - Interfaces, Indexers, Extensions**
- Bank kart sistemi
- Abstract class və sealed class-lar
- Indexer implementasiyası
- Extension metodlar
- Custom Exception-lar (`ConflictException`)

**🔗 Folder:** [05.23 - Lab5](./05.23%20-%20Lab5)

---

### Lab Lecture 1 - 26 May
**📖 Collections - List və LINQ**
- Generic Collections (`List<T>`)
- LINQ metodları (`Where`, `OrderBy`, `FirstOrDefault`)
- Library management system
- Exception handling
- Book cataloging sistemi

**🔗 Folder:** [05.26 - LabLec1](./05.26%20-%20LabLec1)

---

### Lab Lecture 2 - 27 May
**📖 Exception Handling və Custom Exceptions**
- Task Management System
- Custom Exception-lar (`ConflictException`, `NotFoundException`)
- Extension metodlar (`TaskHelper`)
- Enum-lar və onların istifadəsi
- GUID və DateTime manipulyasiyası

**🔗 Folder:** [05.27 - LabLec2](./05.27%20-%20LabLec2)

---

### Lab 6 - 30 May
**📖 Generics və Custom Collections**
- Generic class yaratma (`MyCustomList<T>`)
- Indexer implementation
- Array resizing və memory management
- Inheritance chain (`Student : Person`)
- Generic type constraints

**🔗 Folder:** [05.30 - Lab6](./05.30%20-%20Lab6)

---

### Mini Lab 1 - 3 İyun
**📖 Soft Delete Pattern və Advanced Extensions**
- Soft Delete pattern implementasiyası
- Extension metodlar advanced istifadəsi
- `IsDeleted` flag pattern
- Product management system
- Lambda expressions və predicate-lər

**🔗 Folder:** [06.03 - LabMini](./06.03%20-%20LabMini)

---

### Lecture 1 - 13 İyun
**📖 Reflection və Garbage Collection**
- Reflection API istifadəsi
- Runtime-da type information əldə etmə
- Property və method manipulation
- Attribute-larla işləmə
- Garbage Collection və memory management
- `using` statement və IDisposable pattern

**🔗 Folder:** [06.13 - Lec1](./06.13%20-%20Lec1)

---

### Lab 7 - 21 İyun
**📖 SQL Database ilə Xəstəxana Sistemi**
- DDL, DML komandaları
- SQL Constraints və Keys
- JOIN operations (Inner, Left, Right, Full, Self, Cross)
- Set operations (Union, Union All, Except, Intersect)
- Date functions və manipulation
- Views, Stored Procedures, Functions
- Xəstəxana sisteminin verilənlər bazası qurulması

**🔗 Folder:** [06.21 - Lab7](./06.21%20-%20Lab7)

---

### Lab 8 - 4 İyul
**📖 N-Tier arxitektura ilə sadə layihə**
- N-Tier Arxitekura
- Generic Repository
- Database Configuration
- Data Transfer Objects (DTO)

**🔗 Folder:** [07.04 - Lab8](./07.04%20-%20Lab8)

---

### Lab 9 - 18 İyul
**📖 HTML/CSS və Bootstrap ilə Portfolio**
- HTML5 semantic elementlər
- CSS3 styling və animations
- Bootstrap framework
- Responsive design prinsipləri
- Flexbox və Grid layout
- Font Awesome icons
- Portfolio page dizaynı

**🔗 Folder:** [07.18 - Lab9](./07.18%20-%20Lab9)

---

### Lab 10 - 25 İyul
**📖 JavaScript ilə Alqoritmlər**
- Conditional Statements (if/else, switch/case)
- Loops (for, while) və alqoritmlər
- Arrays və Array Methods (filter, map, reduce, etc.)
- Objects və property manipulation
- String Methods və string alqoritmləri
- Səviyyəli tapşırıqlar (Sadə, Orta, Çətin)
- Mini proyektlər (Calculator, Library, TodoManager)

**🔗 Folder:** [07.25 - Lab10](./07.25%20-%20Lab10)

---

### Lab 11 - 1 Avqust
**📖 JavaScript DOM Manipulation və Projects**
- DOM Selection və Manipulation
- Event Handling (click, input, submit, etc.)
- Form Validation
- LocalStorage istifadəsi
- **Layihələr:**
  - Form Validation (input validation, error messages)
  - Live Search (real-time filtering)
  - Quiz Application (interactive quiz)
  - Timer Application (countdown/stopwatch)

**🔗 Folder:** [08.01 - Lab11](./08.01%20-%20Lab11)

---

### Lab 12 - 15 Avqust
**📖 ASP.NET MVC - SnapFolio Portfolio**
- ASP.NET Core MVC pattern
- Razor Pages və View Engine
- Model-View-Controller arxitekturası
- Routing və navigation
- Layout pages və partial views
- Static files və wwwroot
- Bootstrap integration
- Portfolio website yaratmaq

**🔗 Folder:** [08.15 - Lab12](./08.15%20-%20Lab12)

---

### Lab 13 - 19 Sentyabr
**📖 ASP.NET MVC Advanced - Car Management**
- Entity Framework Core
- Code-First approach
- CRUD operations
- Data annotations
- Model validation
- Repository pattern
- Dependency Injection
- Car management system

**🔗 Folder:** [09.19 - Lab13](./09.19%20-%20Lab13)

---

### Lab 14 - 26 Sentyabr
**📖 Onion Architecture - Clean Architecture**
- Onion Architecture prinsipləri
- Layer separation (Domain, Application, Infrastructure, Presentation)
- Dependency Injection advanced
- Repository və Unit of Work patterns
- AutoMapper və DTO mapping
- Entity Framework Core advanced
- Docker containerization
- PostgreSQL database
- JWT Authentication
- Soft Delete pattern
- Book və Author management system

**🔗 Folder:** [09.26 - Lab14](./09.26%20-%20Lab14)

---

### Final Project - Next.js
**📖 Next.js Full-Stack Application**
- **Framework:** Next.js 14+ (App Router)
- **Language:** TypeScript
- **UI Library:** Shadcn UI, Radix UI
- **Styling:** Tailwind CSS
- **State Management:** React Context API
- **Form Handling:** React Hook Form, Zod validation
- **Authentication:** JWT Token based
- **Features:**
  - User authentication (Login/Register)
  - Author management (CRUD)
  - Book management (CRUD)
  - User profile
  - Responsive design
  - Dark/Light theme
  - Server-side rendering
  - API integration

**🔗 Folder:** [FinalFront](./FinalFront)

---

##  Əlaqə və Dəstək

Bu repositorya üzrə suallarınız və ya tövsiyələriniz varsa, mentorla əlaqə saxlaya bilərsiniz.

**Repository URL:** [https://github.com/novruzoff9/PB305](https://github.com/novruzoff9/PB305)

---

>[!NOTE] 
>Hər dərsin folder-ında həmin dərsin məşğələsi üçün ayrıca README fayl mövcuddur. Detaylı tapşırıqları görmək üçün müvafiq folder-a baxın.