using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BasicMvcApp.Models
{
    public class Supplier : Entity
    {
        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(100, ErrorMessage = "The {0} field have between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(14, ErrorMessage = "The {0} field have between {2} and {1} characters", MinimumLength = 11)]
        public string Document { get; set; }

        public SupplierType SupplierType { get; set; }

        public Address Address { get; set; }

        [DisplayName("Active?")]
        public bool Active { get; set; }

        // Entity Framework Relation
        public IEnumerable<Product> Products { get; set; }
    }
}
