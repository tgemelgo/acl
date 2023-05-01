using System.ComponentModel.DataAnnotations;

namespace ACT.ViewModel
{
    public class VM_Launch
    {
        public Guid? Id { get; set; }

        [Required]
        public int Supplier { get; set; }

        [Required]
        public DateTime DateLaunch { get; set; }

        [Required]
        public decimal ValueLauch { get; set; }


        public DateTime? PayDate { get; set; }
        public decimal? ValuePay { get; set; }
    }
}
