using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Management.Interface;
using Product.Management.Model;
using Product.Management.Model.Query;

namespace Product.Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetProductController : ControllerBase
    {
        private readonly IGetProductRepo getProductRepo;
        public GetProductController(IGetProductRepo getProductRepo)
        {
            this.getProductRepo = getProductRepo;
        }
        [HttpGet("getProductById")]
        public IActionResult GetProductByID(string id)
        {
            GetProductModel products = getProductRepo.GetProductById(id);
            if (products != null)
            {
                return Ok(new ResponseModel<GetProductModel> { isSucess = true, Message = "successfully get product", Data = products });
            }
            return BadRequest(new ResponseModel<string> { isSucess = false, Message = "unable to get product" });
        }

        [HttpGet("getAllProduct")]
        public IActionResult GetAllProducts()
        {
            IEnumerable<GetProductModel> products = getProductRepo.GetAllProducts();
            if (products != null)
            {
                return Ok(new ResponseModel<List<GetProductModel>> { isSucess = true, Message = "successfully get all products", Data = products.ToList() });
            }
            return BadRequest(new ResponseModel<string> { isSucess = false, Message = "unable to get all products" });
        }

    }
}
