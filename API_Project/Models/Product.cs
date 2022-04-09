using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name of product is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
