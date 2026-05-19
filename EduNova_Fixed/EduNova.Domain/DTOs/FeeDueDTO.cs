namespace EduNova.Domain.DTOs
{
    public class FeeDueDTO
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string AdmissionNo { get; set; }
        public string ClassSection { get; set; }
        public int VouchersDue { get; set; }
        public decimal TotalDueAmount { get; set; }
    }
}