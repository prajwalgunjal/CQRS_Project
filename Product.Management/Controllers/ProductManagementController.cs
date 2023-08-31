using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Management.Interface;
using Product.Management.Model;
using Product.Management.Model.Command;

namespace Product.Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductManagementController : ControllerBase
    {
        private readonly IProductManagementRepo productManagementRepo;
        public ProductManagementController(IProductManagementRepo productManagementRepo)
        {
            this.productManagementRepo = productManagementRepo;
        }

        [HttpPost("addProduct")]
        public IActionResult AddProduct(InsertObjectModel addProduct)
        {
            InsertObjectModel product = productManagementRepo.AddProduct(addProduct);
            if (product != null)
            {
                return Ok(new ResponseModel<InsertObjectModel> { isSucess = true, Message = "successfully added product", Data = product });
            }
            return BadRequest(new ResponseModel<string> { isSucess = false, Message = "unable to add product" });
        }

        [HttpPut("updateProduct")]
        public IActionResult UpdateProduct(InsertObjectModel updateProduct, string productID)
        {
            InsertObjectModel product = productManagementRepo.Update(updateProduct, productID);
            if (product != null)
            {
                return Ok(new ResponseModel<InsertObjectModel> { isSucess = true, Message = "successfully update product", Data = product });
            }
            return BadRequest(new ResponseModel<string> { isSucess = false, Message = "unable to update product" });
        }

        [HttpDelete("deleteProduct")]
        public IActionResult DeleteProduct(string productID)
        {
            bool result = productManagementRepo.Delete(productID);
            if (result != null)
            {
                return Ok(new ResponseModel<string> { isSucess = true, Message = "successfully deleted product" });
            }
            return BadRequest(new ResponseModel<string> { isSucess = false, Message = "unable to delete product" });
        }

    }
}
