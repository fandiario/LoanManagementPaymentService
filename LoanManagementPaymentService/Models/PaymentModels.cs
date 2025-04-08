namespace LoanManagementPaymentService.Models
{
    public class PaymentModels
    {
        public int Id { get; set; }
        public int IdLoan { get; set; }
        public int TotalPayment { get; set; }
        //Jumlah pembayaran cicilan (12 x cicil, 10 x cicil, 5x cicil)
        public int InstallmentAmount { get; set; }
        //Jumlah cicilan dalam Rp
        public int InstallmentPayment { get; set; }
        public int NextInstallmentPayment { get; set; }
        public int RemainingPayment { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public int LastUpdatedBy { get; set; }
    }
}
