using Product.Management.Model.Query;

namespace Product.Management.Interface
{
    public interface IGetProductRepo
    {
        List<GetProductModel> GetAllProducts();
        GetProductModel GetProductById(string productID);
    }
}