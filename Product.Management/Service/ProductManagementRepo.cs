using Microsoft.EntityFrameworkCore;
using Product.Management.Context;
using Product.Management.Interface;
using Product.Management.Model.Command;
using Product.Management.Model.Query;

namespace Product.Management.Service
{
    public class ProductManagementRepo : IProductManagementRepo
    {
        private readonly DbContext__ dbContext__;
        public ProductManagementRepo(DbContext__ dbContext__)
        {
            this.dbContext__ = dbContext__;
        }

        public InsertObjectModel AddProduct(InsertObjectModel model)
        {
            bool isproduct = dbContext__.Product.Any(x => x.productId == model.productId);
            if (!isproduct)
            {
                dbContext__.Add(model);
                dbContext__.SaveChanges();
                return model;
            }
            return null;
        }


        public bool Delete(string id)
        {
            InsertObjectModel result = dbContext__.Product.FirstOrDefault(x => x.productId == id);
            if (result != null)
            {
                dbContext__.Remove(result);
                dbContext__.SaveChanges();
                return true;
            }
            return false;
        }

        public InsertObjectModel Update(InsertObjectModel updatedModel, string id)
        {
            InsertObjectModel result = dbContext__.Product.FirstOrDefault(x => x.productId == id);
            if (result != null)
            {
                result.productName = updatedModel.productName;
                result.Price = updatedModel.Price;
                result.Qty = updatedModel.Qty;
                dbContext__.SaveChanges();
                return updatedModel;
            }
            return null;
        }


    }
}
