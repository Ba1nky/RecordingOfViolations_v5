using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordingOfViolations.Models
{
    public class Violation
    {
        public int ViolationId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "AddressRequired")]
        [Display(Name = "Address", ResourceType = typeof(Resources.SharedResource))]
        public string Address { get; set; } = null!;

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "PolicemanRequired")]
        [Display(Name = "Policeman", ResourceType = typeof(Resources.SharedResource))]
        public string Policeman { get; set; } = null!;

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "OffenderRequired")]
        [Display(Name = "Offender", ResourceType = typeof(Resources.SharedResource))]
        public string Offender { get; set; } = null!;

        [Required(ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "PriceRequired")]
        [Display(Name = "Price", ResourceType = typeof(Resources.SharedResource))]
        [Range(0.01, double.MaxValue, ErrorMessageResourceType = typeof(Resources.SharedResource),
            ErrorMessageResourceName = "PriceLessThanZero")]
        public decimal? Price { get; set; }

        [Display(Name = "Date", ResourceType = typeof(Resources.SharedResource))]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; } = DateTime.Now;

        public int? ReasonId { get; set; }
        public Reason? Reason { get; set; }

        public List<PaymentСheck> PaymentСhecks { get; set; } = new List<PaymentСheck>();
    }
}
