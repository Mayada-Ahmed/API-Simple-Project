using System.Collections.Generic;

namespace API_Project.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
