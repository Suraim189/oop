using System;
using System.Data;
using EduNova.Data.Repositories;

namespace EduNova.Services
{
    public class FeeService
    {
        public DataTable GetFeeStructures() => FeeRepository.GetFeeStructures();
        public int SaveFeeStructure(int classSectionId, decimal monthlyFee, decimal admissionFee, decimal miscFee)
            => FeeRepository.SaveFeeStructure(classSectionId, monthlyFee, admissionFee, miscFee);
        public int GenerateVouchers(int? classSectionId, string month, int year, DateTime dueDate)
        {
            if (classSectionId.HasValue)
                return FeeRepository.GenerateVouchers(classSectionId.Value, month, year, dueDate);

            var all = ClassSectionRepository.GetAll();
            int total = 0;
            foreach (DataRow row in all.Rows)
            {
                if (row["ClassSectionId"] == DBNull.Value)
                    continue;
                int id = Convert.ToInt32(row["ClassSectionId"]);
                total += FeeRepository.GenerateVouchers(id, month, year, dueDate);
            }
            return total;
        }
        public DataTable GetVouchers() => FeeRepository.GetVouchers();
        public DataTable SearchStudentVouchers(string keyword) => FeeRepository.SearchStudentVouchers(keyword);
        public int PayVoucher(int voucherId, decimal paidAmount, int paymentMethod, int receivedBy)
            => FeeRepository.PayVoucher(voucherId, paidAmount, paymentMethod, receivedBy);
        public DataTable GetFeeDueStudents(int? classSectionId) => FeeRepository.GetFeeDueStudents(classSectionId);
    }
}
