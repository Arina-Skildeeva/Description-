namespace Description.Domain
{
    public class Bill
    {
        public int Bankdetail { get; set; }
        public int Client { get; set; }
        public int Paynumber { get; set; }
        public decimal Payamount { get; set; }
        public bool Paymentconfirmation { get; set; }
    }
}