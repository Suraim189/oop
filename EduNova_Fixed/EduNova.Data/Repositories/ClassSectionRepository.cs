using System.Data;

namespace EduNova.Data.Repositories
{
    public class ClassSectionRepository
    {
        public static DataTable GetAll()
        {
            var dt = SqlHelper.ExecuteDataTable("sp_ClassSection_GetAll");
            if (!dt.Columns.Contains("DisplayName"))
                dt.Columns.Add("DisplayName", typeof(string));
            if (!dt.Columns.Contains("TeacherName"))
                dt.Columns.Add("TeacherName", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                var className = row["ClassName"]?.ToString();
                var sectionName = row["SectionName"]?.ToString();
                row["DisplayName"] = string.Format("{0} - {1}", className, sectionName);
                if (row["TeacherName"] == DBNull.Value || row["TeacherName"] == null)
                    row["TeacherName"] = string.Empty;
            }
            return dt;
        }

        public static DataTable GetClasses()
        {
            return SqlHelper.ExecuteDataTable("sp_GradeClass_GetAll");
        }

        public static DataTable GetSections()
        {
            return SqlHelper.ExecuteDataTable("sp_Section_GetAll");
        }

        public static int InsertClass(string className, string description)
        {
            return SqlHelper.ExecuteNonQuery("sp_GradeClass_Insert",
                SqlHelper.Param("@ClassName", className),
                SqlHelper.Param("@Description", description));
        }

        public static int UpdateClass(int gradeClassId, string className, string description)
        {
            return SqlHelper.ExecuteNonQuery("sp_GradeClass_Update",
                SqlHelper.Param("@GradeClassId", gradeClassId),
                SqlHelper.Param("@ClassName", className),
                SqlHelper.Param("@Description", description));
        }

        public static int DeleteClass(int gradeClassId)
        {
            return SqlHelper.ExecuteNonQuery("sp_GradeClass_Delete",
                SqlHelper.Param("@GradeClassId", gradeClassId));
        }

        public static int InsertSection(int gradeClassId, int sectionId, int maxStudents)
        {
            return SqlHelper.ExecuteNonQuery("sp_ClassSection_Insert",
                SqlHelper.Param("@GradeClassId", gradeClassId),
            SqlHelper.Param("@SectionId", sectionId),
                SqlHelper.Param("@MaxStudents", maxStudents));
        }

        public static int DeleteSection(int classSectionId)
        {
            return SqlHelper.ExecuteNonQuery("sp_ClassSection_Delete",
                SqlHelper.Param("@ClassSectionId", classSectionId));
        }
    }
}
