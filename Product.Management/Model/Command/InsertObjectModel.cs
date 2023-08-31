using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Management.Model.Command
{
    public class InsertObjectModel
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string productId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string productName { get; set; }
        [Required]
        [Range(1, 100)]
        public int Qty { get; set; }
        [Required]
        [Range(10, 10000)]
        public float Price { get; set; }
    }
}
