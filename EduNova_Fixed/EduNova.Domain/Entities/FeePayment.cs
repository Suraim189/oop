using System;
using EduNova.Domain.Enums;

namespace EduNova.Domain.Entities
{
    public class FeePayment
    {
        public int PaymentId { get; set; }
        public int VoucherId { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime PaidOn { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int ReceivedBy { get; set; }
    }
}