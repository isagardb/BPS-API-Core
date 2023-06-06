using Common.Products;
using Microsoft.AspNetCore.Mvc;
using Services.Contract;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<ProductModel> products = await _productServices.Get();
                return Ok(new ProductResponseBody
                {
                    statusCode = 200,
                    message = "Success",
                    products = products
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ProductResponseBody
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            try
            {
                ProductModel product = await _productServices.GetById(id);
                if(product == null)
                {
                    return NotFound(new ProductResponseBody
                    {
                        statusCode = 400,
                        message = "Not Found"
                    });
                } else
                {
                    return Ok(new ProductResponseBody
                    {
                        statusCode = 200,
                        message = "Success",
                        product = product
                    });
                }
            }
            catch(Exception ex)
            {
                return BadRequest(new ProductResponseBody {
                    statusCode = 500,
                    message = ex.Message    
                });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddNew(ProductModel product)
        {
            try
            {
                await _productServices.Create(product);
                return Ok(new ProductResponseBody
                {
                    statusCode = 200,
                    message = "Success",
                    product = product
                });
            }
            catch(Exception ex)
            {
                return BadRequest(new ProductResponseBody
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }

        [HttpPatch]
        public async Task<IActionResult> Update(ProductModel product)
        {
            try
            {
                int newProduct = await _productServices.Update(product); 

                if(newProduct == 0)
                {
                    return NotFound(new ProductResponseBody
                    {
                        statusCode = 400,
                        message = "Not Found"
                    });
                } else
                {
                    return Ok(new ProductResponseBody
                    {
                        statusCode = 200,
                        message = "Success",
                        product = product
                    });
                }
            }
            catch(Exception ex)
            {
                return BadRequest(new ProductResponseBody
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                int deleteStatus = await _productServices.Delete(id);
                if(deleteStatus == 0)
                {
                    return NotFound(new ProductResponseBody { statusCode = 400, message = "Not Found" });
                }
                else
                {
                    return Ok(new ProductResponseBody { statusCode = 200, message = "Success" });
                }
            }
            catch(Exception ex)
            {
                return BadRequest(new ProductResponseBody
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }
    }
}
