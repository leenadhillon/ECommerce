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
    public class ProductAttributeController : ControllerBase
    {
        [HttpPost]
        [Route("getallproductattribute")]
        public async Task<IActionResult> GetAllProductAttribute(GetProductAttributeRequest getProductAttributeRequest)
        {
            using (ProductAttributeRepository repository = new ProductAttributeRepository())
            {
                return CommonResponse.CommonAPIResponse(await repository.GetAllProductAttribute(getProductAttributeRequest));
            }
        }
    }
}