using System;
using System.Data;
using EduNova.Domain.Entities;
using EduNova.Domain.Enums;

namespace EduNova.Data.Mappers
{
    public static class StudentMapper
    {
        public static Student MapFromDataRow(DataRow r)
        {
            var gender = Gender.Other;
            if (HasColumn(r, "Gender") && r["Gender"] != DBNull.Value)
            {
                gender = (Gender)Convert.ToInt32(r["Gender"]);
            }
            else if (HasColumn(r, "GenderName"))
            {
                var genderName = r["GenderName"]?.ToString();
                if (!string.IsNullOrWhiteSpace(genderName) && Enum.TryParse(genderName, true, out Gender parsed))
                    gender = parsed;
            }

            return new Student
            {
                StudentId = Convert.ToInt32(r["StudentId"]),
                PersonId = GetInt(r, "PersonId") ?? 0,
                FirstName = GetString(r, "FirstName"),
                LastName = GetString(r, "LastName"),
                AdmissionNo = GetString(r, "AdmissionNo"),
                AdmissionDate = GetDate(r, "AdmissionDate") ?? default(DateTime),
                DateOfBirth = GetDate(r, "DateOfBirth"),
                Gender = gender,
                Phone = GetString(r, "Phone"),
                Email = GetString(r, "Email"),
                Address = GetString(r, "Address"),
                Age = GetInt(r, "Age"),
                RollNo = GetString(r, "RollNo"),
                IsActive = GetBool(r, "IsActive") ?? false,
                Profile = new StudentProfile
                {
                    StudentId = Convert.ToInt32(r["StudentId"]),
                    BloodGroup = GetString(r, "BloodGroup"),
                    MedicalConditions = GetString(r, "MedicalConditions") ?? GetString(r, "MedicalInfo"),
                    PreviousSchool = GetString(r, "PreviousSchool")
                },
                Guardian = new Guardian
                {
                    StudentId = Convert.ToInt32(r["StudentId"]),
                    Name = GetString(r, "GuardianName"),
                    Relation = GetString(r, "GuardianRelation"),
                    Phone = GetString(r, "GuardianPhone"),
                    Occupation = GetString(r, "GuardianOccupation"),
                    CNIC = GetString(r, "GuardianCNIC")
                }
            };
        }

        private static bool HasColumn(DataRow row, string name)
        {
            return row?.Table?.Columns?.Contains(name) == true;
        }

        private static string GetString(DataRow row, string name)
        {
            return HasColumn(row, name) && row[name] != DBNull.Value ? row[name].ToString() : null;
        }

        private static DateTime? GetDate(DataRow row, string name)
        {
            return HasColumn(row, name) && row[name] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row[name]) : null;
        }

        private static int? GetInt(DataRow row, string name)
        {
            return HasColumn(row, name) && row[name] != DBNull.Value ? (int?)Convert.ToInt32(row[name]) : null;
        }

        private static bool? GetBool(DataRow row, string name)
        {
            return HasColumn(row, name) && row[name] != DBNull.Value ? (bool?)Convert.ToBoolean(row[name]) : null;
        }
    }
}
