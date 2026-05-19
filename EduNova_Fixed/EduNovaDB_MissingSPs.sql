-- ============================================================
-- MISSING STORED PROCEDURES - Add after running main script
-- Run this after EduNovaDB_CompleteScript.sql
-- ============================================================

USE EduNovaDB;
GO

-- Drop existing if re-running
IF OBJECT_ID('sp_GetAllUsers','P') IS NOT NULL DROP PROCEDURE sp_GetAllUsers;
IF OBJECT_ID('sp_GetAllRoles','P') IS NOT NULL DROP PROCEDURE sp_GetAllRoles;
IF OBJECT_ID('sp_GetAllPermissionCodes','P') IS NOT NULL DROP PROCEDURE sp_GetAllPermissionCodes;
IF OBJECT_ID('sp_GetRolePermissions','P') IS NOT NULL DROP PROCEDURE sp_GetRolePermissions;
IF OBJECT_ID('sp_SetRolePermissions','P') IS NOT NULL DROP PROCEDURE sp_SetRolePermissions;
IF OBJECT_ID('sp_InsertUser','P') IS NOT NULL DROP PROCEDURE sp_InsertUser;
IF OBJECT_ID('sp_UpdateUser','P') IS NOT NULL DROP PROCEDURE sp_UpdateUser;
IF OBJECT_ID('sp_UpdateUserPassword','P') IS NOT NULL DROP PROCEDURE sp_UpdateUserPassword;
IF OBJECT_ID('sp_DeleteUser','P') IS NOT NULL DROP PROCEDURE sp_DeleteUser;
IF OBJECT_ID('sp_Student_Search','P') IS NOT NULL DROP PROCEDURE sp_Student_Search;
IF OBJECT_ID('sp_Teacher_GetActive','P') IS NOT NULL DROP PROCEDURE sp_Teacher_GetActive;
IF OBJECT_ID('sp_GetTeacherSubjects','P') IS NOT NULL DROP PROCEDURE sp_GetTeacherSubjects;
IF OBJECT_ID('sp_SetTeacherSubjects','P') IS NOT NULL DROP PROCEDURE sp_SetTeacherSubjects;
IF OBJECT_ID('sp_GetScheduleConfig','P') IS NOT NULL DROP PROCEDURE sp_GetScheduleConfig;
IF OBJECT_ID('sp_GetTimetable','P') IS NOT NULL DROP PROCEDURE sp_GetTimetable;
IF OBJECT_ID('sp_GetTeacherTimetable','P') IS NOT NULL DROP PROCEDURE sp_GetTeacherTimetable;
IF OBJECT_ID('sp_GetUnassignedSlotsForSubject','P') IS NOT NULL DROP PROCEDURE sp_GetUnassignedSlotsForSubject;
IF OBJECT_ID('sp_GetTeacherLeaveRequests','P') IS NOT NULL DROP PROCEDURE sp_GetTeacherLeaveRequests;
IF OBJECT_ID('sp_GetTodaySubstitutions','P') IS NOT NULL DROP PROCEDURE sp_GetTodaySubstitutions;
IF OBJECT_ID('sp_ReplaceTeacherWizard_Preview','P') IS NOT NULL DROP PROCEDURE sp_ReplaceTeacherWizard_Preview;
IF OBJECT_ID('sp_GetExams','P') IS NOT NULL DROP PROCEDURE sp_GetExams;
IF OBJECT_ID('sp_GetStudentsForMarks','P') IS NOT NULL DROP PROCEDURE sp_GetStudentsForMarks;
IF OBJECT_ID('sp_GetExamResultsByClass','P') IS NOT NULL DROP PROCEDURE sp_GetExamResultsByClass;
IF OBJECT_ID('sp_GetFeeStructures','P') IS NOT NULL DROP PROCEDURE sp_GetFeeStructures;
IF OBJECT_ID('sp_SaveFeeStructure','P') IS NOT NULL DROP PROCEDURE sp_SaveFeeStructure;
IF OBJECT_ID('sp_GetVouchers','P') IS NOT NULL DROP PROCEDURE sp_GetVouchers;
IF OBJECT_ID('sp_SearchStudentVouchers','P') IS NOT NULL DROP PROCEDURE sp_SearchStudentVouchers;
IF OBJECT_ID('sp_GetStudentsForAttendance','P') IS NOT NULL DROP PROCEDURE sp_GetStudentsForAttendance;
IF OBJECT_ID('sp_GetLibraryBooks','P') IS NOT NULL DROP PROCEDURE sp_GetLibraryBooks;
IF OBJECT_ID('sp_InsertLibraryBook','P') IS NOT NULL DROP PROCEDURE sp_InsertLibraryBook;
IF OBJECT_ID('sp_UpdateLibraryBook','P') IS NOT NULL DROP PROCEDURE sp_UpdateLibraryBook;
IF OBJECT_ID('sp_DeleteLibraryBook','P') IS NOT NULL DROP PROCEDURE sp_DeleteLibraryBook;
IF OBJECT_ID('sp_GetIssuedBooks','P') IS NOT NULL DROP PROCEDURE sp_GetIssuedBooks;
IF OBJECT_ID('sp_GetLibraryFinePolicies','P') IS NOT NULL DROP PROCEDURE sp_GetLibraryFinePolicies;
IF OBJECT_ID('sp_Subject_GetAll','P') IS NOT NULL DROP PROCEDURE sp_Subject_GetAll;
IF OBJECT_ID('sp_Domain_GetAll','P') IS NOT NULL DROP PROCEDURE sp_Domain_GetAll;
IF OBJECT_ID('sp_Subject_Insert','P') IS NOT NULL DROP PROCEDURE sp_Subject_Insert;
IF OBJECT_ID('sp_Subject_Update','P') IS NOT NULL DROP PROCEDURE sp_Subject_Update;
IF OBJECT_ID('sp_Subject_Delete','P') IS NOT NULL DROP PROCEDURE sp_Subject_Delete;
IF OBJECT_ID('sp_ClassSection_GetAll','P') IS NOT NULL DROP PROCEDURE sp_ClassSection_GetAll;
IF OBJECT_ID('sp_GradeClass_GetAll','P') IS NOT NULL DROP PROCEDURE sp_GradeClass_GetAll;
IF OBJECT_ID('sp_GradeClass_Insert','P') IS NOT NULL DROP PROCEDURE sp_GradeClass_Insert;
IF OBJECT_ID('sp_GradeClass_Update','P') IS NOT NULL DROP PROCEDURE sp_GradeClass_Update;
IF OBJECT_ID('sp_GradeClass_Delete','P') IS NOT NULL DROP PROCEDURE sp_GradeClass_Delete;
IF OBJECT_ID('sp_Section_GetAll','P') IS NOT NULL DROP PROCEDURE sp_Section_GetAll;
IF OBJECT_ID('sp_ClassSection_Insert','P') IS NOT NULL DROP PROCEDURE sp_ClassSection_Insert;
IF OBJECT_ID('sp_ClassSection_Delete','P') IS NOT NULL DROP PROCEDURE sp_ClassSection_Delete;
IF OBJECT_ID('sp_GetSubstitutionReport','P') IS NOT NULL DROP PROCEDURE sp_GetSubstitutionReport;
IF OBJECT_ID('sp_DeleteExam','P') IS NOT NULL DROP PROCEDURE sp_DeleteExam;
GO

-- ============================================
-- ADMIN / USER MANAGEMENT SPs
-- ============================================

CREATE PROCEDURE sp_GetAllUsers
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
        u.CreatedAt,
        u.LastLogin
    FROM AppUser u
    INNER JOIN UserRole r ON u.RoleId = r.RoleId
    ORDER BY u.Username;
END;
GO

CREATE PROCEDURE sp_GetAllRoles
AS
BEGIN
    SET NOCOUNT ON;
    SELECT RoleId, RoleName FROM UserRole ORDER BY RoleId;
END;
GO

CREATE PROCEDURE sp_GetAllPermissionCodes
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DISTINCT PermissionCode FROM RolePermission ORDER BY PermissionCode;
END;
GO

CREATE PROCEDURE sp_GetRolePermissions
    @RoleId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT PermissionCode FROM RolePermission WHERE RoleId = @RoleId ORDER BY PermissionCode;
END;
GO

CREATE PROCEDURE sp_SetRolePermissions
    @RoleId INT,
    @PermissionCodes NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM RolePermission WHERE RoleId = @RoleId;
    IF @PermissionCodes IS NOT NULL AND LEN(@PermissionCodes) > 0
    BEGIN
        INSERT INTO RolePermission (RoleId, PermissionCode)
        SELECT @RoleId, LTRIM(RTRIM(value))
        FROM STRING_SPLIT(@PermissionCodes, ',')
        WHERE LTRIM(RTRIM(value)) <> '';
    END
END;
GO

CREATE PROCEDURE sp_InsertUser
    @Username NVARCHAR(50),
    @DisplayName NVARCHAR(100),
    @PasswordHash NVARCHAR(64),
    @RoleId INT,
    @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO AppUser (Username, PasswordHash, DisplayName, RoleId, IsActive, CreatedAt)
    VALUES (@Username, @PasswordHash, @DisplayName, @RoleId, @IsActive, GETDATE());
    SELECT SCOPE_IDENTITY() AS UserId;
END;
GO

CREATE PROCEDURE sp_UpdateUser
    @UserId INT,
    @Username NVARCHAR(50),
    @DisplayName NVARCHAR(100),
    @RoleId INT,
    @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE AppUser SET
        Username = @Username,
        DisplayName = @DisplayName,
        RoleId = @RoleId,
        IsActive = @IsActive,
        UpdatedAt = GETDATE()
    WHERE UserId = @UserId;
END;
GO

CREATE PROCEDURE sp_UpdateUserPassword
    @UserId INT,
    @PasswordHash NVARCHAR(64)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE AppUser SET PasswordHash = @PasswordHash WHERE UserId = @UserId;
END;
GO

CREATE PROCEDURE sp_DeleteUser
    @UserId INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM AppUser WHERE UserId = @UserId;
END;
GO

-- ============================================
-- STUDENT SEARCH SP
-- ============================================

CREATE PROCEDURE sp_Student_Search
    @Keyword NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vwStudentSummary
    WHERE @Keyword IS NULL 
       OR FullName LIKE '%' + @Keyword + '%' 
       OR AdmissionNo LIKE '%' + @Keyword + '%'
       OR GuardianPhone LIKE '%' + @Keyword + '%'
    ORDER BY FullName;
END;
GO

-- ============================================
-- TEACHER ADDITIONAL SPs
-- ============================================

CREATE PROCEDURE sp_Teacher_GetActive
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
        t.IsActive
    FROM Teacher t
    INNER JOIN Person p ON t.PersonId = p.PersonId
    WHERE t.IsActive = 1
    ORDER BY p.FirstName;
END;
GO

CREATE PROCEDURE sp_GetTeacherSubjects
    @TeacherId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT ts.SubjectId, s.SubjectName, s.SubjectCode
    FROM TeacherSubject ts
    INNER JOIN Subject s ON ts.SubjectId = s.SubjectId
    WHERE ts.TeacherId = @TeacherId;
END;
GO

CREATE PROCEDURE sp_SetTeacherSubjects
    @TeacherId INT,
    @SubjectId INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS(SELECT 1 FROM TeacherSubject WHERE TeacherId = @TeacherId AND SubjectId = @SubjectId)
    BEGIN
        INSERT INTO TeacherSubject (TeacherId, SubjectId) VALUES (@TeacherId, @SubjectId);
    END
END;
GO

-- ============================================
-- TIMETABLE ADDITIONAL SPs
-- ============================================

CREATE PROCEDURE sp_GetScheduleConfig
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 * FROM SchoolScheduleConfig WHERE IsActive = 1 ORDER BY EffectiveFrom DESC;
END;
GO

CREATE PROCEDURE sp_GetTimetable
    @ClassSectionId INT,
    @DayOfWeek INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        te.TimetableEntryId,
        te.ClassSectionId,
        te.TimeSlotId,
        ts.PeriodNo,
        ts.StartTime,
        ts.EndTime,
        st.TypeName AS SlotType,
        te.SubjectId,
        s.SubjectName,
        te.TeacherId,
        p.FirstName + ' ' + p.LastName AS TeacherName,
        te.DayOfWeek,
        te.Room,
        te.IsActive
    FROM TimetableEntry te
    INNER JOIN TimeSlot ts ON te.TimeSlotId = ts.TimeSlotId
    INNER JOIN SlotType st ON ts.SlotTypeId = st.SlotTypeId
    LEFT JOIN Subject s ON te.SubjectId = s.SubjectId
    LEFT JOIN Teacher t ON te.TeacherId = t.TeacherId
    LEFT JOIN Person p ON t.PersonId = p.PersonId
    WHERE te.ClassSectionId = @ClassSectionId
    AND te.DayOfWeek = @DayOfWeek
    AND te.IsActive = 1
    ORDER BY ts.PeriodNo;
END;
GO

CREATE PROCEDURE sp_GetTeacherTimetable
    @TeacherId INT,
    @DayOfWeek INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        te.TimetableEntryId,
        te.ClassSectionId,
        gc.ClassName + ' - ' + sec.SectionName AS ClassSectionName,
        te.TimeSlotId,
        ts.PeriodNo,
        ts.StartTime,
        ts.EndTime,
        st.TypeName AS SlotType,
        te.SubjectId,
        s.SubjectName,
        te.TeacherId,
        te.DayOfWeek,
        te.Room,
        te.IsActive
    FROM TimetableEntry te
    INNER JOIN TimeSlot ts ON te.TimeSlotId = ts.TimeSlotId
    INNER JOIN SlotType st ON ts.SlotTypeId = st.SlotTypeId
    LEFT JOIN Subject s ON te.SubjectId = s.SubjectId
    INNER JOIN ClassSection cs ON te.ClassSectionId = cs.ClassSectionId
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    WHERE te.TeacherId = @TeacherId
    AND te.DayOfWeek = @DayOfWeek
    AND te.IsActive = 1
    ORDER BY ts.PeriodNo;
END;
GO

CREATE PROCEDURE sp_GetUnassignedSlotsForSubject
    @ClassSectionId INT,
    @SubjectId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        ts.TimeSlotId,
        ts.PeriodNo,
        ts.StartTime,
        ts.EndTime
    FROM TimeSlot ts
    INNER JOIN SchoolScheduleConfig sc ON ts.ConfigId = sc.ConfigId
    WHERE sc.IsActive = 1
    AND ts.SlotTypeId = 1 -- Lecture only
    AND NOT EXISTS (
        SELECT 1 FROM TimetableEntry te
        WHERE te.ClassSectionId = @ClassSectionId
        AND te.TimeSlotId = ts.TimeSlotId
        AND te.IsActive = 1
    );
END;
GO

CREATE PROCEDURE sp_GetTeacherLeaveRequests
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        lr.LeaveRequestId,
        lr.TeacherId,
        p.FirstName + ' ' + p.LastName AS TeacherName,
        lr.LeaveDate,
        lr.FromTime,
        lr.ToTime,
        lr.Reason,
        ls.StatusName,
        lr.RequestedAt
    FROM TeacherLeaveRequest lr
    INNER JOIN Teacher t ON lr.TeacherId = t.TeacherId
    INNER JOIN Person p ON t.PersonId = p.PersonId
    INNER JOIN LeaveStatus ls ON lr.StatusId = ls.StatusId
    ORDER BY lr.RequestedAt DESC;
END;
GO

CREATE PROCEDURE sp_GetTodaySubstitutions
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        sa.SubstitutionId,
        sa.TimetableEntryId,
        sa.LeaveDate,
        sa.OriginalTeacherId,
        op.FirstName + ' ' + op.LastName AS OriginalTeacherName,
        sa.SubstituteTeacherId,
        sp.FirstName + ' ' + sp.LastName AS SubstituteTeacherName,
        s.SubjectName,
        ts.StartTime,
        ts.EndTime,
        gc.ClassName + ' - ' + sec.SectionName AS ClassSectionName,
        sa.Reason,
        ss.StatusName
    FROM SubstitutionAssignment sa
    INNER JOIN Teacher ot ON sa.OriginalTeacherId = ot.TeacherId
    INNER JOIN Person op ON ot.PersonId = op.PersonId
    LEFT JOIN Teacher st ON sa.SubstituteTeacherId = st.TeacherId
    LEFT JOIN Person sp ON st.PersonId = sp.PersonId
    INNER JOIN TimetableEntry te ON sa.TimetableEntryId = te.TimetableEntryId
    INNER JOIN Subject s ON te.SubjectId = s.SubjectId
    INNER JOIN TimeSlot ts ON te.TimeSlotId = ts.TimeSlotId
    INNER JOIN ClassSection cs ON te.ClassSectionId = cs.ClassSectionId
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    INNER JOIN SubstitutionStatus ss ON sa.StatusId = ss.StatusId
    WHERE sa.LeaveDate = CAST(GETDATE() AS DATE)
    ORDER BY ts.StartTime;
END;
GO

CREATE PROCEDURE sp_ReplaceTeacherWizard_Preview
    @OldTeacherId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        te.TimetableEntryId,
        te.DayOfWeek,
        ts.PeriodNo,
        ts.StartTime,
        ts.EndTime,
        s.SubjectName,
        gc.ClassName + ' - ' + sec.SectionName AS ClassSectionName,
        CASE WHEN EXISTS (SELECT 1 FROM TeacherSubject ts WHERE ts.TeacherId <> @OldTeacherId AND ts.SubjectId = te.SubjectId) 
             THEN 'Can Transfer' ELSE 'No Qualified Teacher' END AS TransferStatus
    FROM TimetableEntry te
    INNER JOIN TimeSlot ts ON te.TimeSlotId = ts.TimeSlotId
    INNER JOIN Subject s ON te.SubjectId = s.SubjectId
    INNER JOIN ClassSection cs ON te.ClassSectionId = cs.ClassSectionId
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    WHERE te.TeacherId = @OldTeacherId
    AND te.IsActive = 1
    ORDER BY te.DayOfWeek, ts.PeriodNo;
END;
GO


-- ============================================
-- EXAM ADDITIONAL SPs
-- ============================================

CREATE PROCEDURE sp_GetExams
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        e.ExamId,
        e.ExamName,
        et.TypeName AS ExamType,
        gc.ClassName + ' - ' + sec.SectionName AS ClassSection,
        s.SubjectName,
        e.ExamDate,
        e.TotalMarks,
        e.IsActive
    FROM Exam e
    INNER JOIN ExamType et ON e.ExamTypeId = et.ExamTypeId
    INNER JOIN ClassSection cs ON e.ClassSectionId = cs.ClassSectionId
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    INNER JOIN Subject s ON e.SubjectId = s.SubjectId
    ORDER BY e.ExamDate DESC;
END;
GO

CREATE PROCEDURE sp_GetStudentsForMarks
    @ExamId INT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @ClassSectionId INT, @SubjectId INT;
    SELECT @ClassSectionId = ClassSectionId, @SubjectId = SubjectId FROM Exam WHERE ExamId = @ExamId;
    
    SELECT
        s.StudentId,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        s.RollNo,
        ISNULL(m.ObtainedMarks, 0) AS ObtainedMarks,
        ISNULL(m.Grade, '-') AS Grade,
        e.TotalMarks
    FROM Student s
    INNER JOIN Person p ON s.PersonId = p.PersonId
    INNER JOIN Enrollment en ON s.StudentId = en.StudentId AND en.ClassSectionId = @ClassSectionId AND en.IsActive = 1
    LEFT JOIN Mark m ON s.StudentId = m.StudentId AND m.ExamId = @ExamId
    CROSS JOIN Exam e
    WHERE e.ExamId = @ExamId
    AND s.IsActive = 1
    ORDER BY p.FirstName;
END;
GO

CREATE PROCEDURE sp_GetExamResultsByClass
    @ExamId INT,
    @ClassSectionId INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        s.StudentId,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        s.RollNo,
        e.TotalMarks,
        ISNULL(m.ObtainedMarks, 0) AS ObtainedMarks,
        ISNULL(m.Grade, 'N/A') AS Grade,
        CASE WHEN e.TotalMarks > 0 THEN CAST(CAST(ISNULL(m.ObtainedMarks, 0) AS DECIMAL) * 100 / e.TotalMarks AS DECIMAL(5,2)) ELSE 0 END AS Percentage
    FROM Student s
    INNER JOIN Person p ON s.PersonId = p.PersonId
    INNER JOIN Enrollment en ON s.StudentId = en.StudentId AND en.ClassSectionId = @ClassSectionId AND en.IsActive = 1
    CROSS JOIN Exam e
    LEFT JOIN Mark m ON s.StudentId = m.StudentId AND m.ExamId = @ExamId
    WHERE e.ExamId = @ExamId
    AND s.IsActive = 1
    ORDER BY p.FirstName;
END;
GO

CREATE PROCEDURE sp_DeleteExam
    @ExamId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Exam SET IsActive = 0 WHERE ExamId = @ExamId;
END;
GO

-- ============================================
-- FEE ADDITIONAL SPs
-- ============================================

CREATE PROCEDURE sp_GetFeeStructures
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        fs.FeeStructureId,
        fs.ClassSectionId,
        gc.ClassName + ' - ' + sec.SectionName AS ClassSectionName,
        fs.MonthlyFee,
        fs.AdmissionFee,
        fs.MiscFee
    FROM FeeStructure fs
    INNER JOIN ClassSection cs ON fs.ClassSectionId = cs.ClassSectionId
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    ORDER BY gc.ClassName, sec.SectionName;
END;
GO

CREATE PROCEDURE sp_SaveFeeStructure
    @ClassSectionId INT,
    @MonthlyFee DECIMAL(18,2),
    @AdmissionFee DECIMAL(18,2),
    @MiscFee DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS(SELECT 1 FROM FeeStructure WHERE ClassSectionId = @ClassSectionId)
    BEGIN
        UPDATE FeeStructure SET MonthlyFee = @MonthlyFee, AdmissionFee = @AdmissionFee, MiscFee = @MiscFee
        WHERE ClassSectionId = @ClassSectionId;
    END
    ELSE
    BEGIN
        INSERT INTO FeeStructure (ClassSectionId, MonthlyFee, AdmissionFee, MiscFee)
        VALUES (@ClassSectionId, @MonthlyFee, @AdmissionFee, @MiscFee);
    END
END;
GO

CREATE PROCEDURE sp_GetVouchers
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        fv.VoucherId,
        fv.StudentId,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        fv.ClassSectionId,
        fv.Month,
        fv.Year,
        fv.TotalAmount,
        fv.DueDate,
        vs.StatusName
    FROM FeeVoucher fv
    INNER JOIN Student s ON fv.StudentId = s.StudentId
    INNER JOIN Person p ON s.PersonId = p.PersonId
    INNER JOIN VoucherStatus vs ON fv.StatusId = vs.StatusId
    ORDER BY fv.Year DESC, fv.Month DESC;
END;
GO

CREATE PROCEDURE sp_SearchStudentVouchers
    @Keyword NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        fv.VoucherId,
        fv.StudentId,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        fv.Month,
        fv.Year,
        fv.TotalAmount,
        fv.DueDate,
        vs.StatusName
    FROM FeeVoucher fv
    INNER JOIN Student s ON fv.StudentId = s.StudentId
    INNER JOIN Person p ON s.PersonId = p.PersonId
    INNER JOIN VoucherStatus vs ON fv.StatusId = vs.StatusId
    WHERE p.FirstName LIKE '%' + @Keyword + '%'
       OR p.LastName LIKE '%' + @Keyword + '%'
       OR s.AdmissionNo LIKE '%' + @Keyword + '%'
    ORDER BY fv.Year DESC, fv.Month DESC;
END;
GO

-- ============================================
-- ATTENDANCE SP
-- ============================================

CREATE PROCEDURE sp_GetStudentsForAttendance
    @ClassSectionId INT,
    @AttendanceDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        s.StudentId,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        s.RollNo,
        ISNULL(ar.StatusId, 0) AS StatusId,
        ISNULL(ast.StatusName, 'Not Marked') AS StatusName
    FROM Student s
    INNER JOIN Person p ON s.PersonId = p.PersonId
    INNER JOIN Enrollment en ON s.StudentId = en.StudentId AND en.ClassSectionId = @ClassSectionId AND en.IsActive = 1
    LEFT JOIN AttendanceRecord ar ON s.StudentId = ar.StudentId AND ar.AttendanceDate = @AttendanceDate
    LEFT JOIN AttendanceStatus ast ON ar.StatusId = ast.StatusId
    WHERE s.IsActive = 1
    ORDER BY p.FirstName;
END;
GO

-- ============================================
-- LIBRARY SPs
-- ============================================

CREATE PROCEDURE sp_GetLibraryBooks
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        b.BookId,
        b.Title,
        b.ISBN,
        b.Author,
        b.Category,
        b.TotalCopies,
        b.AvailableCopies,
        bs.StatusName AS Status,
        b.IsActive
    FROM LibraryBook b
    LEFT JOIN BookStatus bs ON b.StatusId = bs.StatusId
    WHERE b.IsActive = 1
    ORDER BY b.Title;
END;
GO

CREATE PROCEDURE sp_InsertLibraryBook
    @Title NVARCHAR(200),
    @ISBN NVARCHAR(20),
    @Author NVARCHAR(100),
    @Category NVARCHAR(50),
    @TotalCopies INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        INSERT INTO LibraryBook (Title, ISBN, Author, Category, TotalCopies, AvailableCopies, IsActive)
        VALUES (@Title, @ISBN, @Author, @Category, @TotalCopies, @TotalCopies, 1);
        
        DECLARE @BookId INT = SCOPE_IDENTITY();
        DECLARE @i INT = 1;
        WHILE @i <= @TotalCopies
        BEGIN
            INSERT INTO BookCopy (BookId, CopyNo, IsAvailable) VALUES (@BookId, CAST(@i AS NVARCHAR(10)), 1);
            SET @i = @i + 1;
        END
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO

CREATE PROCEDURE sp_UpdateLibraryBook
    @BookId INT,
    @Title NVARCHAR(200),
    @ISBN NVARCHAR(20),
    @Author NVARCHAR(100),
    @Category NVARCHAR(50),
    @TotalCopies INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE LibraryBook SET
        Title = @Title,
        ISBN = @ISBN,
        Author = @Author,
        Category = @Category,
        TotalCopies = @TotalCopies
    WHERE BookId = @BookId;
END;
GO

CREATE PROCEDURE sp_DeleteLibraryBook
    @BookId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE LibraryBook SET IsActive = 0 WHERE BookId = @BookId;
    UPDATE BookCopy SET IsAvailable = 0 WHERE BookId = @BookId;
END;
GO

CREATE PROCEDURE sp_GetIssuedBooks
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        bi.IssueId,
        lb.Title,
        lb.ISBN,
        p.FirstName + ' ' + p.LastName AS StudentName,
        s.AdmissionNo,
        bi.IssuedOn,
        bi.DueDate,
        bi.ReturnedOn,
        bi.Fine,
        bi.IsReturned
    FROM BookIssue bi
    INNER JOIN BookCopy bc ON bi.CopyId = bc.CopyId
    INNER JOIN LibraryBook lb ON bc.BookId = lb.BookId
    INNER JOIN Student s ON bi.StudentId = s.StudentId
    INNER JOIN Person p ON s.PersonId = p.PersonId
    WHERE bi.IsReturned = 0
    ORDER BY bi.DueDate;
END;
GO

CREATE PROCEDURE sp_GetLibraryFinePolicies
AS
BEGIN
    SET NOCOUNT ON;
    SELECT PolicyId, FinePerDay, GraceDays FROM LibraryFinePolicy;
END;
GO

-- ============================================
-- SUBJECT / DOMAIN SPs
-- ============================================

CREATE PROCEDURE sp_Subject_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        s.SubjectId,
        s.SubjectName,
        s.SubjectCode,
        s.DomainId,
        sd.DomainName,
        s.IsActive
    FROM Subject s
    LEFT JOIN SubjectDomain sd ON s.DomainId = sd.DomainId
    ORDER BY s.SubjectName;
END;
GO

CREATE PROCEDURE sp_Domain_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT DomainId, DomainName FROM SubjectDomain ORDER BY DomainName;
END;
GO

CREATE PROCEDURE sp_Subject_Insert
    @SubjectName NVARCHAR(100),
    @SubjectCode NVARCHAR(20),
    @DomainId INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Subject (SubjectName, SubjectCode, DomainId, IsActive)
    VALUES (@SubjectName, @SubjectCode, @DomainId, 1);
    SELECT SCOPE_IDENTITY() AS SubjectId;
END;
GO

CREATE PROCEDURE sp_Subject_Update
    @SubjectId INT,
    @SubjectName NVARCHAR(100),
    @SubjectCode NVARCHAR(20),
    @DomainId INT,
    @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Subject SET
        SubjectName = @SubjectName,
        SubjectCode = @SubjectCode,
        DomainId = @DomainId,
        IsActive = @IsActive
    WHERE SubjectId = @SubjectId;
END;
GO

CREATE PROCEDURE sp_Subject_Delete
    @SubjectId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Subject SET IsActive = 0 WHERE SubjectId = @SubjectId;
END;
GO

-- ============================================
-- CLASS / SECTION SPs
-- ============================================

CREATE PROCEDURE sp_ClassSection_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        cs.ClassSectionId,
        cs.GradeClassId,
        gc.ClassName,
        cs.SectionId,
        sec.SectionName,
        cs.MaxStudents,
        cs.IsActive
    FROM ClassSection cs
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    ORDER BY gc.ClassName, sec.SectionName;
END;
GO

CREATE PROCEDURE sp_GradeClass_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        gc.GradeClassId,
        gc.ClassName,
        gc.Description,
        COUNT(cs.ClassSectionId) AS SectionCount
    FROM GradeClass gc
    LEFT JOIN ClassSection cs ON cs.GradeClassId = gc.GradeClassId AND cs.IsActive = 1
    GROUP BY gc.GradeClassId, gc.ClassName, gc.Description
    ORDER BY gc.ClassName;
END;
GO

CREATE PROCEDURE sp_GradeClass_Insert
    @ClassName NVARCHAR(50),
    @Description NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO GradeClass (ClassName, Description) VALUES (@ClassName, @Description);
    SELECT SCOPE_IDENTITY() AS GradeClassId;
END;
GO

CREATE PROCEDURE sp_GradeClass_Update
    @GradeClassId INT,
    @ClassName NVARCHAR(50),
    @Description NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE GradeClass SET ClassName = @ClassName, Description = @Description WHERE GradeClassId = @GradeClassId;
END;
GO

CREATE PROCEDURE sp_GradeClass_Delete
    @GradeClassId INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM GradeClass WHERE GradeClassId = @GradeClassId;
END;
GO

CREATE PROCEDURE sp_Section_GetAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT SectionId, SectionName FROM Section ORDER BY SectionName;
END;
GO

CREATE PROCEDURE sp_ClassSection_Insert
    @GradeClassId INT,
    @SectionId INT,
    @MaxStudents INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS(SELECT 1 FROM ClassSection WHERE GradeClassId = @GradeClassId AND SectionId = @SectionId)
    BEGIN
        INSERT INTO ClassSection (GradeClassId, SectionId, MaxStudents, IsActive)
        VALUES (@GradeClassId, @SectionId, @MaxStudents, 1);
    END
END;
GO

CREATE PROCEDURE sp_ClassSection_Delete
    @ClassSectionId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE ClassSection SET IsActive = 0 WHERE ClassSectionId = @ClassSectionId;
END;
GO

-- ============================================
-- REPORTS SP
-- ============================================

CREATE PROCEDURE sp_GetSubstitutionReport
    @FromDate DATE,
    @ToDate DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        sa.SubstitutionId,
        sa.LeaveDate,
        op.FirstName + ' ' + op.LastName AS OriginalTeacher,
        sp.FirstName + ' ' + sp.LastName AS SubstituteTeacher,
        s.SubjectName,
		CONVERT(VARCHAR(8), ts.StartTime, 108) + ' - ' + CONVERT(VARCHAR(8), ts.EndTime, 108) AS TimeSlot,
        gc.ClassName + ' - ' + sec.SectionName AS ClassSection,
        ss.StatusName
    FROM SubstitutionAssignment sa
    INNER JOIN Teacher ot ON sa.OriginalTeacherId = ot.TeacherId
    INNER JOIN Person op ON ot.PersonId = op.PersonId
    LEFT JOIN Teacher st ON sa.SubstituteTeacherId = st.TeacherId
    LEFT JOIN Person sp ON st.PersonId = sp.PersonId
    INNER JOIN TimetableEntry te ON sa.TimetableEntryId = te.TimetableEntryId
    INNER JOIN Subject s ON te.SubjectId = s.SubjectId
    INNER JOIN TimeSlot ts ON te.TimeSlotId = ts.TimeSlotId
    INNER JOIN ClassSection cs ON te.ClassSectionId = cs.ClassSectionId
    INNER JOIN GradeClass gc ON cs.GradeClassId = gc.GradeClassId
    INNER JOIN Section sec ON cs.SectionId = sec.SectionId
    INNER JOIN SubstitutionStatus ss ON sa.StatusId = ss.StatusId
    WHERE sa.LeaveDate BETWEEN @FromDate AND @ToDate
    ORDER BY sa.LeaveDate DESC;
END;
GO

-- ============================================
-- NOTIFICATION SPs (with correct signatures)
-- ============================================

ALTER PROCEDURE sp_CreateNotification
    @Title NVARCHAR(200),
    @Message NVARCHAR(500),
    @NotificationType INT,
    @TargetUserId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF @TargetUserId IS NOT NULL
    BEGIN
        INSERT INTO Notification (ToUserId, Title, Message, NotificationTypeId, IsRead, CreatedAt)
        VALUES (@TargetUserId, @Title, @Message, @NotificationType, 0, GETDATE());
    END
    ELSE
    BEGIN
        INSERT INTO Notification (ToUserId, Title, Message, NotificationTypeId, IsRead, CreatedAt)
        SELECT UserId, @Title, @Message, @NotificationType, 0, GETDATE()
        FROM AppUser WHERE IsActive = 1;
    END
END;
GO

ALTER PROCEDURE sp_GetUnreadNotifications
    @UserId INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        n.NotificationId,
        n.Title,
        n.Message,
        nt.TypeName AS NotificationType,
        n.IsRead,
        n.CreatedAt
    FROM Notification n
    INNER JOIN NotificationType nt ON n.NotificationTypeId = nt.TypeId
    WHERE (@UserId IS NULL OR n.ToUserId = @UserId)
    AND (@UserId IS NOT NULL AND n.IsRead = 0)
    ORDER BY n.CreatedAt DESC;
END;
GO

ALTER PROCEDURE sp_MarkNotificationRead
    @NotificationId INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Notification SET IsRead = 1 WHERE NotificationId = @NotificationId;
END;
GO

-- ============================================================
-- END OF MISSING SPs SCRIPT
-- ============================================================
