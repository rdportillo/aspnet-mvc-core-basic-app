using System.ComponentModel.DataAnnotations;

namespace BasicMvcApp.Models
{
    public class Address : Entity
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(200, ErrorMessage = "The {0} field have between {2} and {1} characters", MinimumLength = 2)]
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(8, ErrorMessage = "The {0} field must have {1} characters", MinimumLength = 8)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(100, ErrorMessage = "The {0} field have between {2} and {1} characters", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(50, ErrorMessage = "The {0} field have between {2} and {1} characters", MinimumLength = 2)]
        public string Province { get; set; }

        // Entity Framework Relation
        public Supplier Supplier { get; set; }
    }
}
