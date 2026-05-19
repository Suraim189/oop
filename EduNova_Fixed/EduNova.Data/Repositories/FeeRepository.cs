using System;
using System.Data;

namespace EduNova.Data.Repositories
{
    public class FeeRepository
    {
        public static DataTable GetFeeStructures()
        {
            return SqlHelper.ExecuteDataTable("sp_GetFeeStructures");
        }

        public static int SaveFeeStructure(int classSectionId, decimal monthlyFee, decimal admissionFee, decimal miscFee)
        {
            return SqlHelper.ExecuteNonQuery("sp_SaveFeeStructure",
                SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@MonthlyFee", monthlyFee),
                SqlHelper.Param("@AdmissionFee", admissionFee),
                SqlHelper.Param("@MiscFee", miscFee));
        }

        public static int GenerateVouchers(int classSectionId, string month, int year, DateTime dueDate)
        {
            return SqlHelper.ExecuteNonQuery("sp_GenerateFeeVouchers",
            SqlHelper.Param("@ClassSectionId", classSectionId),
                SqlHelper.Param("@Month", month),
            SqlHelper.Param("@Year", year),
            SqlHelper.Param("@DueDate", dueDate));
        }

        public static DataTable GetVouchers()
        {
            return SqlHelper.ExecuteDataTable("sp_GetVouchers");
        }

        public static DataTable SearchStudentVouchers(string keyword)
        {
            return SqlHelper.ExecuteDataTable("sp_SearchStudentVouchers",
                SqlHelper.Param("@Keyword", keyword));
        }

        public static int PayVoucher(int voucherId, decimal paidAmount, int paymentMethod, int receivedBy)
        {
            return SqlHelper.ExecuteNonQuery("sp_PayFeeVoucher",
                SqlHelper.Param("@VoucherId", voucherId),
                SqlHelper.Param("@PaidAmount", paidAmount),
                SqlHelper.Param("@PaymentMethod", paymentMethod),
                SqlHelper.Param("@ReceivedBy", receivedBy));
        }

        public static DataTable GetFeeDueStudents(int? classSectionId)
        {
            return SqlHelper.ExecuteDataTable("sp_GetFeeDueStudents",
                SqlHelper.Param("@ClassSectionId", (object)classSectionId ?? DBNull.Value));
        }
    }
}
