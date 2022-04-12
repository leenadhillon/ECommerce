using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceCommon;
using ECommerceWebAPI.Model;
using ECommerceWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        [Route("getallproducts")]
        public async Task<IActionResult> GetAllProducts(GetAllProductsRequest getAllProductsRequest)
        {
            using (ProductRepository repository = new ProductRepository())
            {
                return CommonResponse.CommonAPIResponse(await repository.GetAllProducts(getAllProductsRequest));
            }
        }

        [HttpPost]
        [Route("getproductbyid")]
        public async Task<IActionResult> GetProductByID(GetProductByID getProductByIDRequest)
        {
            using (ProductRepository repository = new ProductRepository())
            {
                return CommonResponse.CommonAPIResponse(await repository.GetProductByID(getProductByIDRequest));
            }
        }
        [HttpPost]
        [Route("deleteproduct")]
        public async Task<IActionResult> DeleteProduct(GetProductByID getProductByIDRequest)
        {
            using (ProductRepository repository = new ProductRepository())
            {
                await repository.DeleteProduct(getProductByIDRequest);
                return CommonResponse.CommonAPIResponse(true);
            }
        }

        [HttpPost]
        [Route("saveproduct")]
        public async Task<IActionResult> SaveProduct(ProductAPIModel saveProductRequest)
        {
            try
            {
                using (ProductRepository repository = new ProductRepository())
                {
                    return CommonResponse.CommonAPIResponse(await repository.SaveProduct(saveProductRequest));
                }
            }
            catch (System.Exception ex)
            {
                return CommonResponse.CommonAPIResponse(null, "Something went wrong.", Common.CustomCodes.InternalError);
            }
        }
    }
}