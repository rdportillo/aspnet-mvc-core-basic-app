using System.ComponentModel.DataAnnotations;

namespace BasicMvcApp.Models
{
    public class Product : Entity
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(200, ErrorMessage = "The {0} field have between {2} and {1} characters", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(1000, ErrorMessage = "The {0} field have between {2} and {1} characters", MinimumLength = 2)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        [StringLength(200, ErrorMessage = "The {0} field have between {2} and {1} characters", MinimumLength = 2)]
        public string Image { get; set; }

        [Required(ErrorMessage = "The {0} field is required")]
        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Active { get; set; }

        // Entity Framework Relation
        public Supplier Supplier { get; set; }
    }
}
