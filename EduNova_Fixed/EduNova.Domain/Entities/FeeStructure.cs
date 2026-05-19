namespace EduNova.Domain.Entities
{
    public class FeeStructure
    {
        public int FeeStructureId { get; set; }
        public int ClassSectionId { get; set; }
        public string ClassSectionName { get; set; }
        public decimal MonthlyFee { get; set; }
        public decimal AdmissionFee { get; set; }
        public decimal MiscFee { get; set; }
    }
}