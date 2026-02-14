using Microsoft.AspNetCore.Mvc;
using Lesson14_Intro.Models.DTOS;
using Lesson14_Intro.Repositories.Abstracts;
using Lesson14_Intro.Models.Entities.Concretes;

namespace Lesson14_Intro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }


    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var products = await _productRepository.GetAllAsync();

        if (products.Count == 0)
        {
            return NoContent();
        }
        return Ok(products);
    }

    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);

        return Ok(product);
    }

    [HttpDelete("Delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);

        if (product != null)
        {
            await _productRepository.DeleteAsync(product);
            await _productRepository.SaveChangeAsync();
            return Ok();
        }

        return BadRequest();
    }

    [HttpPost("AddProduct")]
    public async Task<IActionResult> AddProduct([FromBody] AddProductDto addProduct)
    {
        var newProduct = new Product()
        {
            Name = addProduct.Name,
            Description = addProduct.Description,
            Stock = addProduct.Stock,
            Price = addProduct.Price,
        };

        await _productRepository.AddAsync(newProduct);
        await _productRepository.SaveChangeAsync();
        return Ok();
    }


}
