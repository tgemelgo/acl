namespace ACT.Model
{
    public class Launch
    {
        public Guid? Id { get; set; }
        public int Supplier { get; set; }
        public DateTime DateLaunch { get; set; }
        public decimal ValueLauch { get; set; }
        public DateTime? PayDate { get; set; }
        public decimal? ValuePay { get; set; }
    }
}
