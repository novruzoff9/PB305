# Lab 14 - 26 Sentyabr
## Onion Architecture - Kitab İdarəetmə Sistemi

### Layihə Haqqında
Bu layihə **Onion Architecture** prinsiplərinə əsasən hazırlanmış **Kitab və Müəllif İdarəetmə Sistemi**dir. Layihə ASP.NET Core Web API, Entity Framework Core və PostgreSQL istifadə edərək hazırlanıb.

---

## 📂 Layihə Strukturu

```
Pb305OnionArc.sln
├── src/
│   ├── Core/                                    (Domain və Application Layers)
│   │   ├── Pb305OnionArc.Domain/               (Entity-lər, Enum-lar, Exceptions)
│   │   │   ├── Models/
│   │   │   │   ├── AppUser.cs
│   │   │   │   ├── Author.cs
│   │   │   │   ├── Book.cs
│   │   │   │   └── Order.cs
│   │   │   ├── Enums/
│   │   │   ├── Exceptions/
│   │   │   ├── Common/                         (Base Entity, Interfaces)
│   │   │   └── ValueObjects/
│   │   │
│   │   └── Pb305OnionArc.Application/          (Business Logic, Services, DTOs)
│   │       ├── Services/
│   │       │   ├── Abstractions/               (Interface-lər)
│   │       │   └── Concretes/                  (Service implementations)
│   │       ├── Common/
│   │       │   ├── Interfaces/
│   │       │   ├── Models/                     (DTOs)
│   │       │   │   ├── Author/
│   │       │   │   ├── Identity/
│   │       │   │   └── Response/
│   │       │   └── Mappers/                    (AutoMapper Profiles)
│   │       └── DependencyInjection.cs
│   │
│   ├── Infrastructure/                          (External Dependencies)
│   │   ├── Pb305OnionArc.Persistance/          (Database, Repositories)
│   │   │   ├── Data/                           (DbContext)
│   │   │   ├── Configurations/                 (Fluent API)
│   │   │   ├── Migrations/
│   │   │   ├── Interceptors/                   (EF Core Interceptors)
│   │   │   └── DependencyInjection.cs
│   │   │
│   │   └── Pb305OnionArc.Infrastructure/       (Email, SMS, Cloud Services)
│   │       ├── Services/
│   │       └── DependencyInjection.cs
│   │
│   └── Presentation/                            (API Layer)
│       └── Pb305OnionArc.WebAPI/
│           ├── Controllers/
│           │   ├── AuthorController.cs
│           │   └── IdentityController.cs
│           ├── Middlewares/
│           ├── Program.cs
│           ├── appsettings.json
│           └── Dockerfile
│
└── docker-compose.yml
```

---

## 🎯 Onion Architecture Qatları

### 1. **Domain Layer** (Ən daxili qat)
- **Məqsəd:** Business entity-lərini və domain məntiqini saxlayır
- **Asılılıq:** Heç bir xarici asılılığı yoxdur
- **Tərkib:**
  - Entity-lər (Book, Author, Order, AppUser)
  - Enum-lar (BookStatus və s.)
  - Domain Exceptions
  - Value Objects
  - Base Entity və Interface-lər (ISoftDeletable, IAuditableEntity)

**Nümunə Entity:**
```csharp
public class Author : BaseEntity, ISoftDeletable
{
    public string Name { get; private set; }
    public DateTime BirthDate { get; init; }
    public List<Book>? Books { get; private set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
    public string? DeletedBy { get; set; }
}
```

### 2. **Application Layer**
- **Məqsəd:** Business logic və application xidmətlərini təmin edir
- **Asılılıq:** Yalnız Domain layer-dən asılıdır
- **Tərkib:**
  - Service Interface-ləri (IAuthorService, IIdentityService)
  - Service Implementations
  - DTOs (Data Transfer Objects)
  - Mapper Profiles (AutoMapper)
  - Repository Interface-ləri

**Funksiyalar:**
- CRUD əməliyyatları üçün business məntiq
- Validation qaydaları
- DTO transformasiyası
- Exception handling

### 3. **Infrastructure Layer**

#### a) **Persistance** (Data Access)
- **Məqsəd:** Database əlaqələri və data saxlanması
- **Asılılıq:** Domain və Application layer-dən
- **Tərkib:**
  - DbContext
  - Repository implementations
  - EF Core Configurations (Fluent API)
  - Migrations
  - Interceptors (Audit, Soft Delete)

#### b) **Infrastructure** (External Services)
- **Məqsəd:** Xarici servislərlə inteqrasiya
- **Tərkib:**
  - Email servisi
  - SMS servisi
  - Cloud storage
  - Cache servisi

### 4. **Presentation Layer (WebAPI)**
- **Məqsəd:** HTTP API endpoints təqdim edir
- **Asılılıq:** Application layer-dən
- **Tərkib:**
  - Controllers
  - Middlewares
  - Program.cs (DI konfiqurasiyası)
  - appsettings.json

---

## 🔧 İstifadə olunan Texnologiyalar

- **Framework:** ASP.NET Core 8.0
- **ORM:** Entity Framework Core
- **Database:** PostgreSQL
- **Authentication:** JWT Bearer Token
- **Mapping:** AutoMapper
- **Containerization:** Docker
- **API Documentation:** Swagger/OpenAPI

---

## 📦 NuGet Paketləri

### Domain Layer
```xml
<!-- Heç bir xarici paket yoxdur -->
```

### Application Layer
```xml
<PackageReference Include="AutoMapper" />
<PackageReference Include="FluentValidation" />
```

### Persistance Layer
```xml
<PackageReference Include="Microsoft.EntityFrameworkCore" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Design" />
<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" />
```

### WebAPI Layer
```xml
<PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" />
<PackageReference Include="Swashbuckle.AspNetCore" />
```

---

## 🚀 Layihəni İşə Salmaq

### 1. Tələblər
- .NET 8.0 SDK
- Docker Desktop
- PostgreSQL (və ya Docker ilə)
- Visual Studio 2022 / VS Code

### 2. Database Konfiqurasiyası

**appsettings.json:**
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=Pb305OnionArcDb;Username=postgres;Password=yourpassword"
  }
}
```

### 3. Migration Əlavə Etmək

```powershell
# Package Manager Console-da
Add-Migration InitialCreate -Project Pb305OnionArc.Persistance -StartupProject Pb305OnionArc.WebAPI

# Database-i update etmək
Update-Database -Project Pb305OnionArc.Persistance -StartupProject Pb305OnionArc.WebAPI
```

### 4. Docker ilə İşə Salmaq

```powershell
# Docker Compose ilə başlatmaq
docker-compose up -d

# Logları görmək
docker-compose logs -f

# Dayandırmaq
docker-compose down
```

### 5. Visual Studio-dan İşə Salmaq

1. `Pb305OnionArc.sln` faylını açın
2. Startup Project: `Pb305OnionArc.WebAPI`
3. F5 basın və ya Play düyməsinə klikləyin
4. Swagger UI açılacaq: `https://localhost:5001/swagger`

---

## 📚 API Endpoints

### Author Controller

| Method | Endpoint | Təsvir |
|--------|----------|--------|
| GET | `/api/authors` | Bütün müəllifləri gətir |
| GET | `/api/authors/{id}` | ID-yə görə müəllif gətir |
| POST | `/api/authors` | Yeni müəllif yarat |
| PUT | `/api/authors/{id}` | Müəllifi yenilə |
| DELETE | `/api/authors/{id}` | Müəllifi sil (Soft Delete) |

### Identity Controller

| Method | Endpoint | Təsvir |
|--------|----------|--------|
| POST | `/api/identity/register` | Yeni istifadəçi qeydiyyatı |
| POST | `/api/identity/login` | Giriş (JWT token alır) |
| POST | `/api/identity/refresh` | Token yeniləmək |

---

## 🎓 Dependency Injection Pattern

Hər bir layer özünün `DependencyInjection.cs` faylına malikdir:

**Application Layer:**
```csharp
public static IServiceCollection AddApplicationServices(this IServiceCollection services)
{
    services.AddAutoMapper(Assembly.GetExecutingAssembly());
    services.AddScoped<IAuthorService, AuthorService>();
    return services;
}
```

**Persistance Layer:**
```csharp
public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    
    services.AddScoped<IAuthorRepository, AuthorRepository>();
    return services;
}
```

**Program.cs-də istifadə:**
```csharp
builder.Services.AddApplicationServices();
builder.Services.AddPersistanceServices(builder.Configuration);
builder.Services.AddInfrastructureServices();
```

---

## ✅ Onion Architecture Prinsipləri

### 1. **Dependency Rule (Asılılıq Qaydası)**
- Xarici qatlar daxili qatlara asılı ola bilər
- Daxili qatlar xarici qatlardan xəbərsiz olmalıdır
- Domain layer heç nəyə asılı deyil ✓

### 2. **Separation of Concerns (Məsuliyyət Ayrılması)**
- Hər layer öz məsuliyyətinə malikdir
- Domain → Business entities
- Application → Business logic
- Infrastructure → Technical concerns
- Presentation → User interface

### 3. **Testability (Test edilə bilməzlik)**
- Hər layer ayrıca test edilə bilər
- Dependency Injection istifadə edilir
- Interface-lər sayəsində mocking mümkündür

### 4. **Maintainability (Saxlanıla bilməzlik)**
- Kod təşkili aydın və strukturludur
- Dəyişikliklər asanlıqla edilir
- Yeni funksiyalar əlavə etmək sadədir

---

## 🔐 Authentication və Authorization

Layihədə JWT (JSON Web Token) əsaslı autentifikasiya istifadə olunur:

```csharp
// Login zamanı token yaradılır
var token = await _identityService.LoginAsync(loginDto);

// Header-də göndərilir
Authorization: Bearer {token}

// Controller-də istifadə
[Authorize]
[ApiController]
public class AuthorController : ControllerBase
{
    // ...
}
```

---

## 📝 Soft Delete Pattern

Məlumatlar fiziki olaraq silinmir, yalnız işarələnir:

```csharp
public interface ISoftDeletable
{
    bool IsDeleted { get; set; }
    DateTime? DeletedAt { get; set; }
    string? DeletedBy { get; set; }
}

public void SoftDelete(string deletedBy)
{
    IsDeleted = true;
    DeletedAt = DateTime.UtcNow;
    DeletedBy = deletedBy;
}
```

---

## 🎯 Öyrənilən Mövzular

✅ Onion Architecture strukturu  
✅ Layered Architecture prinsipləri  
✅ Dependency Injection Pattern  
✅ Repository Pattern  
✅ Unit of Work Pattern  
✅ DTO (Data Transfer Object)  
✅ AutoMapper istifadəsi  
✅ Entity Framework Core  
✅ Fluent API konfiqurasiyası  
✅ JWT Authentication  
✅ Soft Delete Pattern  
✅ Docker containerization  
✅ RESTful API design  

---

## 📖 Əlavə Resurslar

- [Clean Architecture by Robert C. Martin](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
- [Onion Architecture](https://jeffreypalermo.com/2008/07/the-onion-architecture-part-1/)
- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

---

## 👨‍💻 Müəllim: 
**PB305 Group**

**Tarix:** 26 Sentyabr 2024

---

## 📌 Qeydlər

- Bu layihə tələbələrə Onion Architecture konsepsiyasını praktiki olaraq öyrətmək üçün nümunə layihədir
- Real production mühitində əlavə təhlükəsizlik və performans optimizasiyaları tələb olunur
- Layihə genişləndirilə bilər: Book CRUD, Order management, Search functionality və s.

**Uğurlar!** 🚀
