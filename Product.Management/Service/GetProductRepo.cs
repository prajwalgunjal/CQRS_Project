using Microsoft.EntityFrameworkCore;
using Product.Management.Context;
using Product.Management.Interface;
using Product.Management.Model.Query;

namespace Product.Management.Service
{
    public class GetProductRepo : IGetProductRepo
    {
        private readonly DbContext__ dbContext__;
        public GetProductRepo(DbContext__ dbContext__)
        {
            this.dbContext__ = dbContext__;
        }
        public List<GetProductModel> GetAllProducts()
        {
            List<GetProductModel> products = dbContext__.Product.Select(x => new GetProductModel { productId = x.productId, productName = x.productName, Price = x.Price, Qty = x.Qty }).ToList();

            if (products != null)
            {
                return products;
            }

            return null;
        }

        public GetProductModel GetProductById(string productID)
        {
            GetProductModel product = dbContext__.Product.Select(x => new GetProductModel { productId = x.productId, productName = x.productName, Price = x.Price, Qty = x.Qty }).FirstOrDefault(x => x.productId == productID);
            if (product != null)
            {
                return product;
            }
            return null;
        }

    }
}
