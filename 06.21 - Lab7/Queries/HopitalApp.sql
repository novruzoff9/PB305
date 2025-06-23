-- Database yaradılması
Create database HospitalApp
Use HospitalApp

-- Cədvəllərin yaradılması
CREATE TABLE Patients(
    Id INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(20),
    LastName NVARCHAR(25),
    BirthDate DATE CHECK(BirthDate < GETDATE()),
)
CREATE TABLE Departments(
    Id INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(40)
)
CREATE TABLE Doctors(
    Id INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(20),
    LastName NVARCHAR(25),
    Experience INT CHECK(Experience > 0)
)

-- Cədvəllər arasında əlaqələrin yaradılması
CREATE TABLE DoctorDepartments(
    DoctorId INT FOREIGN KEY REFERENCES Doctors(Id),
    DepartmentId INT FOREIGN KEY REFERENCES Departments(Id),
    PRIMARY KEY(DoctorId, DepartmentId),
)
CREATE TABLE Appointments(
    Id INT PRIMARY KEY IDENTITY,
    PatientId INT FOREIGN KEY REFERENCES Patients(Id),
    DoctorId INT FOREIGN KEY REFERENCES Doctors(Id),
    Meetday DATE,
    Result NVARCHAR(20),
)
-- Cədvəllərin yaradılması üçün məlumatların daxil edilməsi
INSERT INTO Patients (FirstName, LastName, BirthDate) VALUES
('Aysel', 'Məmmədova', '1995-04-10'),
('Elvin', 'Quliyev', '1990-08-23'),
('Nigar', 'Əliyeva', '2000-12-05');

INSERT INTO Departments (Name) VALUES
('Kardiologiya'),
('Nevrologiya'),
('Pediatriya');

INSERT INTO Doctors (FirstName, LastName, Experience) VALUES
('Rəşad', 'Hüseynov', 10),
('Ləman', 'Səfərova', 5),
('Kamran', 'Əlizadə', 7);

INSERT INTO DoctorDepartments (DoctorId, DepartmentId) VALUES
(1, 1),  -- Rəşad → Kardiologiya
(2, 2),  -- Ləman → Nevrologiya
(3, 3),  -- Kamran → Pediatriya
(1, 2);  -- Rəşad həmçinin Nevrologiya-da da işləyir
 
INSERT INTO Appointments (PatientId, DoctorId, Meetday, Result) VALUES
(1, 1, '2025-06-01', 'Yaxşılaşır'),
(2, 2, '2025-06-10', 'Müalicə davam edir'),
(3, 3, '2025-06-15', 'Əla nəticə'),
(1, 2, '2025-06-18', 'Yenidən baxış');


-- Məlumatların sorğulanması
-- Həkimlərin və onların departamentlərinin siyahısı
SELECT * FROM DoctorDepartments dd
JOIN Doctors d
ON d.Id = dd.DoctorId
JOIN Departments dep
ON dep.Id = dd.DepartmentId

-- Xəstələrin və onların görüşdükləri həkimlərin siyahısı
SELECT * FROM Appointments a
JOIN Patients p
ON p.Id = a.PatientId
JOIN Doctors d
ON d.Id = a.DoctorId

-- Prosedur yaradılması
-- Prosedur xəstənnin nömrəsi ilə görüşləri göstərir
CREATE PROCEDURE CHECKIN @PatientId INT
AS 
BEGIN
    SELECT * FROM Appointments a
    JOIN Patients p
    ON p.Id=a.PatientId
    JOIN Doctors d
    ON d.Id=a.DoctorId
    WHERE(PatientId = @PatientId)
END

EXEC CHECKIN 2

-- Əlavə cədvəllərin yaradılması

CREATE TABLE Medicine(
    Id INT PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(20)
)

-- Dərmanların daxil edilməsi
INSERT INTO Medicine (Name) VALUES
('Paracetamol'),
('Amoksisilin'),
('Ibuprofen'),
('C vitamin'),
('Nurofen');

-- Görüşlər və dərmanlar arasında əlaqənin yaradılması
CREATE TABLE Receipt(
    PRIMARY KEY(AppointmentId, MedicineId),
    AppointmentId INT FOREIGN KEY REFERENCES Appointments(Id),
    MedicineId INT FOREIGN KEY REFERENCES Medicine(Id)
)

INSERT INTO Receipt (AppointmentId, MedicineId) VALUES
(1, 1),  -- 1-ci görüşdə Paracetamol
(1, 2),  -- 1-ci görüşdə Amoksisilin
(2, 3),  -- 2-ci görüşdə Ibuprofen
(3, 1),  -- 3-cü görüşdə Paracetamol
(3, 4),  -- 3-cü görüşdə C vitamin
(4, 5);  -- 4-cü görüşdə Nurofen


-- Görüşlər, xəstələr, dərmanlar və həkimlər arasında əlaqəli məlumatların sorğulanması
SELECT p.FirstName as Patient, m.Name, d.FirstName as Doctor FROM Receipt r
JOIN Appointments pd
ON pd.Id=r.AppointmentsId
JOIN Patients p
ON p.Id=pd.PatientId
JOIN Medicine m
ON m.Id=r.MedicineId
JOIN Doctors d
ON d.Id = pd.DoctorId