using Product.Management.Model.Command;

namespace Product.Management.Interface
{
    public interface IProductManagementRepo
    {
        InsertObjectModel AddProduct(InsertObjectModel model);
        bool Delete(string id);
        InsertObjectModel Update(InsertObjectModel updatedModel, string id);
    }
}