using System.ComponentModel.DataAnnotations;

namespace Product.Management.Entity
{
    public class ProductEntity
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string productId { get; set; }

        public string productName { get; set; }
        [Range(10,100)]
        public int Qty { get; set; }

        [Range (10,10000)]
        public float Price { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedOn { get; set; } 
    }
}
