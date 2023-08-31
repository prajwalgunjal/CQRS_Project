using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Product.Management.Model.Query
{
    public class GetProductModel
    {
        public string productId { get; set; }

        public string productName { get; set; }
        public int Qty { get; set; }
        public float Price { get; set; }
    }
}
