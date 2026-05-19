using System.Collections.Generic;

namespace EduNova.Domain.DTOs
{
    public class SubstitutionResult
    {
        public int TotalSlots { get; set; }
        public int AssignedSlots { get; set; }
        public int UnassignedSlots { get; set; }
        public List<SubstitutionDetailDTO> Details { get; set; }
    }
}