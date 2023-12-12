using Microsoft.AspNetCore.Mvc;
using Yummy.BusinessLayer.Abstract;
using Yummy.DTO.DTOs.ProductDTOs;
using Yummy.EntityLayer.Concrete;

namespace Yummy.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public IActionResult ProductList()
		{
			var values = _productService.TGetListAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateProduct(CreateProductDTO createProductDTO)
		{
			Product product = new Product()
			{
				ProductName = createProductDTO.ProductName,
				ProductDescription = createProductDTO.ProductDescription,
				ProductImageURL = createProductDTO.ProductImageURL,
				ProductPrice = createProductDTO.ProductPrice,
				CategoryID = createProductDTO.CategoryID,
				ProductStatus = createProductDTO.ProductStatus
			};
			_productService.TInsert(product);
			return Ok("Ürün Başarılı Bir Şekilde Eklendi");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteProduct(int id)
		{
			var values = _productService.TGetByID(id);
			_productService.TDelete(values);
			return Ok("Ürün Başarılı Bir Şekilde Silindi");
		}

		[HttpGet("{id}")]
		public IActionResult GetProduct(int id)
		{
			var values = _productService.TGetByID(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateProduct(UpdateProductDTO updateProductDTO)
		{
			Product product = new Product()
			{
				ProductName = updateProductDTO.ProductName,
				ProductDescription = updateProductDTO.ProductDescription,
				ProductImageURL = updateProductDTO.ProductImageURL,
				ProductPrice = updateProductDTO.ProductPrice,
				CategoryID = updateProductDTO.CategoryID,
				ProductStatus = updateProductDTO.ProductStatus,
				ProductID = updateProductDTO.ProductID
			};
			_productService.TUpdate(product);
			return Ok("Ürün Başarılı Bir Şekilde Güncellendi");
		}

		[HttpGet("GetProductsWithCategories")]
		public IActionResult GetProductsWithCategories()
		{
			var values = _productService.TGetProductsWithCategories();
			return Ok(values);
		}

		[HttpGet("GetProductsByCategoryID/{id}")]
		public IActionResult GetProductsByCategoryID(int id)
		{
			var values = _productService.TGetProductsByCategoryID(id);
			return Ok(values);
		}

		[HttpGet("ChangeProductStatus/{id}")]
		public IActionResult ChangeProductStatus(int id)
		{
			_productService.TChangeProductStatus(id);
			return Ok("Ürün Durum Değeri Değiştirildi");
		}
	}
}