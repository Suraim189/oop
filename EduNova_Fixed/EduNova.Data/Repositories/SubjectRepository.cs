using System.Data;

namespace EduNova.Data.Repositories
{
    public class SubjectRepository
    {
        public static DataTable GetAll()
        {
            return SqlHelper.ExecuteDataTable("sp_Subject_GetAll");
        }

        public static DataTable GetDomains()
        {
            return SqlHelper.ExecuteDataTable("sp_Domain_GetAll");
        }

        public static int Insert(string subjectName, string subjectCode, int domainId, bool isActive)
        {
            return SqlHelper.ExecuteNonQuery("sp_Subject_Insert",
                SqlHelper.Param("@SubjectName", subjectName),
                SqlHelper.Param("@SubjectCode", subjectCode),
            SqlHelper.Param("@DomainId", domainId));
        }

        public static int Update(int subjectId, string subjectName, string subjectCode, int domainId, bool isActive)
        {
            return SqlHelper.ExecuteNonQuery("sp_Subject_Update",
                SqlHelper.Param("@SubjectId", subjectId),
                SqlHelper.Param("@SubjectName", subjectName),
                SqlHelper.Param("@SubjectCode", subjectCode),
                SqlHelper.Param("@DomainId", domainId),
                SqlHelper.Param("@IsActive", isActive));
        }

        public static int Delete(int subjectId)
        {
            return SqlHelper.ExecuteNonQuery("sp_Subject_Delete",
                SqlHelper.Param("@SubjectId", subjectId));
        }
    }
}
