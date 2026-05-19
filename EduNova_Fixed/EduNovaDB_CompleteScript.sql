-- ============================================================
-- EduNovaDB Complete SQL Script
-- School Management System Database
-- Compatible with: SQL Server 2016+ / SSMS
-- Run this entire script in one go
-- ============================================================

-- Step 1: Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'EduNovaDB')
    CREATE DATABASE EduNovaDB;
GO

USE EduNovaDB;
GO

-- ============================================================
-- DROP EXISTING OBJECTS (for clean re-runs during development)
-- ============================================================
IF OBJECT_ID('sp_LoginUser','P') IS NOT NULL DROP PROCEDURE sp_LoginUser;
IF OBJECT_ID('sp_GetUserPermissions','P') IS NOT NULL DROP PROCEDURE sp_GetUserPermissions;
IF OBJECT_ID('sp_GetDashboardCounts','P') IS NOT NULL DROP PROCEDURE sp_GetDashboardCounts;
IF OBJECT_ID('sp_Student_Insert','P') IS NOT NULL DROP PROCEDURE sp_Student_Insert;
IF OBJECT_ID('sp_Student_Update','P') IS NOT NULL DROP PROCEDURE sp_Student_Update;
IF OBJECT_ID('sp_Student_Delete','P') IS NOT NULL DROP PROCEDURE sp_Student_Delete;
IF OBJECT_ID('sp_Student_GetById','P') IS NOT NULL DROP PROCEDURE sp_Student_GetById;
IF OBJECT_ID('sp_Student_GetAll','P') IS NOT NULL DROP PROCEDURE sp_Student_GetAll;
IF OBJECT_ID('sp_Teacher_Insert','P') IS NOT NULL DROP PROCEDURE sp_Teacher_Insert;
IF OBJECT_ID('sp_Teacher_Update','P') IS NOT NULL DROP PROCEDURE sp_Teacher_Update;
IF OBJECT_ID('sp_Teacher_Delete','P') IS NOT NULL DROP PROCEDURE sp_Teacher_Delete;
IF OBJECT_ID('sp_Teacher_GetById','P') IS NOT NULL DROP PROCEDURE sp_Teacher_GetById;
IF OBJECT_ID('sp_Teacher_GetAll','P') IS NOT NULL DROP PROCEDURE sp_Teacher_GetAll;
IF OBJECT_ID('sp_SetTeacherActiveStatus','P') IS NOT NULL DROP PROCEDURE sp_SetTeacherActiveStatus;
IF OBJECT_ID('sp_CreateOrUpdateScheduleConfig','P') IS NOT NULL DROP PROCEDURE sp_CreateOrUpdateScheduleConfig;
IF OBJECT_ID('sp_GenerateTimeSlotsFromConfig','P') IS NOT NULL DROP PROCEDURE sp_GenerateTimeSlotsFromConfig;
IF OBJECT_ID('sp_TimetableEntry_CRUD','P') IS NOT NULL DROP PROCEDURE sp_TimetableEntry_CRUD;
IF OBJECT_ID('sp_RequestTeacherLeave','P') IS NOT NULL DROP PROCEDURE sp_RequestTeacherLeave;
IF OBJECT_ID('sp_FindSubstituteTeacher','P') IS NOT NULL DROP PROCEDURE sp_FindSubstituteTeacher;
IF OBJECT_ID('sp_AssignSubstitution','P') IS NOT NULL DROP PROCEDURE sp_AssignSubstitution;
IF OBJECT_ID('sp_ReplaceTeacherWizard','P') IS NOT NULL DROP PROCEDURE sp_ReplaceTeacherWizard;
IF OBJECT_ID('sp_SaveAttendance','P') IS NOT NULL DROP PROCEDURE sp_SaveAttendance;
IF OBJECT_ID('sp_CreateExam','P') IS NOT NULL DROP PROCEDURE sp_CreateExam;
IF OBJECT_ID('sp_SaveMarks','P') IS NOT NULL DROP PROCEDURE sp_SaveMarks;
IF OBJECT_ID('sp_GetExamResultReport','P') IS NOT NULL DROP PROCEDURE sp_GetExamResultReport;
IF OBJECT_ID('sp_GenerateFeeVouchers','P') IS NOT NULL DROP PROCEDURE sp_GenerateFeeVouchers;
IF OBJECT_ID('sp_PayFeeVoucher','P') IS NOT NULL DROP PROCEDURE sp_PayFeeVoucher;
IF OBJECT_ID('sp_GetFeeDueStudents','P') IS NOT NULL DROP PROCEDURE sp_GetFeeDueStudents;
IF OBJECT_ID('sp_Library_IssueBook','P') IS NOT NULL DROP PROCEDURE sp_Library_IssueBook;
IF OBJECT_ID('sp_Library_ReturnBook','P') IS NOT NULL DROP PROCEDURE sp_Library_ReturnBook;
IF OBJECT_ID('sp_CreateNotification','P') IS NOT NULL DROP PROCEDURE sp_CreateNotification;
IF OBJECT_ID('sp_GetUnreadNotifications','P') IS NOT NULL DROP PROCEDURE sp_GetUnreadNotifications;
IF OBJECT_ID('vwStudentSummary','V') IS NOT NULL DROP VIEW vwStudentSummary;
IF OBJECT_ID('vwFeeStatus','V') IS NOT NULL DROP VIEW vwFeeStatus;
IF OBJECT_ID('vwExamResults','V') IS NOT NULL DROP VIEW vwExamResults;
IF OBJECT_ID('vwTeacherScheduleToday','V') IS NOT NULL DROP VIEW vwTeacherScheduleToday;
IF OBJECT_ID('vwClassTimetableToday','V') IS NOT NULL DROP VIEW vwClassTimetableToday;
GO

-- ============================================================
-- 1. ENUM/DIMENSION TABLES
-- ============================================================

IF OBJECT_ID('AttendanceStatus','U') IS NULL
CREATE TABLE AttendanceStatus(
    StatusId INT PRIMARY KEY,
    StatusName NVARCHAR(20)
);
IF NOT EXISTS(SELECT 1 FROM AttendanceStatus)
INSERT INTO AttendanceStatus VALUES (1,'Present'),(2,'Absent'),(3,'Late'),(4,'Leave');

IF OBJECT_ID('ExamType','U') IS NULL
CREATE TABLE ExamType(
    ExamTypeId INT PRIMARY KEY,
    TypeName NVARCHAR(20)
);
IF NOT EXISTS(SELECT 1 FROM ExamType)
INSERT INTO ExamType VALUES (1,'Monthly'),(2,'HalfBook'),(3,'FullBook');

IF OBJECT_ID('PaymentMethod','U') IS NULL
CREATE TABLE PaymentMethod(
    PaymentMethodId INT PRIMARY KEY,
    MethodName NVARCHAR(30)
);
IF NOT EXISTS(SELECT 1 FROM PaymentMethod)
INSERT INTO PaymentMethod VALUES (1,'Cash'),(2,'BankTransfer'),(3,'Online');

IF OBJECT_ID('VoucherStatus','U') IS NULL
CREATE TABLE VoucherStatus(
    StatusId INT PRIMARY KEY,
    StatusName NVARCHAR(20)
);
IF NOT EXISTS(SELECT 1 FROM VoucherStatus)
INSERT INTO VoucherStatus VALUES (1,'Pending'),(2,'Paid'),(3,'Overdue'),(4,'Cancelled');

IF OBJECT_ID('SlotType','U') IS NULL
CREATE TABLE SlotType(
    SlotTypeId INT PRIMARY KEY,
    TypeName NVARCHAR(20)
);
IF NOT EXISTS(SELECT 1 FROM SlotType)
INSERT INTO SlotType VALUES (1,'Lecture'),(2,'Break');

IF OBJECT_ID('UserRole','U') IS NULL
CREATE TABLE UserRole(
    RoleId INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(50)
);
IF NOT EXISTS(SELECT 1 FROM UserRole)
INSERT INTO UserRole (RoleName) VALUES ('Admin'),('Principal'),('Teacher'),('Accountant'),('Librarian');

IF OBJECT_ID('NotificationType','U') IS NULL
CREATE TABLE NotificationType(
    TypeId INT PRIMARY KEY IDENTITY(1,1),
    TypeName NVARCHAR(50)
);
IF NOT EXISTS(SELECT 1 FROM NotificationType)
INSERT INTO NotificationType (TypeName) VALUES ('Info'),('Warning'),('Alert'),('Substitution'),('FeeDue');

IF OBJECT_ID('SubstitutionStatus','U') IS NULL
CREATE TABLE SubstitutionStatus(
    StatusId INT PRIMARY KEY,
    StatusName NVARCHAR(20)
);
IF NOT EXISTS(SELECT 1 FROM SubstitutionStatus)
INSERT INTO SubstitutionStatus VALUES (1,'Pending'),(2,'Assigned'),(3,'Unassigned');

IF OBJECT_ID('BookStatus','U') IS NULL
CREATE TABLE BookStatus(
    StatusId INT PRIMARY KEY,
    StatusName NVARCHAR(20)
);
IF NOT EXISTS(SELECT 1 FROM BookStatus)
INSERT INTO BookStatus VALUES (1,'Available'),(2,'Issued'),(3,'Reserved'),(4,'Lost');

IF OBJECT_ID('LeaveStatus','U') IS NULL
CREATE TABLE LeaveStatus(
    StatusId INT PRIMARY KEY,
    StatusName NVARCHAR(20)
);
IF NOT EXISTS(SELECT 1 FROM LeaveStatus)
INSERT INTO LeaveStatus VALUES (1,'Pending'),(2,'Approved'),(3,'Rejected');

IF OBJECT_ID('Gender','U') IS NULL
CREATE TABLE Gender(
    GenderId INT PRIMARY KEY,
    GenderName NVARCHAR(10)
);
IF NOT EXISTS(SELECT 1 FROM Gender)
INSERT INTO Gender VALUES (1,'Male'),(2,'Female'),(3,'Other');

GO

-- ============================================================
-- 2. MASTER DATA TABLES
-- ============================================================

IF OBJECT_ID('GradeClass','U') IS NULL
CREATE TABLE GradeClass(
    GradeClassId INT PRIMARY KEY IDENTITY(1,1),
    ClassName NVARCHAR(50) NOT NULL,
    Description NVARCHAR(200)
);

IF OBJECT_ID('Section','U') IS NULL
CREATE TABLE Section(
    SectionId INT PRIMARY KEY IDENTITY(1,1),
    SectionName NVARCHAR(50) NOT NULL
);

IF OBJECT_ID('ClassSection','U') IS NULL
CREATE TABLE ClassSection(
    ClassSectionId INT PRIMARY KEY IDENTITY(1,1),
    GradeClassId INT NOT NULL REFERENCES GradeClass(GradeClassId),
    SectionId INT NOT NULL REFERENCES Section(SectionId),
    MaxStudents INT DEFAULT 40,
    IsActive BIT DEFAULT 1,
    UNIQUE(GradeClassId, SectionId)
);

IF OBJECT_ID('SubjectDomain','U') IS NULL
CREATE TABLE SubjectDomain(
    DomainId INT PRIMARY KEY IDENTITY(1,1),
    DomainName NVARCHAR(100) NOT NULL UNIQUE
);

IF OBJECT_ID('Subject','U') IS NULL
CREATE TABLE Subject(
    SubjectId INT PRIMARY KEY IDENTITY(1,1),
    SubjectName NVARCHAR(100) NOT NULL,
    SubjectCode NVARCHAR(20) UNIQUE,
    DomainId INT REFERENCES SubjectDomain(DomainId),
    IsActive BIT DEFAULT 1
);

IF OBJECT_ID('SchoolScheduleConfig','U') IS NULL
CREATE TABLE SchoolScheduleConfig(
    ConfigId INT PRIMARY KEY IDENTITY(1,1),
    EffectiveFrom DATE NOT NULL,
    SchoolStart TIME NOT NULL,
    SchoolEnd TIME NOT NULL,
    LectureDuration INT DEFAULT 40,
    BreakDuration INT DEFAULT 15,
    BreakAfterPeriod INT DEFAULT 3,
    IsActive BIT DEFAULT 1
);

IF OBJECT_ID('TimeSlot','U') IS NULL
CREATE TABLE TimeSlot(
    TimeSlotId INT PRIMARY KEY IDENTITY(1,1),
    ConfigId INT NOT NULL REFERENCES SchoolScheduleConfig(ConfigId),
    PeriodNo INT NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    SlotTypeId INT NOT NULL REFERENCES SlotType(SlotTypeId),
    UNIQUE(ConfigId, PeriodNo)
);

GO

-- ============================================================
-- 3. PERSON TABLES
-- ============================================================

IF OBJECT_ID('Person','U') IS NULL
CREATE TABLE Person(
    PersonId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(200),
    DateOfBirth DATE,
    GenderId INT REFERENCES Gender(GenderId),
    CreatedAt DATETIME DEFAULT GETDATE(),
    CreatedBy NVARCHAR(50),
    UpdatedAt DATETIME,
    UpdatedBy NVARCHAR(50)
);

IF OBJECT_ID('Student','U') IS NULL
CREATE TABLE Student(
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    PersonId INT NOT NULL REFERENCES Person(PersonId),
    AdmissionNo NVARCHAR(30) UNIQUE NOT NULL,
    AdmissionDate DATE NOT NULL DEFAULT GETDATE(),
    Age INT,
    RollNo NVARCHAR(20),
    IsActive BIT DEFAULT 1,
    CONSTRAINT CK_Student_Age CHECK (Age IS NULL OR Age > 0)
);

IF OBJECT_ID('StudentProfile','U') IS NULL
CREATE TABLE StudentProfile(
    ProfileId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL UNIQUE REFERENCES Student(StudentId) ON DELETE CASCADE,
    EmergencyContact NVARCHAR(100),
    BloodGroup NVARCHAR(10),
    MedicalInfo NVARCHAR(500),
    PreviousSchool NVARCHAR(100),
    PhotoPath NVARCHAR(200)
);

IF OBJECT_ID('Guardian','U') IS NULL
CREATE TABLE Guardian(
    GuardianId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL REFERENCES Student(StudentId) ON DELETE CASCADE,
    Name NVARCHAR(100) NOT NULL,
    Relation NVARCHAR(50),
    Phone NVARCHAR(20),
    Occupation NVARCHAR(50),
    CNIC NVARCHAR(20)
);

IF OBJECT_ID('Teacher','U') IS NULL
CREATE TABLE Teacher(
    TeacherId INT PRIMARY KEY IDENTITY(1,1),
    PersonId INT NOT NULL REFERENCES Person(PersonId),
    EmployeeCode NVARCHAR(30) UNIQUE NOT NULL,
    Qualification NVARCHAR(100),
    JoiningDate DATE NOT NULL,
    Salary DECIMAL(18,2),
    IsActive BIT DEFAULT 1,
    EndDate DATE NULL
);

IF OBJECT_ID('TeacherSubject','U') IS NULL
CREATE TABLE TeacherSubject(
    TeacherSubjectId INT PRIMARY KEY IDENTITY(1,1),
    TeacherId INT NOT NULL REFERENCES Teacher(TeacherId) ON DELETE CASCADE,
    SubjectId INT NOT NULL REFERENCES Subject(SubjectId) ON DELETE CASCADE,
    UNIQUE(TeacherId, SubjectId)
);

IF OBJECT_ID('TeacherDomain','U') IS NULL
CREATE TABLE TeacherDomain(
    TeacherDomainId INT PRIMARY KEY IDENTITY(1,1),
    TeacherId INT NOT NULL REFERENCES Teacher(TeacherId) ON DELETE CASCADE,
    DomainId INT NOT NULL REFERENCES SubjectDomain(DomainId) ON DELETE CASCADE,
    PriorityLevel INT DEFAULT 1,
    UNIQUE(TeacherId, DomainId)
);

IF OBJECT_ID('Enrollment','U') IS NULL
CREATE TABLE Enrollment(
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL REFERENCES Student(StudentId) ON DELETE CASCADE,
    ClassSectionId INT NOT NULL REFERENCES ClassSection(ClassSectionId),
    StartDate DATE DEFAULT GETDATE(),
    EndDate DATE NULL,
    AcademicYear NVARCHAR(10),
    IsActive BIT DEFAULT 1,
    UNIQUE(StudentId, AcademicYear)
);

GO

-- ============================================================
-- 4. TIMETABLE & SUBSTITUTION TABLES
-- ============================================================

IF OBJECT_ID('TimetableEntry','U') IS NULL
CREATE TABLE TimetableEntry(
    TimetableEntryId INT PRIMARY KEY IDENTITY(1,1),
    ClassSectionId INT NOT NULL REFERENCES ClassSection(ClassSectionId),
    TimeSlotId INT NOT NULL REFERENCES TimeSlot(TimeSlotId),
    SubjectId INT NOT NULL REFERENCES Subject(SubjectId),
    TeacherId INT NOT NULL REFERENCES Teacher(TeacherId),
    DayOfWeek INT NOT NULL,
    Room NVARCHAR(50),
    IsActive BIT DEFAULT 1,
    UNIQUE(ClassSectionId, DayOfWeek, TimeSlotId),
    CONSTRAINT CK_DayOfWeek CHECK (DayOfWeek BETWEEN 1 AND 7)
);

IF OBJECT_ID('TeacherLeaveRequest','U') IS NULL
CREATE TABLE TeacherLeaveRequest(
    LeaveRequestId INT PRIMARY KEY IDENTITY(1,1),
    TeacherId INT NOT NULL REFERENCES Teacher(TeacherId),
    LeaveDate DATE NOT NULL,
    FromTime TIME NULL,
    ToTime TIME NULL,
    Reason NVARCHAR(200),
    StatusId INT NOT NULL REFERENCES LeaveStatus(StatusId) DEFAULT 1,
    RequestedAt DATETIME DEFAULT GETDATE(),
    ApprovedByUserId INT NULL
);

IF OBJECT_ID('SubstitutionAssignment','U') IS NULL
CREATE TABLE SubstitutionAssignment(
    SubstitutionId INT PRIMARY KEY IDENTITY(1,1),
    TimetableEntryId INT NOT NULL REFERENCES TimetableEntry(TimetableEntryId),
    LeaveDate DATE NOT NULL,
    OriginalTeacherId INT NOT NULL REFERENCES Teacher(TeacherId),
    SubstituteTeacherId INT NULL REFERENCES Teacher(TeacherId),
    Reason NVARCHAR(200),
    StatusId INT NOT NULL REFERENCES SubstitutionStatus(StatusId) DEFAULT 1
);

GO

-- ============================================================
-- 5. ATTENDANCE TABLE
-- ============================================================

IF OBJECT_ID('AttendanceRecord','U') IS NULL
CREATE TABLE AttendanceRecord(
    AttendanceId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL REFERENCES Student(StudentId),
    ClassSectionId INT NOT NULL REFERENCES ClassSection(ClassSectionId),
    AttendanceDate DATE NOT NULL,
    StatusId INT NOT NULL REFERENCES AttendanceStatus(StatusId),
    MarkedBy INT,
    MarkedAt DATETIME DEFAULT GETDATE(),
    UNIQUE(StudentId, AttendanceDate)
);

GO

-- ============================================================
-- 6. EXAM TABLES
-- ============================================================

IF OBJECT_ID('Exam','U') IS NULL
CREATE TABLE Exam(
    ExamId INT PRIMARY KEY IDENTITY(1,1),
    ExamName NVARCHAR(100) NOT NULL,
    ExamTypeId INT NOT NULL REFERENCES ExamType(ExamTypeId),
    ClassSectionId INT NOT NULL REFERENCES ClassSection(ClassSectionId),
    SubjectId INT NOT NULL REFERENCES Subject(SubjectId),
    ExamDate DATE NOT NULL,
    TotalMarks INT NOT NULL,
    IsActive BIT DEFAULT 1,
    CONSTRAINT CK_Exam_TotalMarks CHECK (TotalMarks > 0)
);

IF OBJECT_ID('Mark','U') IS NULL
CREATE TABLE Mark(
    MarksId INT PRIMARY KEY IDENTITY(1,1),
    ExamId INT NOT NULL REFERENCES Exam(ExamId) ON DELETE CASCADE,
    StudentId INT NOT NULL REFERENCES Student(StudentId),
    ObtainedMarks INT NOT NULL,
    Grade NVARCHAR(10),
    UNIQUE(ExamId, StudentId),
    CONSTRAINT CK_Marks_Obtained CHECK (ObtainedMarks >= 0)
);

GO

-- ============================================================
-- 7. FEE TABLES
-- ============================================================

IF OBJECT_ID('FeeStructure','U') IS NULL
CREATE TABLE FeeStructure(
    FeeStructureId INT PRIMARY KEY IDENTITY(1,1),
    ClassSectionId INT NOT NULL UNIQUE REFERENCES ClassSection(ClassSectionId),
    MonthlyFee DECIMAL(18,2) NOT NULL,
    AdmissionFee DECIMAL(18,2) DEFAULT 0,
    MiscFee DECIMAL(18,2) DEFAULT 0,
    CONSTRAINT CK_FeeStructure_MonthlyFee CHECK (MonthlyFee >= 0)
);

IF OBJECT_ID('FeeVoucher','U') IS NULL
CREATE TABLE FeeVoucher(
    VoucherId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT NOT NULL REFERENCES Student(StudentId),
    ClassSectionId INT NOT NULL REFERENCES ClassSection(ClassSectionId),
    Month NVARCHAR(20) NOT NULL,
    Year INT NOT NULL,
    TotalAmount DECIMAL(18,2) NOT NULL,
    DueDate DATE NOT NULL,
    StatusId INT NOT NULL REFERENCES VoucherStatus(StatusId) DEFAULT 1,
    CONSTRAINT CK_FeeVoucher_Total CHECK (TotalAmount >= 0)
);

IF OBJECT_ID('FeePayment','U') IS NULL
CREATE TABLE FeePayment(
    PaymentId INT PRIMARY KEY IDENTITY(1,1),
    VoucherId INT NOT NULL REFERENCES FeeVoucher(VoucherId),
    PaidAmount DECIMAL(18,2) NOT NULL,
    PaidOn DATETIME DEFAULT GETDATE(),
    PaymentMethodId INT REFERENCES PaymentMethod(PaymentMethodId),
    ReceivedBy INT,
    CONSTRAINT CK_FeePayment_Amount CHECK (PaidAmount > 0)
);

GO

-- ============================================================
-- 8. LIBRARY TABLES
-- ============================================================

IF OBJECT_ID('LibraryBook','U') IS NULL
CREATE TABLE LibraryBook(
    BookId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200) NOT NULL,
    ISBN NVARCHAR(20) UNIQUE,
    Author NVARCHAR(100),
    Category NVARCHAR(50),
    TotalCopies INT DEFAULT 1,
    AvailableCopies INT DEFAULT 1,
    StatusId INT REFERENCES BookStatus(StatusId) DEFAULT 1,
    IsActive BIT DEFAULT 1
);

IF OBJECT_ID('BookCopy','U') IS NULL
CREATE TABLE BookCopy(
    CopyId INT PRIMARY KEY IDENTITY(1,1),
    BookId INT NOT NULL REFERENCES LibraryBook(BookId) ON DELETE CASCADE,
    CopyNo NVARCHAR(30),
    IsAvailable BIT DEFAULT 1
);

IF OBJECT_ID('BookIssue','U') IS NULL
CREATE TABLE BookIssue(
    IssueId INT PRIMARY KEY IDENTITY(1,1),
    CopyId INT NOT NULL REFERENCES BookCopy(CopyId),
    StudentId INT NOT NULL REFERENCES Student(StudentId),
    IssuedOn DATE DEFAULT GETDATE(),
    DueDate DATE NOT NULL,
    ReturnedOn DATE NULL,
    Fine DECIMAL(18,2) DEFAULT 0,
    IsReturned BIT DEFAULT 0
);

IF OBJECT_ID('LibraryFinePolicy','U') IS NULL
CREATE TABLE LibraryFinePolicy(
    PolicyId INT PRIMARY KEY IDENTITY(1,1),
    FinePerDay DECIMAL(18,2) DEFAULT 10.00,
    GraceDays INT DEFAULT 2
);

GO

-- ============================================================
-- 9. SECURITY & AUDIT TABLES
-- ============================================================

IF OBJECT_ID('AppUser','U') IS NULL
CREATE TABLE AppUser(
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(64) NOT NULL,
    DisplayName NVARCHAR(100),
    RoleId INT REFERENCES UserRole(RoleId),
    IsActive BIT DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CreatedBy NVARCHAR(50),
    UpdatedAt DATETIME,
    UpdatedBy NVARCHAR(50),
    LastLogin DATETIME
);

IF OBJECT_ID('RolePermission','U') IS NULL
CREATE TABLE RolePermission(
    RolePermissionId INT PRIMARY KEY IDENTITY(1,1),
    RoleId INT NOT NULL REFERENCES UserRole(RoleId) ON DELETE CASCADE,
    PermissionCode NVARCHAR(50) NOT NULL,
    UNIQUE(RoleId, PermissionCode)
);

IF OBJECT_ID('AuditLog','U') IS NULL
CREATE TABLE AuditLog(
    LogId INT PRIMARY KEY IDENTITY(1,1),
    Timestamp DATETIME DEFAULT GETDATE(),
    UserId INT,
    Username NVARCHAR(50),
    Action NVARCHAR(50),
    EntityName NVARCHAR(50),
    EntityId INT,
    Details NVARCHAR(500)
);

IF OBJECT_ID('Notification','U') IS NULL
CREATE TABLE Notification(
    NotificationId INT PRIMARY KEY IDENTITY(1,1),
    ToUserId INT REFERENCES AppUser(UserId),
    Title NVARCHAR(200),
    Message NVARCHAR(500),
    NotificationTypeId INT REFERENCES NotificationType(TypeId),
    IsRead BIT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE()
);

IF OBJECT_ID('NotificationPreference','U') IS NULL
CREATE TABLE NotificationPreference(
    PrefId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL UNIQUE REFERENCES AppUser(UserId),
    EnableInApp BIT DEFAULT 1
);

GO

-- ============================================================
-- INDEXES
-- ============================================================

IF NOT EXISTS(SELECT * FROM sys.indexes WHERE name = 'IX_Student_AdmissionNo')
CREATE NONCLUSTERED INDEX IX_Student_AdmissionNo ON Student(AdmissionNo);

IF NOT EXISTS(SELECT * FROM sys.indexes WHERE name = 'IX_Teacher_EmployeeCode')
CREATE NONCLUSTERED INDEX IX_Teacher_EmployeeCode ON Teacher(EmployeeCode);

IF NOT EXISTS(SELECT * FROM sys.indexes WHERE name = 'IX_TimetableEntry_TeacherTimeSlot')
CREATE NONCLUSTERED INDEX IX_TimetableEntry_TeacherTimeSlot ON TimetableEntry(TeacherId, TimeSlotId, DayOfWeek);

IF NOT EXISTS(SELECT * FROM sys.indexes WHERE name = 'IX_FeeVoucher_StudentMonthYear')
CREATE NONCLUSTERED INDEX IX_FeeVoucher_StudentMonthYear ON FeeVoucher(StudentId, Month, Year);

IF NOT EXISTS(SELECT * FROM sys.indexes WHERE name = 'IX_Attendance_StudentDate')
CREATE NONCLUSTERED INDEX IX_Attendance_StudentDate ON AttendanceRecord(StudentId, AttendanceDate);

IF NOT EXISTS(SELECT * FROM sys.indexes WHERE name = 'IX_AuditLog_Timestamp')
CREATE NONCLUSTERED INDEX IX_AuditLog_Timestamp ON AuditLog(Timestamp);

IF NOT EXISTS(SELECT * FROM sys.indexes WHERE name = 'IX_Notification_UserRead')
CREATE NONCLUSTERED INDEX IX_Notification_UserRead ON Notification(ToUserId, IsRead);

GO

-- ============================================================
-- 10. VIEWS (with JOINs)
-- ============================================================

-- View: Student Summary (JOIN Students + Enrollments + ClassSections + GradeClasses + Sections + Guardians)
CREATE VIEW vwStudentSummary AS
SELECT
    s.StudentId,
    p.FirstName,
    p.LastName,
    p.FirstName + ' ' + p.LastName AS FullName,
    s.AdmissionNo,
    s.RollNo,
    s.Age,
    p.DateOfBirth,
    g.GenderName,
    s.IsActive,
    e.EnrollmentId,
    e.StartDate,
    e.AcademicYear,
    gc.ClassName + ' - ' + sec.SectionName AS ClassSectionName,
    gu.Name AS GuardianName,
    gu.Relation AS GuardianRelation,
    gu.Phone AS GuardianPhone
FROM Student s
INNER JOIN Person p ON s.PersonId = p.PersonId
LEFT JOIN Gender g ON p.GenderId = g.GenderId
LEFT JOIN Enrollment e ON s.StudentId = e.StudentId AND e.IsActive = 1
LEFT JOIN ClassSection cs ON e.ClassSectionId = cs.ClassSectionId
LEFT JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
LEFT JOIN Section sec ON cs.SectionId = sec.SectionId
LEFT JOIN Guardian gu ON s.StudentId = gu.StudentId;
GO

-- View: Fee Status (JOIN vouchers + payments + due calculation)
CREATE VIEW vwFeeStatus AS
SELECT
    fv.VoucherId,
    s.StudentId,
    p.FirstName + ' ' + p.LastName AS StudentName,
    s.AdmissionNo,
    fv.Month,
    fv.Year,
    fv.TotalAmount,
    ISNULL(SUM(fp.PaidAmount), 0) AS PaidAmount,
    fv.TotalAmount - ISNULL(SUM(fp.PaidAmount), 0) AS DueAmount,
    fv.DueDate,
    vs.StatusName,
    CASE WHEN fv.DueDate < GETDATE() AND fv.TotalAmount - ISNULL(SUM(fp.PaidAmount), 0) > 0 THEN 'Overdue' ELSE vs.StatusName END AS ComputedStatus
FROM FeeVoucher fv
INNER JOIN Student s ON fv.StudentId = s.StudentId
INNER JOIN Person p ON s.PersonId = p.PersonId
LEFT JOIN FeePayment fp ON fv.VoucherId = fp.VoucherId
LEFT JOIN VoucherStatus vs ON fv.StatusId = vs.StatusId
GROUP BY fv.VoucherId, s.StudentId, p.FirstName, p.LastName, s.AdmissionNo,
         fv.Month, fv.Year, fv.TotalAmount, fv.DueDate, vs.StatusName;
GO

-- View: Exam Results (JOIN marks + exams + students + subjects + examtypes)
CREATE VIEW vwExamResults AS
SELECT
    m.MarksId,
    s.StudentId,
    per.FirstName + ' ' + per.LastName AS StudentName,
    s.AdmissionNo,
    e.ExamId,
    e.ExamName,
    et.TypeName AS ExamType,
    sub.SubjectName,
    e.TotalMarks,
    m.ObtainedMarks,
    m.Grade,
    CAST(CAST(m.ObtainedMarks AS DECIMAL) * 100 / NULLIF(e.TotalMarks, 0) AS DECIMAL(5,2)) AS Percentage,
    e.ExamDate
FROM Mark m
INNER JOIN Exam e ON m.ExamId = e.ExamId
INNER JOIN Student s ON m.StudentId = s.StudentId
INNER JOIN Person per ON s.PersonId = per.PersonId
INNER JOIN ExamType et ON e.ExamTypeId = et.ExamTypeId
INNER JOIN Subject sub ON e.SubjectId = sub.SubjectId;
GO

-- View: Teacher Schedule Today
CREATE VIEW vwTeacherScheduleToday AS
SELECT
    te.TimetableEntryId,
    te.DayOfWeek,
    ts.PeriodNo,
    ts.StartTime,
    ts.EndTime,
    st.TypeName AS SlotType,
    sub.SubjectName,
    t.TeacherId,
    per.FirstName + ' ' + per.LastName AS TeacherName,
    gc.ClassName + ' - ' + sec.SectionName AS ClassSectionName,
    te.Room
FROM TimetableEntry te
INNER JOIN TimeSlot ts ON te.TimeSlotId = ts.TimeSlotId
INNER JOIN SlotType st ON ts.SlotTypeId = st.SlotTypeId
INNER JOIN Subject sub ON te.SubjectId = sub.SubjectId
INNER JOIN Teacher t ON te.TeacherId = t.TeacherId
INNER JOIN Person per ON t.PersonId = per.PersonId
INNER JOIN ClassSection cs ON te.ClassSectionId = cs.ClassSectionId
INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
INNER JOIN Section sec ON cs.SectionId = sec.SectionId
WHERE te.IsActive = 1
AND t.IsActive = 1;
GO

-- View: Class Timetable Today
CREATE VIEW vwClassTimetableToday AS
SELECT
    te.TimetableEntryId,
    te.DayOfWeek,
    ts.PeriodNo,
    ts.StartTime,
    ts.EndTime,
    st.TypeName AS SlotType,
    sub.SubjectName,
    per.FirstName + ' ' + per.LastName AS TeacherName,
    gc.ClassName + ' - ' + sec.SectionName AS ClassSectionName,
    te.Room,
    cs.ClassSectionId
FROM TimetableEntry te
INNER JOIN TimeSlot ts ON te.TimeSlotId = ts.TimeSlotId
INNER JOIN SlotType st ON ts.SlotTypeId = st.SlotTypeId
INNER JOIN Subject sub ON te.SubjectId = sub.SubjectId
INNER JOIN Teacher t ON te.TeacherId = t.TeacherId
INNER JOIN Person per ON t.PersonId = per.PersonId
INNER JOIN ClassSection cs ON te.ClassSectionId = cs.ClassSectionId
INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
INNER JOIN Section sec ON cs.SectionId = sec.SectionId
WHERE te.IsActive = 1
AND cs.IsActive = 1;
GO


-- ============================================================
-- 11. STORED PROCEDURES
-- ============================================================

-- ============================================
-- SECURITY / ADMIN SPs
-- ============================================

-- sp_LoginUser: Authenticate user and return user info
CREATE PROCEDURE sp_LoginUser
    @Username NVARCHAR(50),
    @PasswordHash NVARCHAR(64)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        u.UserId,
        u.Username,
        u.DisplayName,
        u.RoleId,
        r.RoleName,
        u.IsActive,
        u.LastLogin
    FROM AppUser u
    INNER JOIN UserRole r ON u.RoleId = r.RoleId
    WHERE u.Username = @Username
    AND u.PasswordHash = @PasswordHash
    AND u.IsActive = 1;
    
    -- Update last login
    UPDATE AppUser SET LastLogin = GETDATE() WHERE Username = @Username AND PasswordHash = @PasswordHash;
END;
GO

-- sp_GetUserPermissions: Get all permission codes for a user
CREATE PROCEDURE sp_GetUserPermissions
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT rp.PermissionCode
    FROM RolePermission rp
    INNER JOIN AppUser u ON rp.RoleId = u.RoleId
    WHERE u.UserId = @UserId;
END;
GO

-- ============================================
-- DASHBOARD SPs
-- ============================================

-- sp_GetDashboardCounts: Return summary counts for dashboard
CREATE PROCEDURE sp_GetDashboardCounts
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT
        (SELECT COUNT(*) FROM Student WHERE IsActive = 1) AS TotalStudents,
        (SELECT COUNT(*) FROM Teacher WHERE IsActive = 1) AS TotalTeachers,
        (SELECT COUNT(*) FROM ClassSection WHERE IsActive = 1) AS TotalClassSections,
        (SELECT COUNT(*) FROM Subject WHERE IsActive = 1) AS TotalSubjects,
        (SELECT COUNT(*) FROM LibraryBook WHERE IsActive = 1) AS TotalBooks,
        (SELECT COUNT(*) FROM FeeVoucher WHERE StatusId = 1) AS PendingVouchers,
        (SELECT COUNT(*) FROM SubstitutionAssignment WHERE StatusId = 1 AND LeaveDate = CAST(GETDATE() AS DATE)) AS TodaySubstitutions,
        (SELECT COUNT(*) FROM Notification WHERE IsRead = 0) AS UnreadNotifications,
        (SELECT COUNT(*) FROM TeacherLeaveRequest WHERE StatusId = 1) AS PendingLeaveRequests;
END;
GO

-- ============================================
-- STUDENT CRUD SPs
-- ============================================

-- sp_Student_Insert: Add new student with Person record
CREATE PROCEDURE sp_Student_Insert
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Email NVARCHAR(100),
    @Address NVARCHAR(200),
    @DateOfBirth DATE,
    @GenderId INT,
    @AdmissionNo NVARCHAR(30),
    @Age INT,
    @RollNo NVARCHAR(20),
    @ClassSectionId INT,
    @AcademicYear NVARCHAR(10),
    @GuardianName NVARCHAR(100),
    @GuardianRelation NVARCHAR(50),
    @GuardianPhone NVARCHAR(20),
    @CreatedBy NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- Insert Person
        DECLARE @PersonId INT;
        INSERT INTO Person (FirstName, LastName, Phone, Email, Address, DateOfBirth, GenderId, CreatedAt, CreatedBy)
        VALUES (@FirstName, @LastName, @Phone, @Email, @Address, @DateOfBirth, @GenderId, GETDATE(), @CreatedBy);
        SET @PersonId = SCOPE_IDENTITY();
        
        -- Insert Student
        DECLARE @StudentId INT;
        INSERT INTO Student (PersonId, AdmissionNo, AdmissionDate, Age, RollNo, IsActive)
        VALUES (@PersonId, @AdmissionNo, GETDATE(), @Age, @RollNo, 1);
        SET @StudentId = SCOPE_IDENTITY();
        
        -- Insert Enrollment
        INSERT INTO Enrollment (StudentId, ClassSectionId, StartDate, AcademicYear, IsActive)
        VALUES (@StudentId, @ClassSectionId, GETDATE(), @AcademicYear, 1);
        
        -- Insert Guardian
        IF @GuardianName IS NOT NULL
        BEGIN
            INSERT INTO Guardian (StudentId, Name, Relation, Phone)
            VALUES (@StudentId, @GuardianName, @GuardianRelation, @GuardianPhone);
        END
        
        -- Insert empty StudentProfile
        INSERT INTO StudentProfile (StudentId, EmergencyContact, BloodGroup, MedicalInfo, PreviousSchool, PhotoPath)
        VALUES (@StudentId, NULL, NULL, NULL, NULL, NULL);
        
        COMMIT TRANSACTION;
        SELECT @StudentId AS StudentId;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_Student_Update
CREATE PROCEDURE sp_Student_Update
    @StudentId INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Email NVARCHAR(100),
    @Address NVARCHAR(200),
    @DateOfBirth DATE,
    @GenderId INT,
    @Age INT,
    @RollNo NVARCHAR(20),
    @IsActive BIT,
    @GuardianName NVARCHAR(100),
    @GuardianRelation NVARCHAR(50),
    @GuardianPhone NVARCHAR(20),
    @UpdatedBy NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    
    BEGIN TRY
        DECLARE @PersonId INT;
        SELECT @PersonId = PersonId FROM Student WHERE StudentId = @StudentId;
        
        -- Update Person
        UPDATE Person SET
            FirstName = @FirstName,
            LastName = @LastName,
            Phone = @Phone,
            Email = @Email,
            Address = @Address,
            DateOfBirth = @DateOfBirth,
            GenderId = @GenderId,
            UpdatedAt = GETDATE(),
            UpdatedBy = @UpdatedBy
        WHERE PersonId = @PersonId;
        
        -- Update Student
        UPDATE Student SET
            Age = @Age,
            RollNo = @RollNo,
            IsActive = @IsActive
        WHERE StudentId = @StudentId;
        
        -- Update Guardian
        IF EXISTS(SELECT 1 FROM Guardian WHERE StudentId = @StudentId)
        BEGIN
            UPDATE Guardian SET
                Name = @GuardianName,
                Relation = @GuardianRelation,
                Phone = @GuardianPhone
            WHERE StudentId = @StudentId;
        END
        ELSE IF @GuardianName IS NOT NULL
        BEGIN
            INSERT INTO Guardian (StudentId, Name, Relation, Phone)
            VALUES (@StudentId, @GuardianName, @GuardianRelation, @GuardianPhone);
        END
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_Student_Delete: Soft delete by setting inactive
CREATE PROCEDURE sp_Student_Delete
    @StudentId INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    
    BEGIN TRY
        UPDATE Student SET IsActive = 0 WHERE StudentId = @StudentId;
        UPDATE Enrollment SET IsActive = 0, EndDate = GETDATE() WHERE StudentId = @StudentId AND IsActive = 1;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_Student_GetById
CREATE PROCEDURE sp_Student_GetById
    @StudentId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vwStudentSummary WHERE StudentId = @StudentId;
END;
GO

-- sp_Student_GetAll
CREATE PROCEDURE sp_Student_GetAll
    @Search NVARCHAR(50) = NULL,
    @IsActive BIT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vwStudentSummary
    WHERE (@Search IS NULL OR 
           FullName LIKE '%' + @Search + '%' OR 
           AdmissionNo LIKE '%' + @Search + '%')
    AND (@IsActive IS NULL OR IsActive = @IsActive)
    ORDER BY FullName;
END;
GO

-- ============================================
-- TEACHER CRUD SPs
-- ============================================

-- sp_Teacher_Insert
CREATE PROCEDURE sp_Teacher_Insert
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Email NVARCHAR(100),
    @Address NVARCHAR(200),
    @DateOfBirth DATE,
    @GenderId INT,
    @EmployeeCode NVARCHAR(30),
    @Qualification NVARCHAR(100),
    @JoiningDate DATE,
    @Salary DECIMAL(18,2),
    @SubjectIds NVARCHAR(200) = NULL,
    @CreatedBy NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    
    BEGIN TRY
        -- Insert Person
        DECLARE @PersonId INT;
        INSERT INTO Person (FirstName, LastName, Phone, Email, Address, DateOfBirth, GenderId, CreatedAt, CreatedBy)
        VALUES (@FirstName, @LastName, @Phone, @Email, @Address, @DateOfBirth, @GenderId, GETDATE(), @CreatedBy);
        SET @PersonId = SCOPE_IDENTITY();
        
        -- Insert Teacher
        DECLARE @TeacherId INT;
        INSERT INTO Teacher (PersonId, EmployeeCode, Qualification, JoiningDate, Salary, IsActive, EndDate)
        VALUES (@PersonId, @EmployeeCode, @Qualification, @JoiningDate, @Salary, 1, NULL);
        SET @TeacherId = SCOPE_IDENTITY();
        
        -- Insert TeacherSubjects if provided
        IF @SubjectIds IS NOT NULL AND LEN(@SubjectIds) > 0
        BEGIN
            DECLARE @SubjectId INT;
            DECLARE subject_cursor CURSOR FOR
            SELECT CAST(value AS INT) FROM STRING_SPLIT(@SubjectIds, ',');
            OPEN subject_cursor;
            FETCH NEXT FROM subject_cursor INTO @SubjectId;
            WHILE @@FETCH_STATUS = 0
            BEGIN
                IF NOT EXISTS(SELECT 1 FROM TeacherSubject WHERE TeacherId = @TeacherId AND SubjectId = @SubjectId)
                BEGIN
                    INSERT INTO TeacherSubject (TeacherId, SubjectId) VALUES (@TeacherId, @SubjectId);
                END
                FETCH NEXT FROM subject_cursor INTO @SubjectId;
            END
            CLOSE subject_cursor;
            DEALLOCATE subject_cursor;
        END
        
        COMMIT TRANSACTION;
        SELECT @TeacherId AS TeacherId;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_Teacher_Update
CREATE PROCEDURE sp_Teacher_Update
    @TeacherId INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Email NVARCHAR(100),
    @Address NVARCHAR(200),
    @DateOfBirth DATE,
    @GenderId INT,
    @Qualification NVARCHAR(100),
    @Salary DECIMAL(18,2),
    @IsActive BIT,
    @SubjectIds NVARCHAR(200) = NULL,
    @UpdatedBy NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    
    BEGIN TRY
        DECLARE @PersonId INT;
        SELECT @PersonId = PersonId FROM Teacher WHERE TeacherId = @TeacherId;
        
        -- Update Person
        UPDATE Person SET
            FirstName = @FirstName,
            LastName = @LastName,
            Phone = @Phone,
            Email = @Email,
            Address = @Address,
            DateOfBirth = @DateOfBirth,
            GenderId = @GenderId,
            UpdatedAt = GETDATE(),
            UpdatedBy = @UpdatedBy
        WHERE PersonId = @PersonId;
        
        -- Update Teacher
        UPDATE Teacher SET
            Qualification = @Qualification,
            Salary = @Salary,
            IsActive = @IsActive,
            EndDate = CASE WHEN @IsActive = 0 THEN GETDATE() ELSE EndDate END
        WHERE TeacherId = @TeacherId;
        
        -- Update TeacherSubjects if provided
        IF @SubjectIds IS NOT NULL
        BEGIN
            DELETE FROM TeacherSubject WHERE TeacherId = @TeacherId;
            DECLARE @SubjectId INT;
            DECLARE subject_cursor CURSOR FOR
            SELECT CAST(value AS INT) FROM STRING_SPLIT(@SubjectIds, ',');
            OPEN subject_cursor;
            FETCH NEXT FROM subject_cursor INTO @SubjectId;
            WHILE @@FETCH_STATUS = 0
            BEGIN
                INSERT INTO TeacherSubject (TeacherId, SubjectId) VALUES (@TeacherId, @SubjectId);
                FETCH NEXT FROM subject_cursor INTO @SubjectId;
            END
            CLOSE subject_cursor;
            DEALLOCATE subject_cursor;
        END
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_Teacher_Delete (soft)
CREATE PROCEDURE sp_Teacher_Delete
    @TeacherId INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        UPDATE Teacher SET IsActive = 0, EndDate = GETDATE() WHERE TeacherId = @TeacherId;
        -- Deactivate future timetable entries
        UPDATE TimetableEntry SET IsActive = 0 WHERE TeacherId = @TeacherId AND IsActive = 1;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_Teacher_GetById
CREATE PROCEDURE sp_Teacher_GetById
    @TeacherId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        t.TeacherId,
        p.FirstName,
        p.LastName,
        p.FirstName + ' ' + p.LastName AS FullName,
        p.Phone,
        p.Email,
        p.Address,
        p.DateOfBirth,
        g.GenderName,
        t.EmployeeCode,
        t.Qualification,
        t.JoiningDate,
        t.Salary,
        t.IsActive,
        t.EndDate,
        STUFF((SELECT ',' + CAST(ts.SubjectId AS NVARCHAR) FROM TeacherSubject ts WHERE ts.TeacherId = t.TeacherId FOR XML PATH('')), 1, 1, '') AS SubjectIds,
        STUFF((SELECT ',' + s.SubjectName FROM TeacherSubject ts INNER JOIN Subject s ON ts.SubjectId = s.SubjectId WHERE ts.TeacherId = t.TeacherId FOR XML PATH('')), 1, 1, '') AS SubjectNames
    FROM Teacher t
    INNER JOIN Person p ON t.PersonId = p.PersonId
    LEFT JOIN Gender g ON p.GenderId = g.GenderId
    WHERE t.TeacherId = @TeacherId;
END;
GO

-- sp_Teacher_GetAll
CREATE PROCEDURE sp_Teacher_GetAll
    @Search NVARCHAR(50) = NULL,
    @IsActive BIT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        t.TeacherId,
        p.FirstName + ' ' + p.LastName AS FullName,
        p.Phone,
        p.Email,
        t.EmployeeCode,
        t.Qualification,
        t.JoiningDate,
        t.Salary,
        t.IsActive,
        STUFF((SELECT ',' + s.SubjectName FROM TeacherSubject ts INNER JOIN Subject s ON ts.SubjectId = s.SubjectId WHERE ts.TeacherId = t.TeacherId FOR XML PATH('')), 1, 1, '') AS SubjectNames
    FROM Teacher t
    INNER JOIN Person p ON t.PersonId = p.PersonId
    WHERE (@Search IS NULL OR p.FirstName LIKE '%' + @Search + '%' OR p.LastName LIKE '%' + @Search + '%' OR t.EmployeeCode LIKE '%' + @Search + '%')
    AND (@IsActive IS NULL OR t.IsActive = @IsActive)
    ORDER BY p.FirstName;
END;
GO

-- sp_SetTeacherActiveStatus: Handle teacher becoming inactive
CREATE PROCEDURE sp_SetTeacherActiveStatus
    @TeacherId INT,
    @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        UPDATE Teacher SET 
            IsActive = @IsActive, 
            EndDate = CASE WHEN @IsActive = 0 THEN GETDATE() ELSE NULL END
        WHERE TeacherId = @TeacherId;
        
        IF @IsActive = 0
        BEGIN
            -- Remove from future timetable entries
            UPDATE TimetableEntry SET IsActive = 0 WHERE TeacherId = @TeacherId AND IsActive = 1;
        END
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO


-- ============================================
-- SCHEDULING SPs
-- ============================================

-- sp_CreateOrUpdateScheduleConfig: Create or update schedule with effective date
CREATE PROCEDURE sp_CreateOrUpdateScheduleConfig
    @EffectiveFrom DATE,
    @SchoolStart TIME,
    @SchoolEnd TIME,
    @LectureDuration INT,
    @BreakDuration INT,
    @BreakAfterPeriod INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Deactivate existing config
        UPDATE SchoolScheduleConfig SET IsActive = 0 WHERE IsActive = 1;
        
        -- Insert new config
        DECLARE @ConfigId INT;
        INSERT INTO SchoolScheduleConfig (EffectiveFrom, SchoolStart, SchoolEnd, LectureDuration, BreakDuration, BreakAfterPeriod, IsActive)
        VALUES (@EffectiveFrom, @SchoolStart, @SchoolEnd, @LectureDuration, @BreakDuration, @BreakAfterPeriod, 1);
        SET @ConfigId = SCOPE_IDENTITY();
        
        COMMIT TRANSACTION;
        SELECT @ConfigId AS ConfigId;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_GenerateTimeSlotsFromConfig: Generate time slots from active config
CREATE PROCEDURE sp_GenerateTimeSlotsFromConfig
    @ConfigId INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @SchoolStart TIME, @SchoolEnd TIME, @LectureDuration INT, @BreakDuration INT, @BreakAfter INT;
        SELECT @SchoolStart = SchoolStart, @SchoolEnd = SchoolEnd, @LectureDuration = LectureDuration, 
               @BreakDuration = BreakDuration, @BreakAfter = BreakAfterPeriod
        FROM SchoolScheduleConfig WHERE ConfigId = @ConfigId;
        
        -- Delete existing slots for this config
        DELETE FROM TimeSlot WHERE ConfigId = @ConfigId;
        
        -- Generate slots
        DECLARE @CurrentTime TIME = @SchoolStart;
        DECLARE @PeriodNo INT = 1;
        DECLARE @LectureTypeId INT = (SELECT SlotTypeId FROM SlotType WHERE TypeName = 'Lecture');
        DECLARE @BreakTypeId INT = (SELECT SlotTypeId FROM SlotType WHERE TypeName = 'Break');
        
        WHILE @CurrentTime < @SchoolEnd
        BEGIN
            DECLARE @EndTime TIME = DATEADD(MINUTE, @LectureDuration, CAST(@CurrentTime AS DATETIME));
            
            IF @EndTime > @SchoolEnd SET @EndTime = @SchoolEnd;
            
            -- Insert lecture slot
            INSERT INTO TimeSlot (ConfigId, PeriodNo, StartTime, EndTime, SlotTypeId)
            VALUES (@ConfigId, @PeriodNo, @CurrentTime, @EndTime, @LectureTypeId);
            
            SET @CurrentTime = @EndTime;
            SET @PeriodNo = @PeriodNo + 1;
            
            -- Insert break if needed
            IF @PeriodNo = @BreakAfter + 1 AND @CurrentTime < @SchoolEnd
            BEGIN
                SET @EndTime = DATEADD(MINUTE, @BreakDuration, CAST(@CurrentTime AS DATETIME));
                IF @EndTime > @SchoolEnd SET @EndTime = @SchoolEnd;
                
                INSERT INTO TimeSlot (ConfigId, PeriodNo, StartTime, EndTime, SlotTypeId)
                VALUES (@ConfigId, @PeriodNo, @CurrentTime, @EndTime, @BreakTypeId);
                
                SET @CurrentTime = @EndTime;
                SET @PeriodNo = @PeriodNo + 1;
            END
        END
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_TimetableEntry_CRUD: Insert/Update/Delete timetable entries with clash check
CREATE PROCEDURE sp_TimetableEntry_CRUD
    @Action NVARCHAR(10), -- INSERT/UPDATE/DELETE
    @EntryId INT = NULL,
    @ClassSectionId INT = NULL,
    @TimeSlotId INT = NULL,
    @SubjectId INT = NULL,
    @TeacherId INT = NULL,
    @DayOfWeek INT = NULL,
    @Room NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    IF @Action = 'INSERT'
    BEGIN
        -- Check for teacher double-booking (clash detection)
        IF EXISTS(
            SELECT 1 FROM TimetableEntry te
            WHERE te.TeacherId = @TeacherId 
            AND te.DayOfWeek = @DayOfWeek 
            AND te.TimeSlotId = @TimeSlotId 
            AND te.IsActive = 1
            AND (@EntryId IS NULL OR te.TimetableEntryId <> @EntryId)
        )
        BEGIN
            RAISERROR('Teacher is already assigned to another class at this time slot.', 16, 1);
            RETURN;
        END
        
        -- Check for class-section double-booking
        IF EXISTS(
            SELECT 1 FROM TimetableEntry te
            WHERE te.ClassSectionId = @ClassSectionId 
            AND te.DayOfWeek = @DayOfWeek 
            AND te.TimeSlotId = @TimeSlotId 
            AND te.IsActive = 1
        )
        BEGIN
            RAISERROR('This class already has a subject assigned at this time slot.', 16, 1);
            RETURN;
        END
        
        INSERT INTO TimetableEntry (ClassSectionId, TimeSlotId, SubjectId, TeacherId, DayOfWeek, Room, IsActive)
        VALUES (@ClassSectionId, @TimeSlotId, @SubjectId, @TeacherId, @DayOfWeek, @Room, 1);
        
        SELECT SCOPE_IDENTITY() AS EntryId;
    END
    ELSE IF @Action = 'UPDATE'
    BEGIN
        IF EXISTS(
            SELECT 1 FROM TimetableEntry te
            WHERE te.TeacherId = @TeacherId 
            AND te.DayOfWeek = @DayOfWeek 
            AND te.TimeSlotId = @TimeSlotId 
            AND te.IsActive = 1
            AND te.TimetableEntryId <> @EntryId
        )
        BEGIN
            RAISERROR('Teacher is already assigned to another class at this time slot.', 16, 1);
            RETURN;
        END
        
        UPDATE TimetableEntry SET
            ClassSectionId = @ClassSectionId,
            TimeSlotId = @TimeSlotId,
            SubjectId = @SubjectId,
            TeacherId = @TeacherId,
            DayOfWeek = @DayOfWeek,
            Room = @Room
        WHERE TimetableEntryId = @EntryId;
    END
    ELSE IF @Action = 'DELETE'
    BEGIN
        UPDATE TimetableEntry SET IsActive = 0 WHERE TimetableEntryId = @EntryId;
    END
    ELSE IF @Action = 'GET'
    BEGIN
        SELECT 
            te.*,
            p.FirstName + ' ' + p.LastName AS TeacherName,
            s.SubjectName,
            ts.StartTime,
            ts.EndTime,
            ts.PeriodNo,
            gc.ClassName + ' - ' + sec.SectionName AS ClassSectionName
        FROM TimetableEntry te
        INNER JOIN Teacher t ON te.TeacherId = t.TeacherId
        INNER JOIN Person p ON t.PersonId = p.PersonId
        INNER JOIN Subject s ON te.SubjectId = s.SubjectId
        INNER JOIN TimeSlot ts ON te.TimeSlotId = ts.TimeSlotId
        INNER JOIN ClassSection cs ON te.ClassSectionId = cs.ClassSectionId
        INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
        INNER JOIN Section sec ON cs.SectionId = sec.SectionId
        WHERE te.TimetableEntryId = @EntryId;
    END
END;
GO

-- sp_RequestTeacherLeave: Submit leave request and find affected lectures
CREATE PROCEDURE sp_RequestTeacherLeave
    @TeacherId INT,
    @LeaveDate DATE,
    @FromTime TIME = NULL,
    @ToTime TIME = NULL,
    @Reason NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Insert leave request
        DECLARE @LeaveRequestId INT;
        INSERT INTO TeacherLeaveRequest (TeacherId, LeaveDate, FromTime, ToTime, Reason, StatusId, RequestedAt)
        VALUES (@TeacherId, @LeaveDate, @FromTime, @ToTime, @Reason, 1, GETDATE());
        SET @LeaveRequestId = SCOPE_IDENTITY();
        
        -- Find affected timetable entries
        DECLARE @DayOfWeek INT = DATEPART(WEEKDAY, @LeaveDate);
        IF @DayOfWeek = 1 SET @DayOfWeek = 7; -- Sunday = 7
        ELSE SET @DayOfWeek = @DayOfWeek - 1; -- Adjust so Monday = 1
        
        -- Return affected lectures
        SELECT 
            te.TimetableEntryId,
            te.SubjectId,
            s.SubjectName,
            ts.StartTime,
            ts.EndTime,
            te.ClassSectionId,
            gc.ClassName + ' - ' + sec.SectionName AS ClassSectionName
        FROM TimetableEntry te
        INNER JOIN Subject s ON te.SubjectId = s.SubjectId
        INNER JOIN TimeSlot ts ON te.TimeSlotId = ts.TimeSlotId
        INNER JOIN ClassSection cs ON te.ClassSectionId = cs.ClassSectionId
        INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
        INNER JOIN Section sec ON cs.SectionId = sec.SectionId
        WHERE te.TeacherId = @TeacherId
        AND te.DayOfWeek = @DayOfWeek
        AND te.IsActive = 1;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_FindSubstituteTeacher: Priority-based substitute finding with JOINs + subqueries
CREATE PROCEDURE sp_FindSubstituteTeacher
    @TimetableEntryId INT,
    @LeaveDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Get the original entry details
    DECLARE @SubjectId INT, @TeacherId INT, @TimeSlotId INT, @DayOfWeek INT, @DomainId INT;
    SELECT 
        @SubjectId = te.SubjectId,
        @TeacherId = te.TeacherId,
        @TimeSlotId = te.TimeSlotId,
        @DayOfWeek = te.DayOfWeek,
        @DomainId = s.DomainId
    FROM TimetableEntry te
    INNER JOIN Subject s ON te.SubjectId = s.SubjectId
    WHERE te.TimetableEntryId = @TimetableEntryId;
    
    -- Priority 1: Free teacher who can teach SAME subject
    SELECT 
        t.TeacherId,
        p.FirstName + ' ' + p.LastName AS TeacherName,
        1 AS Priority,
        'Same Subject' AS MatchReason,
        (SELECT COUNT(*) FROM SubstitutionAssignment sa 
         WHERE sa.SubstituteTeacherId = t.TeacherId AND sa.LeaveDate = @LeaveDate) AS SubstitutionCount
    FROM Teacher t
    INNER JOIN Person p ON t.PersonId = p.PersonId
    INNER JOIN TeacherSubject ts ON t.TeacherId = ts.TeacherId
    WHERE ts.SubjectId = @SubjectId
    AND t.IsActive = 1
    AND t.TeacherId <> @TeacherId
    -- Exclude teachers already assigned at this timeslot
    AND NOT EXISTS (
        SELECT 1 FROM TimetableEntry te2 
        WHERE te2.TeacherId = t.TeacherId 
        AND te2.DayOfWeek = @DayOfWeek 
        AND te2.TimeSlotId = @TimeSlotId 
        AND te2.IsActive = 1
    )
    -- Exclude teachers on leave
    AND NOT EXISTS (
        SELECT 1 FROM TeacherLeaveRequest lr 
        WHERE lr.TeacherId = t.TeacherId 
        AND lr.LeaveDate = @LeaveDate 
        AND lr.StatusId = 2
    )
    
    UNION ALL
    
    -- Priority 2: Free teacher in SAME domain
    SELECT 
        t.TeacherId,
        p.FirstName + ' ' + p.LastName AS TeacherName,
        2 AS Priority,
        'Same Domain' AS MatchReason,
        (SELECT COUNT(*) FROM SubstitutionAssignment sa 
         WHERE sa.SubstituteTeacherId = t.TeacherId AND sa.LeaveDate = @LeaveDate) AS SubstitutionCount
    FROM Teacher t
    INNER JOIN Person p ON t.PersonId = p.PersonId
    INNER JOIN TeacherDomain td ON t.TeacherId = td.TeacherId
    WHERE td.DomainId = @DomainId
    AND t.IsActive = 1
    AND t.TeacherId <> @TeacherId
    AND NOT EXISTS (SELECT 1 FROM TeacherSubject ts WHERE ts.TeacherId = t.TeacherId AND ts.SubjectId = @SubjectId)
    AND NOT EXISTS (
        SELECT 1 FROM TimetableEntry te2 
        WHERE te2.TeacherId = t.TeacherId 
        AND te2.DayOfWeek = @DayOfWeek 
        AND te2.TimeSlotId = @TimeSlotId 
        AND te2.IsActive = 1
    )
    AND NOT EXISTS (
        SELECT 1 FROM TeacherLeaveRequest lr 
        WHERE lr.TeacherId = t.TeacherId 
        AND lr.LeaveDate = @LeaveDate 
        AND lr.StatusId = 2
    )
    
    UNION ALL
    
    -- Priority 3: ANY free teacher
    SELECT 
        t.TeacherId,
        p.FirstName + ' ' + p.LastName AS TeacherName,
        3 AS Priority,
        'Any Available' AS MatchReason,
        (SELECT COUNT(*) FROM SubstitutionAssignment sa 
         WHERE sa.SubstituteTeacherId = t.TeacherId AND sa.LeaveDate = @LeaveDate) AS SubstitutionCount
    FROM Teacher t
    INNER JOIN Person p ON t.PersonId = p.PersonId
    WHERE t.IsActive = 1
    AND t.TeacherId <> @TeacherId
    AND NOT EXISTS (SELECT 1 FROM TeacherSubject ts WHERE ts.TeacherId = t.TeacherId AND ts.SubjectId = @SubjectId)
    AND NOT EXISTS (SELECT 1 FROM TeacherDomain td WHERE td.TeacherId = t.TeacherId AND td.DomainId = @DomainId)
    AND NOT EXISTS (
        SELECT 1 FROM TimetableEntry te2 
        WHERE te2.TeacherId = t.TeacherId 
        AND te2.DayOfWeek = @DayOfWeek 
        AND te2.TimeSlotId = @TimeSlotId 
        AND te2.IsActive = 1
    )
    AND NOT EXISTS (
        SELECT 1 FROM TeacherLeaveRequest lr 
        WHERE lr.TeacherId = t.TeacherId 
        AND lr.LeaveDate = @LeaveDate 
        AND lr.StatusId = 2
    )
    
    ORDER BY Priority, SubstitutionCount;
END;
GO

-- sp_AssignSubstitution: Assign a substitute teacher
CREATE PROCEDURE sp_AssignSubstitution
    @TimetableEntryId INT,
    @LeaveDate DATE,
    @OriginalTeacherId INT,
    @SubstituteTeacherId INT,
    @Reason NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO SubstitutionAssignment (TimetableEntryId, LeaveDate, OriginalTeacherId, SubstituteTeacherId, Reason, StatusId)
    VALUES (@TimetableEntryId, @LeaveDate, @OriginalTeacherId, @SubstituteTeacherId, @Reason, 2);
    
    SELECT SCOPE_IDENTITY() AS SubstitutionId;
END;
GO

-- sp_ReplaceTeacherWizard: Transfer lectures from old to new teacher (only same subject)
CREATE PROCEDURE sp_ReplaceTeacherWizard
    @OldTeacherId INT,
    @NewTeacherId INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Only transfer entries where new teacher can teach the same subject
        UPDATE te SET
            TeacherId = @NewTeacherId
        FROM TimetableEntry te
        WHERE te.TeacherId = @OldTeacherId
        AND te.IsActive = 1
        AND EXISTS (
            SELECT 1 FROM TeacherSubject ts 
            WHERE ts.TeacherId = @NewTeacherId 
            AND ts.SubjectId = te.SubjectId
        );
        
        -- Deactivate entries that couldn't be transferred
        UPDATE te SET IsActive = 0
        FROM TimetableEntry te
        WHERE te.TeacherId = @OldTeacherId
        AND te.IsActive = 1
        AND NOT EXISTS (
            SELECT 1 FROM TeacherSubject ts 
            WHERE ts.TeacherId = @NewTeacherId 
            AND ts.SubjectId = te.SubjectId
        );
        
        DECLARE @TransferredCount INT = @@ROWCOUNT;
        COMMIT TRANSACTION;
        SELECT @TransferredCount AS TransferredCount;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- ============================================
-- ATTENDANCE SPs
-- ============================================

-- sp_SaveAttendance: Save attendance with duplicate prevention
CREATE PROCEDURE sp_SaveAttendance
    @StudentId INT,
    @ClassSectionId INT,
    @AttendanceDate DATE,
    @StatusId INT,
    @MarkedBy INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Check for duplicate
    IF EXISTS(SELECT 1 FROM AttendanceRecord WHERE StudentId = @StudentId AND AttendanceDate = @AttendanceDate)
    BEGIN
        -- Update existing
        UPDATE AttendanceRecord SET
            StatusId = @StatusId,
            ClassSectionId = @ClassSectionId,
            MarkedBy = @MarkedBy,
            MarkedAt = GETDATE()
        WHERE StudentId = @StudentId AND AttendanceDate = @AttendanceDate;
    END
    ELSE
    BEGIN
        -- Insert new
        INSERT INTO AttendanceRecord (StudentId, ClassSectionId, AttendanceDate, StatusId, MarkedBy, MarkedAt)
        VALUES (@StudentId, @ClassSectionId, @AttendanceDate, @StatusId, @MarkedBy, GETDATE());
    END
END;
GO

-- sp_GetAttendanceSummary: Get attendance summary with JOINs
CREATE PROCEDURE sp_GetAttendanceSummary
    @ClassSectionId INT,
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        s.StudentId,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        COUNT(CASE WHEN ar.StatusId = 1 THEN 1 END) AS PresentCount,
        COUNT(CASE WHEN ar.StatusId = 2 THEN 1 END) AS AbsentCount,
        COUNT(CASE WHEN ar.StatusId = 3 THEN 1 END) AS LateCount,
        COUNT(CASE WHEN ar.StatusId = 4 THEN 1 END) AS LeaveCount,
        COUNT(*) AS TotalDays,
        CAST(COUNT(CASE WHEN ar.StatusId = 1 THEN 1 END) * 100.0 / NULLIF(COUNT(*), 0) AS DECIMAL(5,2)) AS AttendancePercentage
    FROM Student s
    INNER JOIN Person p ON s.PersonId = p.PersonId
    INNER JOIN Enrollment e ON s.StudentId = e.StudentId AND e.ClassSectionId = @ClassSectionId AND e.IsActive = 1
    LEFT JOIN AttendanceRecord ar ON s.StudentId = ar.StudentId AND ar.AttendanceDate BETWEEN @StartDate AND @EndDate
    WHERE s.IsActive = 1
    GROUP BY s.StudentId, p.FirstName, p.LastName, s.AdmissionNo
    ORDER BY p.FirstName;
END;
GO


-- ============================================
-- EXAM SPs
-- ============================================

-- sp_CreateExam
CREATE PROCEDURE sp_CreateExam
    @ExamName NVARCHAR(100),
    @ExamTypeId INT,
    @ClassSectionId INT,
    @SubjectId INT,
    @ExamDate DATE,
    @TotalMarks INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Exam (ExamName, ExamTypeId, ClassSectionId, SubjectId, ExamDate, TotalMarks, IsActive)
    VALUES (@ExamName, @ExamTypeId, @ClassSectionId, @SubjectId, @ExamDate, @TotalMarks, 1);
    SELECT SCOPE_IDENTITY() AS ExamId;
END;
GO

-- sp_SaveMarks: Save marks with validation against total marks
CREATE PROCEDURE sp_SaveMarks
    @ExamId INT,
    @StudentId INT,
    @ObtainedMarks INT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Validate marks don't exceed total
    DECLARE @TotalMarks INT;
    SELECT @TotalMarks = TotalMarks FROM Exam WHERE ExamId = @ExamId;
    
    IF @ObtainedMarks > @TotalMarks
    BEGIN
        RAISERROR('Obtained marks cannot exceed total marks.', 16, 1);
        RETURN;
    END
    
    -- Calculate grade
    DECLARE @Percentage DECIMAL(5,2) = CAST(@ObtainedMarks AS DECIMAL) * 100.0 / @TotalMarks;
    DECLARE @Grade NVARCHAR(10) = CASE
        WHEN @Percentage >= 90 THEN 'A+'
        WHEN @Percentage >= 80 THEN 'A'
        WHEN @Percentage >= 70 THEN 'B'
        WHEN @Percentage >= 60 THEN 'C'
        WHEN @Percentage >= 50 THEN 'D'
        ELSE 'F'
    END;
    
    -- Upsert marks
    IF EXISTS(SELECT 1 FROM Mark WHERE ExamId = @ExamId AND StudentId = @StudentId)
    BEGIN
        UPDATE Mark SET ObtainedMarks = @ObtainedMarks, Grade = @Grade 
        WHERE ExamId = @ExamId AND StudentId = @StudentId;
    END
    ELSE
    BEGIN
        INSERT INTO Mark (ExamId, StudentId, ObtainedMarks, Grade)
        VALUES (@ExamId, @StudentId, @ObtainedMarks, @Grade);
    END
END;
GO

-- sp_GetExamResultReport: Get exam results with JOINs + subquery
CREATE PROCEDURE sp_GetExamResultReport
    @ExamId INT = NULL,
    @ClassSectionId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        e.ExamId,
        e.ExamName,
        et.TypeName AS ExamType,
        gc.ClassName + ' - ' + sec.SectionName AS ClassSection,
        sub.SubjectName,
        e.TotalMarks,
        e.ExamDate,
        (SELECT COUNT(*) FROM Mark m WHERE m.ExamId = e.ExamId) AS TotalStudents,
        (SELECT MAX(m.ObtainedMarks) FROM Mark m WHERE m.ExamId = e.ExamId) AS HighestMarks,
        (SELECT MIN(m.ObtainedMarks) FROM Mark m WHERE m.ExamId = e.ExamId) AS LowestMarks,
        (SELECT CAST(AVG(CAST(m.ObtainedMarks AS DECIMAL)) AS DECIMAL(5,2)) FROM Mark m WHERE m.ExamId = e.ExamId) AS AverageMarks
    FROM Exam e
    INNER JOIN ExamType et ON e.ExamTypeId = et.ExamTypeId
    INNER JOIN ClassSection cs ON e.ClassSectionId = cs.ClassSectionId
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    INNER JOIN Subject sub ON e.SubjectId = sub.SubjectId
    WHERE (@ExamId IS NULL OR e.ExamId = @ExamId)
    AND (@ClassSectionId IS NULL OR e.ClassSectionId = @ClassSectionId)
    ORDER BY e.ExamDate DESC;
END;
GO

-- sp_GetStudentResultCard: Get result card for a specific student
CREATE PROCEDURE sp_GetStudentResultCard
    @StudentId INT,
    @ExamId INT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Student info
    SELECT
        s.StudentId,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        s.RollNo,
        gc.ClassName + ' - ' + sec.SectionName AS ClassSection,
        e.ExamName,
        et.TypeName AS ExamType,
        e.ExamDate
    FROM Student s
    INNER JOIN Person p ON s.PersonId = p.PersonId
    INNER JOIN Enrollment en ON s.StudentId = en.StudentId AND en.IsActive = 1
    INNER JOIN ClassSection cs ON en.ClassSectionId = cs.ClassSectionId
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    CROSS JOIN Exam e
    INNER JOIN ExamType et ON e.ExamTypeId = et.ExamTypeId
    WHERE s.StudentId = @StudentId AND e.ExamId = @ExamId;
    
    -- Marks detail
    SELECT
        sub.SubjectName,
        e.TotalMarks,
        m.ObtainedMarks,
        m.Grade,
        CAST(CAST(m.ObtainedMarks AS DECIMAL) * 100 / NULLIF(e.TotalMarks, 0) AS DECIMAL(5,2)) AS Percentage
    FROM Mark m
    INNER JOIN Exam e ON m.ExamId = e.ExamId
    INNER JOIN Subject sub ON e.SubjectId = sub.SubjectId
    WHERE m.ExamId = @ExamId AND m.StudentId = @StudentId
    ORDER BY sub.SubjectName;
END;
GO

-- ============================================
-- FEE SPs
-- ============================================

-- sp_GenerateFeeVouchers: Generate vouchers for all active students in a class
CREATE PROCEDURE sp_GenerateFeeVouchers
    @ClassSectionId INT,
    @Month NVARCHAR(20),
    @Year INT,
    @DueDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        DECLARE @MonthlyFee DECIMAL(18,2);
        SELECT @MonthlyFee = MonthlyFee FROM FeeStructure WHERE ClassSectionId = @ClassSectionId;
        IF @MonthlyFee IS NULL SET @MonthlyFee = 0;
        
        -- Generate voucher for each active student
        INSERT INTO FeeVoucher (StudentId, ClassSectionId, Month, Year, TotalAmount, DueDate, StatusId)
        SELECT 
            s.StudentId,
            @ClassSectionId,
            @Month,
            @Year,
            @MonthlyFee,
            @DueDate,
            1
        FROM Student s
        INNER JOIN Enrollment e ON s.StudentId = e.StudentId AND e.ClassSectionId = @ClassSectionId AND e.IsActive = 1
        WHERE s.IsActive = 1
        AND NOT EXISTS (
            SELECT 1 FROM FeeVoucher fv 
            WHERE fv.StudentId = s.StudentId AND fv.Month = @Month AND fv.Year = @Year
        );
        
        SELECT @@ROWCOUNT AS VouchersGenerated;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_PayFeeVoucher: Record a fee payment
CREATE PROCEDURE sp_PayFeeVoucher
    @VoucherId INT,
    @PaidAmount DECIMAL(18,2),
    @PaymentMethodId INT = 1,
    @ReceivedBy INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Insert payment
        INSERT INTO FeePayment (VoucherId, PaidAmount, PaidOn, PaymentMethodId, ReceivedBy)
        VALUES (@VoucherId, @PaidAmount, GETDATE(), @PaymentMethodId, @ReceivedBy);
        
        -- Check if fully paid
        DECLARE @TotalAmount DECIMAL(18,2), @TotalPaid DECIMAL(18,2);
        SELECT @TotalAmount = TotalAmount FROM FeeVoucher WHERE VoucherId = @VoucherId;
        SELECT @TotalPaid = ISNULL(SUM(PaidAmount), 0) FROM FeePayment WHERE VoucherId = @VoucherId;
        
        IF @TotalPaid >= @TotalAmount
        BEGIN
            UPDATE FeeVoucher SET StatusId = 2 WHERE VoucherId = @VoucherId;
        END
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_GetFeeDueStudents: Get students with due fees using JOIN + subquery
CREATE PROCEDURE sp_GetFeeDueStudents
    @ClassSectionId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        fv.VoucherId,
        s.StudentId,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        gc.ClassName + ' - ' + sec.SectionName AS ClassSection,
        fv.Month,
        fv.Year,
        fv.TotalAmount,
        ISNULL((SELECT SUM(PaidAmount) FROM FeePayment fp WHERE fp.VoucherId = fv.VoucherId), 0) AS PaidAmount,
        fv.TotalAmount - ISNULL((SELECT SUM(PaidAmount) FROM FeePayment fp WHERE fp.VoucherId = fv.VoucherId), 0) AS DueAmount,
        fv.DueDate
    FROM FeeVoucher fv
    INNER JOIN Student s ON fv.StudentId = s.StudentId
    INNER JOIN Person p ON s.PersonId = p.PersonId
    INNER JOIN ClassSection cs ON fv.ClassSectionId = cs.ClassSectionId
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    WHERE fv.StatusId <> 2
    AND (@ClassSectionId IS NULL OR fv.ClassSectionId = @ClassSectionId)
    AND fv.TotalAmount - ISNULL((SELECT SUM(PaidAmount) FROM FeePayment fp WHERE fp.VoucherId = fv.VoucherId), 0) > 0
    ORDER BY fv.DueDate;
END;
GO

-- ============================================
-- LIBRARY SPs
-- ============================================

-- sp_Library_IssueBook: Issue a book with availability check
CREATE PROCEDURE sp_Library_IssueBook
    @CopyId INT,
    @StudentId INT,
    @DueDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Check if copy is available
        IF NOT EXISTS(SELECT 1 FROM BookCopy WHERE CopyId = @CopyId AND IsAvailable = 1)
        BEGIN
            RAISERROR('Book copy is not available for issue.', 16, 1);
            RETURN;
        END
        
        -- Check student active
        IF NOT EXISTS(SELECT 1 FROM Student WHERE StudentId = @StudentId AND IsActive = 1)
        BEGIN
            RAISERROR('Student is not active.', 16, 1);
            RETURN;
        END
        
        -- Insert issue record
        INSERT INTO BookIssue (CopyId, StudentId, IssuedOn, DueDate, Fine, IsReturned)
        VALUES (@CopyId, @StudentId, GETDATE(), @DueDate, 0, 0);
        
        -- Update copy availability
        UPDATE BookCopy SET IsAvailable = 0 WHERE CopyId = @CopyId;
        
        -- Update book available count
        DECLARE @BookId INT;
        SELECT @BookId = BookId FROM BookCopy WHERE CopyId = @CopyId;
        UPDATE LibraryBook SET AvailableCopies = AvailableCopies - 1 WHERE BookId = @BookId;
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_Library_ReturnBook: Return a book with fine calculation
CREATE PROCEDURE sp_Library_ReturnBook
    @IssueId INT,
    @ReturnedOn DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        IF @ReturnedOn IS NULL SET @ReturnedOn = CAST(GETDATE() AS DATE);
        
        DECLARE @DueDate DATE, @CopyId INT, @BookId INT;
        SELECT @DueDate = DueDate, @CopyId = CopyId FROM BookIssue WHERE IssueId = @IssueId;
        SELECT @BookId = BookId FROM BookCopy WHERE CopyId = @CopyId;
        
        -- Calculate fine
        DECLARE @FinePerDay DECIMAL(18,2), @GraceDays INT;
        SELECT TOP 1 @FinePerDay = FinePerDay, @GraceDays = GraceDays FROM LibraryFinePolicy;
        IF @FinePerDay IS NULL SET @FinePerDay = 10;
        IF @GraceDays IS NULL SET @GraceDays = 2;
        
        DECLARE @DaysOverdue INT = DATEDIFF(DAY, @DueDate, @ReturnedOn) - @GraceDays;
        DECLARE @Fine DECIMAL(18,2) = CASE WHEN @DaysOverdue > 0 THEN @DaysOverdue * @FinePerDay ELSE 0 END;
        
        -- Update issue record
        UPDATE BookIssue SET
            ReturnedOn = @ReturnedOn,
            Fine = @Fine,
            IsReturned = 1
        WHERE IssueId = @IssueId;
        
        -- Update copy availability
        UPDATE BookCopy SET IsAvailable = 1 WHERE CopyId = @CopyId;
        
        -- Update book available count
        UPDATE LibraryBook SET AvailableCopies = AvailableCopies + 1 WHERE BookId = @BookId;
        
        SELECT @Fine AS FineAmount;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

-- sp_Library_GetOverdueBooks
CREATE PROCEDURE sp_Library_GetOverdueBooks
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        bi.IssueId,
        lb.Title,
        bc.CopyNo,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        bi.IssuedOn,
        bi.DueDate,
        DATEDIFF(DAY, bi.DueDate, GETDATE()) AS DaysOverdue
    FROM BookIssue bi
    INNER JOIN BookCopy bc ON bi.CopyId = bc.CopyId
    INNER JOIN LibraryBook lb ON bc.BookId = lb.BookId
    INNER JOIN Student s ON bi.StudentId = s.StudentId
    INNER JOIN Person p ON s.PersonId = p.PersonId
    WHERE bi.IsReturned = 0
    AND bi.DueDate < GETDATE()
    ORDER BY bi.DueDate;
END;
GO

-- ============================================
-- NOTIFICATION SPs
-- ============================================

-- sp_CreateNotification
CREATE PROCEDURE sp_CreateNotification
    @ToUserId INT,
    @Title NVARCHAR(200),
    @Message NVARCHAR(500),
    @NotificationTypeId INT = 1
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Notification (ToUserId, Title, Message, NotificationTypeId, IsRead, CreatedAt)
    VALUES (@ToUserId, @Title, @Message, @NotificationTypeId, 0, GETDATE());
    SELECT SCOPE_IDENTITY() AS NotificationId;
END;
GO

-- sp_CreateBroadcastNotification: Notify all users
CREATE PROCEDURE sp_CreateBroadcastNotification
    @Title NVARCHAR(200),
    @Message NVARCHAR(500),
    @NotificationTypeId INT = 1
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Notification (ToUserId, Title, Message, NotificationTypeId, IsRead, CreatedAt)
    SELECT UserId, @Title, @Message, @NotificationTypeId, 0, GETDATE()
    FROM AppUser WHERE IsActive = 1;
END;
GO

-- sp_GetUnreadNotifications
CREATE PROCEDURE sp_GetUnreadNotifications
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        n.NotificationId,
        n.Title,
        n.Message,
        nt.TypeName,
        n.IsRead,
        n.CreatedAt
    FROM Notification n
    INNER JOIN NotificationType nt ON n.NotificationTypeId = nt.TypeId
    WHERE n.ToUserId = @UserId
    AND n.IsRead = 0
    ORDER BY n.CreatedAt DESC;
END;
GO

-- sp_MarkNotificationRead
CREATE PROCEDURE sp_MarkNotificationRead
    @NotificationId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Notification SET IsRead = 1 WHERE NotificationId = @NotificationId;
END;
GO

-- ============================================
-- AUDIT LOG SP
-- ============================================

-- sp_InsertAuditLog
CREATE PROCEDURE sp_InsertAuditLog
    @UserId INT = NULL,
    @Username NVARCHAR(50),
    @Action NVARCHAR(50),
    @EntityName NVARCHAR(50),
    @EntityId INT = NULL,
    @Details NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO AuditLog (Timestamp, UserId, Username, Action, EntityName, EntityId, Details)
    VALUES (GETDATE(), @UserId, @Username, @Action, @EntityName, @EntityId, @Details);
END;
GO

-- sp_GetAuditLogs
CREATE PROCEDURE sp_GetAuditLogs
    @StartDate DATE = NULL,
    @EndDate DATE = NULL,
    @Username NVARCHAR(50) = NULL,
    @Action NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        LogId,
        Timestamp,
        Username,
        Action,
        EntityName,
        EntityId,
        Details
    FROM AuditLog
    WHERE (@StartDate IS NULL OR CAST(Timestamp AS DATE) >= @StartDate)
    AND (@EndDate IS NULL OR CAST(Timestamp AS DATE) <= @EndDate)
    AND (@Username IS NULL OR Username = @Username)
    AND (@Action IS NULL OR Action = @Action)
    ORDER BY Timestamp DESC;
END;
GO


-- ============================================================
-- 12. SEED DATA
-- ============================================================

SET NOCOUNT ON;
GO

-- GradeClasses 1-10
IF NOT EXISTS(SELECT 1 FROM GradeClass)
INSERT INTO GradeClass (ClassName, Description) VALUES
('Class 1','Primary - First Grade'),
('Class 2','Primary - Second Grade'),
('Class 3','Primary - Third Grade'),
('Class 4','Primary - Fourth Grade'),
('Class 5','Primary - Fifth Grade'),
('Class 6','Middle - Sixth Grade'),
('Class 7','Middle - Seventh Grade'),
('Class 8','Middle - Eighth Grade'),
('Class 9','Secondary - Ninth Grade'),
('Class 10','Secondary - Matric');

-- Sections A and B
IF NOT EXISTS(SELECT 1 FROM Section)
INSERT INTO Section (SectionName) VALUES ('A'), ('B');

-- ClassSections: All combinations for current year
IF NOT EXISTS(SELECT 1 FROM ClassSection)
INSERT INTO ClassSection (GradeClassId, SectionId, MaxStudents, IsActive)
SELECT gc.GradeClassId, s.SectionId, 40, 1
FROM GradeClass gc
CROSS JOIN Section s;

-- Subject Domains
IF NOT EXISTS(SELECT 1 FROM SubjectDomain)
INSERT INTO SubjectDomain (DomainName) VALUES
('Sciences'),
('Mathematics'),
('Languages'),
('Social Studies'),
('Islamic Studies'),
('Computer Science'),
('Physical Education'),
('Arts');

-- Subjects
IF NOT EXISTS(SELECT 1 FROM Subject)
INSERT INTO Subject (SubjectName, SubjectCode, DomainId, IsActive) VALUES
('Physics', 'PHY', 1, 1),
('Chemistry', 'CHEM', 1, 1),
('Biology', 'BIO', 1, 1),
('Mathematics', 'MATH', 2, 1),
('English', 'ENG', 3, 1),
('Urdu', 'URD', 3, 1),
('Pakistan Studies', 'PKST', 4, 1),
('Islamiat', 'ISL', 5, 1),
('Computer Science', 'CS', 6, 1),
('Physical Education', 'PE', 7, 1);

-- Teachers (6 teachers)
IF NOT EXISTS(SELECT 1 FROM Teacher)
BEGIN
    -- Teacher 1
    INSERT INTO Person (FirstName, LastName, Phone, Email, Address, DateOfBirth, GenderId, CreatedAt)
    VALUES ('Ahmad', 'Khan', '0300-1111111', 'ahmad@edunova.edu', 'Lahore', '1985-03-15', 1, GETDATE());
    INSERT INTO Teacher (PersonId, EmployeeCode, Qualification, JoiningDate, Salary, IsActive, EndDate)
    VALUES (SCOPE_IDENTITY(), 'TCH001', 'MSc Physics', '2020-01-15', 75000, 1, NULL);
    DECLARE @T1 INT = SCOPE_IDENTITY();
    INSERT INTO TeacherSubject (TeacherId, SubjectId) VALUES (@T1, 1), (@T1, 3); -- Physics, Biology
    INSERT INTO TeacherDomain (TeacherId, DomainId, PriorityLevel) VALUES (@T1, 1, 1);

    -- Teacher 2
    INSERT INTO Person (FirstName, LastName, Phone, Email, Address, DateOfBirth, GenderId, CreatedAt)
    VALUES ('Fatima', 'Ali', '0300-2222222', 'fatima@edunova.edu', 'Lahore', '1988-07-20', 2, GETDATE());
    INSERT INTO Teacher (PersonId, EmployeeCode, Qualification, JoiningDate, Salary, IsActive, EndDate)
    VALUES (SCOPE_IDENTITY(), 'TCH002', 'MSc Chemistry', '2019-06-01', 72000, 1, NULL);
    DECLARE @T2 INT = SCOPE_IDENTITY();
    INSERT INTO TeacherSubject (TeacherId, SubjectId) VALUES (@T2, 2), (@T2, 1); -- Chemistry, Physics
    INSERT INTO TeacherDomain (TeacherId, DomainId, PriorityLevel) VALUES (@T2, 1, 1);

    -- Teacher 3
    INSERT INTO Person (FirstName, LastName, Phone, Email, Address, DateOfBirth, GenderId, CreatedAt)
    VALUES ('Usman', 'Farooq', '0300-3333333', 'usman@edunova.edu', 'Lahore', '1990-11-05', 1, GETDATE());
    INSERT INTO Teacher (PersonId, EmployeeCode, Qualification, JoiningDate, Salary, IsActive, EndDate)
    VALUES (SCOPE_IDENTITY(), 'TCH003', 'MSc Mathematics', '2021-03-10', 68000, 1, NULL);
    DECLARE @T3 INT = SCOPE_IDENTITY();
    INSERT INTO TeacherSubject (TeacherId, SubjectId) VALUES (@T3, 4); -- Math
    INSERT INTO TeacherDomain (TeacherId, DomainId, PriorityLevel) VALUES (@T3, 2, 1);

    -- Teacher 4
    INSERT INTO Person (FirstName, LastName, Phone, Email, Address, DateOfBirth, GenderId, CreatedAt)
    VALUES ('Sana', 'Rashid', '0300-4444444', 'sana@edunova.edu', 'Lahore', '1987-01-25', 2, GETDATE());
    INSERT INTO Teacher (PersonId, EmployeeCode, Qualification, JoiningDate, Salary, IsActive, EndDate)
    VALUES (SCOPE_IDENTITY(), 'TCH004', 'MA English', '2018-08-20', 70000, 1, NULL);
    DECLARE @T4 INT = SCOPE_IDENTITY();
    INSERT INTO TeacherSubject (TeacherId, SubjectId) VALUES (@T4, 5), (@T4, 6); -- English, Urdu
    INSERT INTO TeacherDomain (TeacherId, DomainId, PriorityLevel) VALUES (@T4, 3, 1);

    -- Teacher 5
    INSERT INTO Person (FirstName, LastName, Phone, Email, Address, DateOfBirth, GenderId, CreatedAt)
    VALUES ('Imran', 'Hussain', '0300-5555555', 'imran@edunova.edu', 'Lahore', '1983-09-12', 1, GETDATE());
    INSERT INTO Teacher (PersonId, EmployeeCode, Qualification, JoiningDate, Salary, IsActive, EndDate)
    VALUES (SCOPE_IDENTITY(), 'TCH005', 'MSc Computer Science', '2020-11-01', 80000, 1, NULL);
    DECLARE @T5 INT = SCOPE_IDENTITY();
    INSERT INTO TeacherSubject (TeacherId, SubjectId) VALUES (@T5, 9), (@T5, 4); -- CS, Math
    INSERT INTO TeacherDomain (TeacherId, DomainId, PriorityLevel) VALUES (@T5, 6, 1);

    -- Teacher 6
    INSERT INTO Person (FirstName, LastName, Phone, Email, Address, DateOfBirth, GenderId, CreatedAt)
    VALUES ('Rabia', 'Iqbal', '0300-6666666', 'rabia@edunova.edu', 'Lahore', '1992-04-18', 2, GETDATE());
    INSERT INTO Teacher (PersonId, EmployeeCode, Qualification, JoiningDate, Salary, IsActive, EndDate)
    VALUES (SCOPE_IDENTITY(), 'TCH006', 'MA Islamiat', '2022-01-05', 65000, 1, NULL);
    DECLARE @T6 INT = SCOPE_IDENTITY();
    INSERT INTO TeacherSubject (TeacherId, SubjectId) VALUES (@T6, 8), (@T6, 7); -- Islamiat, Pak Studies
    INSERT INTO TeacherDomain (TeacherId, DomainId, PriorityLevel) VALUES (@T6, 5, 1);
END;

-- Students (15 students)
IF NOT EXISTS(SELECT 1 FROM Student)
BEGIN
    INSERT INTO Person (FirstName, LastName, Phone, Email, Address, DateOfBirth, GenderId, CreatedAt) VALUES
    ('Ahmed', 'Hassan', '0301-1111111', 'ahmed.h@email.com', 'Lahore', '2015-05-10', 1, GETDATE()),
    ('Sara', 'Khan', '0301-2222222', 'sara.k@email.com', 'Lahore', '2015-08-15', 2, GETDATE()),
    ('Muhammad', 'Ali', '0301-3333333', 'm.ali@email.com', 'Lahore', '2014-03-20', 1, GETDATE()),
    ('Ayesha', 'Raza', '0301-4444444', 'ayesha.r@email.com', 'Lahore', '2014-11-25', 2, GETDATE()),
    ('Omar', 'Farooq', '0301-5555555', 'omar.f@email.com', 'Lahore', '2013-07-08', 1, GETDATE()),
    ('Zainab', 'Saleem', '0301-6666666', 'zainab.s@email.com', 'Lahore', '2013-09-12', 2, GETDATE()),
    ('Bilal', 'Akram', '0301-7777777', 'bilal.a@email.com', 'Lahore', '2012-01-30', 1, GETDATE()),
    ('Mariam', 'Tariq', '0301-8888888', 'mariam.t@email.com', 'Lahore', '2012-04-22', 2, GETDATE()),
    ('Hamza', 'Rafique', '0301-9999999', 'hamza.r@email.com', 'Lahore', '2011-06-18', 1, GETDATE()),
    ('Noor', 'Fatima', '0301-0000001', 'noor.f@email.com', 'Lahore', '2011-10-05', 2, GETDATE()),
    ('Danish', 'Mehmood', '0302-1111111', 'danish.m@email.com', 'Lahore', '2010-02-14', 1, GETDATE()),
    ('Hira', 'Aslam', '0302-2222222', 'hira.a@email.com', 'Lahore', '2010-07-28', 2, GETDATE()),
    ('Fahad', 'Nadeem', '0302-3333333', 'fahad.n@email.com', 'Lahore', '2009-09-03', 1, GETDATE()),
    ('Iqra', 'Khalid', '0302-4444444', 'iqra.k@email.com', 'Lahore', '2009-12-19', 2, GETDATE()),
    ('Saad', 'Javed', '0302-5555555', 'saad.j@email.com', 'Lahore', '2008-05-25', 1, GETDATE());

    INSERT INTO Student (PersonId, AdmissionNo, AdmissionDate, Age, RollNo, IsActive) VALUES
    (1, 'ADM-2024-001', GETDATE(), 9, 1, 1),
    (2, 'ADM-2024-002', GETDATE(), 9, 2, 1),
    (3, 'ADM-2024-003', GETDATE(), 10, 1, 1),
    (4, 'ADM-2024-004', GETDATE(), 10, 2, 1),
    (5, 'ADM-2024-005', GETDATE(), 11, 1, 1),
    (6, 'ADM-2024-006', GETDATE(), 11, 2, 1),
    (7, 'ADM-2024-007', GETDATE(), 12, 1, 1),
    (8, 'ADM-2024-008', GETDATE(), 12, 2, 1),
    (9, 'ADM-2024-009', GETDATE(), 13, 1, 1),
    (10, 'ADM-2024-010', GETDATE(), 13, 2, 1),
    (11, 'ADM-2024-011', GETDATE(), 14, 1, 1),
    (12, 'ADM-2024-012', GETDATE(), 14, 2, 1),
    (13, 'ADM-2024-013', GETDATE(), 15, 1, 1),
    (14, 'ADM-2024-014', GETDATE(), 15, 2, 1),
    (15, 'ADM-2024-015', GETDATE(), 16, 1, 1);

    -- Enrollments (students 1-2 in Class 1A, 3-4 in Class 2A, etc.)
    INSERT INTO Enrollment (StudentId, ClassSectionId, StartDate, AcademicYear, IsActive) VALUES
    (1, 1, GETDATE(), '2024-2025', 1), (2, 1, GETDATE(), '2024-2025', 1),
    (3, 3, GETDATE(), '2024-2025', 1), (4, 3, GETDATE(), '2024-2025', 1),
    (5, 5, GETDATE(), '2024-2025', 1), (6, 5, GETDATE(), '2024-2025', 1),
    (7, 7, GETDATE(), '2024-2025', 1), (8, 7, GETDATE(), '2024-2025', 1),
    (9, 9, GETDATE(), '2024-2025', 1), (10, 9, GETDATE(), '2024-2025', 1),
    (11, 11, GETDATE(), '2024-2025', 1), (12, 11, GETDATE(), '2024-2025', 1),
    (13, 13, GETDATE(), '2024-2025', 1), (14, 13, GETDATE(), '2024-2025', 1),
    (15, 15, GETDATE(), '2024-2025', 1);

    -- Guardians
    INSERT INTO Guardian (StudentId, Name, Relation, Phone, Occupation) VALUES
    (1, 'Hassan Ali', 'Father', '0300-1111111', 'Engineer'),
    (2, 'Kamran Khan', 'Father', '0300-2222222', 'Doctor'),
    (3, 'Ali Raza', 'Father', '0300-3333333', 'Businessman'),
    (4, 'Raza Ahmed', 'Father', '0300-4444444', 'Teacher'),
    (5, 'Farooq Zaman', 'Father', '0300-5555555', 'Banker'),
    (6, 'Saleem Khan', 'Father', '0300-6666666', 'Lawyer'),
    (7, 'Akram Hussain', 'Father', '0300-7777777', 'Manager'),
    (8, 'Tariq Mehmood', 'Father', '0300-8888888', 'Engineer'),
    (9, 'Rafique Ahmed', 'Father', '0300-9999999', 'Doctor'),
    (10, 'Kashif Ali', 'Father', '0301-0000001', 'Businessman'),
    (11, 'Mehmood Qasim', 'Father', '0301-1111112', 'Teacher'),
    (12, 'Aslam Khan', 'Father', '0301-2222223', 'Engineer'),
    (13, 'Nadeem Akram', 'Father', '0301-3333334', 'Doctor'),
    (14, 'Khalid Mehmood', 'Father', '0301-4444445', 'Lawyer'),
    (15, 'Javed Iqbal', 'Father', '0301-5555556', 'Banker');

    -- Student Profiles
    INSERT INTO StudentProfile (StudentId, EmergencyContact, BloodGroup, MedicalInfo, PreviousSchool) VALUES
    (1, '0300-1111111', 'A+', 'None', 'The City School'),
    (2, '0300-2222222', 'B+', 'None', 'Beaconhouse'),
    (3, '0300-3333333', 'O+', 'Asthma', 'LGS'),
    (4, '0300-4444444', 'AB+', 'None', 'The City School'),
    (5, '0300-5555555', 'A-', 'None', 'Beaconhouse'),
    (6, '0300-6666666', 'B-', 'Allergies', 'LGS'),
    (7, '0300-7777777', 'O+', 'None', 'The City School'),
    (8, '0300-8888888', 'A+', 'None', 'Beaconhouse'),
    (9, '0300-9999999', 'AB-', 'None', 'LGS'),
    (10, '0301-0000001', 'B+', 'None', 'The City School'),
    (11, '0301-1111112', 'O-', 'None', 'Beaconhouse'),
    (12, '0301-2222223', 'A+', 'Eczema', 'LGS'),
    (13, '0301-3333334', 'B+', 'None', 'The City School'),
    (14, '0301-4444445', 'O+', 'None', 'Beaconhouse'),
    (15, '0301-5555556', 'A-', 'None', 'LGS');
END;

-- Default Schedule Config: 08:00-13:30, 40min lectures, 15min break after 3rd period
IF NOT EXISTS(SELECT 1 FROM SchoolScheduleConfig)
BEGIN
    INSERT INTO SchoolScheduleConfig (EffectiveFrom, SchoolStart, SchoolEnd, LectureDuration, BreakDuration, BreakAfterPeriod, IsActive)
    VALUES ('2024-04-01', '08:00', '13:30', 40, 15, 3, 1);
    
    DECLARE @ConfigId INT = SCOPE_IDENTITY();
    
    -- Generate TimeSlots
    EXEC sp_GenerateTimeSlotsFromConfig @ConfigId;
END;

-- Sample Timetable Entries (for ClassSection 1 = Class 1A)
IF NOT EXISTS(SELECT 1 FROM TimetableEntry)
BEGIN
    -- Get time slot IDs for lectures only (not breaks)
    DECLARE @Slot1 INT, @Slot2 INT, @Slot3 INT, @Slot4 INT, @Slot5 INT, @Slot6 INT;
    SELECT @Slot1 = TimeSlotId FROM TimeSlot WHERE PeriodNo = 1;
    SELECT @Slot2 = TimeSlotId FROM TimeSlot WHERE PeriodNo = 2;
    SELECT @Slot3 = TimeSlotId FROM TimeSlot WHERE PeriodNo = 3;
    SELECT @Slot4 = TimeSlotId FROM TimeSlot WHERE PeriodNo = 5; -- After break
    SELECT @Slot5 = TimeSlotId FROM TimeSlot WHERE PeriodNo = 6;
    SELECT @Slot6 = TimeSlotId FROM TimeSlot WHERE PeriodNo = 7;
    
    INSERT INTO TimetableEntry (ClassSectionId, TimeSlotId, SubjectId, TeacherId, DayOfWeek, Room, IsActive) VALUES
    (1, @Slot1, 4, 3, 1, 'Room 101', 1), -- Class 1A, Mon, Math
    (1, @Slot2, 5, 4, 1, 'Room 101', 1), -- English
    (1, @Slot3, 6, 4, 1, 'Room 101', 1), -- Urdu
    (1, @Slot4, 1, 1, 1, 'Lab A', 1),    -- Physics
    (1, @Slot5, 8, 6, 1, 'Room 101', 1), -- Islamiat
    (3, @Slot1, 4, 3, 2, 'Room 102', 1), -- Class 2A, Tue, Math
    (3, @Slot2, 5, 4, 2, 'Room 102', 1), -- English
    (3, @Slot3, 2, 2, 2, 'Lab B', 1),    -- Chemistry
    (5, @Slot1, 4, 3, 3, 'Room 103', 1), -- Class 3A, Wed, Math
    (5, @Slot2, 1, 1, 3, 'Lab A', 1),    -- Physics
    (5, @Slot3, 9, 5, 3, 'Lab C', 1),    -- CS
    (7, @Slot1, 4, 3, 4, 'Room 104', 1), -- Class 4A, Thu, Math
    (7, @Slot2, 5, 4, 4, 'Room 104', 1), -- English
    (9, @Slot1, 1, 1, 5, 'Lab A', 1),    -- Class 5A, Fri, Physics
    (9, @Slot2, 2, 2, 5, 'Lab B', 1);    -- Chemistry
END;

-- FeeStructures
IF NOT EXISTS(SELECT 1 FROM FeeStructure)
INSERT INTO FeeStructure (ClassSectionId, MonthlyFee, AdmissionFee, MiscFee) VALUES
(1, 5000, 15000, 500),
(3, 5500, 16500, 600),
(5, 6000, 18000, 700),
(7, 6500, 19500, 800),
(9, 7000, 21000, 900),
(11, 7500, 22500, 1000),
(13, 8000, 24000, 1100),
(15, 8500, 25500, 1200);

-- Fee Vouchers (sample for January 2024 - some paid, some due)
IF NOT EXISTS(SELECT 1 FROM FeeVoucher)
BEGIN
    INSERT INTO FeeVoucher (StudentId, ClassSectionId, Month, Year, TotalAmount, DueDate, StatusId)
    SELECT s.StudentId, e.ClassSectionId, 'January', 2024, fs.MonthlyFee, '2024-01-15', 1
    FROM Student s
    INNER JOIN Enrollment e ON s.StudentId = e.StudentId AND e.IsActive = 1
    INNER JOIN FeeStructure fs ON e.ClassSectionId = fs.ClassSectionId
    WHERE s.IsActive = 1;
    
    -- Pay some vouchers
    INSERT INTO FeePayment (VoucherId, PaidAmount, PaidOn, PaymentMethodId, ReceivedBy)
    SELECT TOP 10 VoucherId, TotalAmount, '2024-01-10', 1, 1
    FROM FeeVoucher WHERE StatusId = 1;
    
    -- Mark them as paid
    UPDATE FeeVoucher SET StatusId = 2 WHERE VoucherId IN (SELECT TOP 10 VoucherId FROM FeeVoucher);
END;

-- Exam Types and Exams
IF NOT EXISTS(SELECT 1 FROM Exam)
BEGIN
    INSERT INTO Exam (ExamName, ExamTypeId, ClassSectionId, SubjectId, ExamDate, TotalMarks, IsActive) VALUES
    ('Physics Monthly - Class 4A', 1, 7, 1, '2024-01-20', 50, 1),
    ('Chemistry Monthly - Class 5A', 1, 9, 2, '2024-01-22', 50, 1),
    ('Math Monthly - Class 1A', 1, 1, 4, '2024-01-18', 50, 1),
    ('English Monthly - Class 1A', 1, 1, 5, '2024-01-19', 50, 1);
    
    -- Marks for Physics exam (Class 4A, students 7-8)
    INSERT INTO Mark (ExamId, StudentId, ObtainedMarks, Grade) VALUES
    (1, 7, 42, 'A'), (1, 8, 38, 'B');
    
    -- Marks for Chemistry exam (Class 5A, students 9-10)
    INSERT INTO Mark (ExamId, StudentId, ObtainedMarks, Grade) VALUES
    (2, 9, 45, 'A'), (2, 10, 35, 'C');
    
    -- Marks for Math exam (Class 1A, students 1-2)
    INSERT INTO Mark (ExamId, StudentId, ObtainedMarks, Grade) VALUES
    (3, 1, 48, 'A+'), (3, 2, 40, 'A');
    
    -- Marks for English exam (Class 1A, students 1-2)
    INSERT INTO Mark (ExamId, StudentId, ObtainedMarks, Grade) VALUES
    (4, 1, 44, 'A'), (4, 2, 36, 'C');
END;

-- Library Books and Copies
IF NOT EXISTS(SELECT 1 FROM LibraryBook)
BEGIN
    INSERT INTO LibraryBook (Title, ISBN, Author, Category, TotalCopies, AvailableCopies, IsActive) VALUES
    ('Physics Part 1', '978-1234567890', 'Halliday & Resnick', 'Science', 5, 5, 1),
    ('Chemistry Part 1', '978-1234567891', 'Morrison & Boyd', 'Science', 4, 4, 1),
    ('Mathematics 9', '978-1234567892', 'RD Sharma', 'Mathematics', 6, 6, 1),
    ('English Grammar', '978-1234567893', 'Wren & Martin', 'Languages', 3, 3, 1),
    ('Computer Science 10', '978-1234567894', 'Sumita Arora', 'Computer', 4, 4, 1),
    ('Islamiat Studies', '978-1234567895', 'Hafiz Karimdad', 'Islamic', 3, 3, 1);
    
    -- Book Copies
    INSERT INTO BookCopy (BookId, CopyNo, IsAvailable)
    SELECT b.BookId, CAST(ROW_NUMBER() OVER (PARTITION BY b.BookId ORDER BY b.BookId) AS NVARCHAR(10)), 1
    FROM LibraryBook b
    CROSS JOIN (SELECT TOP 5 1 AS n UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL SELECT 4 UNION ALL SELECT 5) nums
    WHERE nums.n <= b.TotalCopies;
END;

-- Library Fine Policy
IF NOT EXISTS(SELECT 1 FROM LibraryFinePolicy)
INSERT INTO LibraryFinePolicy (FinePerDay, GraceDays) VALUES (10.00, 2);

-- Admin Users (Suraim, Umair, Mudabber, Izzan with Admin123)
-- Password: Admin123 (SHA256: 240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9)
IF NOT EXISTS(SELECT 1 FROM AppUser)
BEGIN
    INSERT INTO AppUser (Username, PasswordHash, DisplayName, RoleId, IsActive, CreatedAt, LastLogin) VALUES
    ('Suraim', '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9', 'Suraim Admin', 1, 1, GETDATE(), GETDATE()),
    ('Umair', '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9', 'Umair Admin', 1, 1, GETDATE(), GETDATE()),
    ('Mudabber', '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9', 'Mudabber Admin', 1, 1, GETDATE(), GETDATE()),
    ('Izzan', '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9', 'Izzan Admin', 1, 1, GETDATE(), GETDATE());
END;

-- Role Permissions
IF NOT EXISTS(SELECT 1 FROM RolePermission)
BEGIN
    INSERT INTO RolePermission (RoleId, PermissionCode) VALUES
    (1, 'Dashboard.View'),
    (1, 'Students.View'), (1, 'Students.Add'), (1, 'Students.Edit'), (1, 'Students.Delete'),
    (1, 'Teachers.View'), (1, 'Teachers.Add'), (1, 'Teachers.Edit'), (1, 'Teachers.Delete'),
    (1, 'Classes.View'), (1, 'Classes.Add'), (1, 'Classes.Edit'),
    (1, 'Subjects.View'), (1, 'Subjects.Add'), (1, 'Subjects.Edit'),
    (1, 'Timetable.View'), (1, 'Timetable.Edit'),
    (1, 'Attendance.View'), (1, 'Attendance.Mark'),
    (1, 'Exams.View'), (1, 'Exams.Add'), (1, 'Exams.Edit'),
    (1, 'Fees.View'), (1, 'Fees.Add'), (1, 'Fees.Edit'),
    (1, 'Library.View'), (1, 'Library.Add'), (1, 'Library.Edit'),
    (1, 'Reports.View'),
    (1, 'Admin.View'), (1, 'Admin.Users'), (1, 'Admin.Roles'), (1, 'Admin.Audit');
END;

-- Notification Preferences
IF NOT EXISTS(SELECT 1 FROM NotificationPreference)
INSERT INTO NotificationPreference (UserId, EnableInApp)
SELECT UserId, 1 FROM AppUser;

-- Sample Notifications
IF NOT EXISTS(SELECT 1 FROM Notification)
BEGIN
    INSERT INTO Notification (ToUserId, Title, Message, NotificationTypeId, IsRead, CreatedAt) VALUES
    (1, 'Welcome to EduNova', 'Welcome to EduNova School Management System!', 1, 0, GETDATE()),
    (1, 'Teacher Leave Request', 'Ahmad Khan has requested leave for tomorrow.', 2, 0, GETDATE()),
    (2, 'Fee Vouchers Generated', 'January 2024 fee vouchers have been generated.', 5, 0, GETDATE()),
    (3, 'Substitution Alert', 'You have been assigned as substitute for Physics class.', 4, 0, GETDATE()),
    (4, 'Low Attendance Warning', 'Some students have attendance below 75%.', 2, 0, GETDATE());
END;

-- Sample Attendance Records
IF NOT EXISTS(SELECT 1 FROM AttendanceRecord)
BEGIN
    INSERT INTO AttendanceRecord (StudentId, ClassSectionId, AttendanceDate, StatusId, MarkedBy, MarkedAt)
    SELECT s.StudentId, e.ClassSectionId, '2024-01-15', 1, 1, GETDATE()
    FROM Student s
    INNER JOIN Enrollment e ON s.StudentId = e.StudentId AND e.IsActive = 1
    WHERE s.IsActive = 1;
END;

-- Sample Audit Logs
IF NOT EXISTS(SELECT 1 FROM AuditLog)
BEGIN
    INSERT INTO AuditLog (Timestamp, UserId, Username, Action, EntityName, EntityId, Details) VALUES
    (GETDATE(), 1, 'Suraim', 'Login', 'AppUser', 1, 'User logged in successfully'),
    (GETDATE(), 1, 'Suraim', 'Insert', 'Student', 1, 'Added student Ahmed Hassan'),
    (GETDATE(), 2, 'Umair', 'Login', 'AppUser', 2, 'User logged in successfully'),
    (GETDATE(), 2, 'Umair', 'Update', 'FeeVoucher', 1, 'Paid voucher for student 1'),
    (GETDATE(), 3, 'Mudabber', 'Login', 'AppUser', 3, 'User logged in successfully'),
    (GETDATE(), 3, 'Mudabber', 'Insert', 'Exam', 1, 'Created Physics Monthly exam'),
    (GETDATE(), 4, 'Izzan', 'Login', 'AppUser', 4, 'User logged in successfully'),
    (GETDATE(), 4, 'Izzan', 'Insert', 'TimetableEntry', 1, 'Added timetable entry for Class 1A');
END;

GO

-- ============================================================
-- END OF SCRIPT - EduNovaDB Setup Complete
-- ============================================================
-- To verify installation:
-- SELECT * FROM AppUser;
-- SELECT * FROM vwStudentSummary;
-- EXEC sp_GetDashboardCounts;
-- ============================================================
