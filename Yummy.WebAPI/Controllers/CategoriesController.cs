using Microsoft.AspNetCore.Mvc;
using Yummy.BusinessLayer.Abstract;
using Yummy.DTO.DTOs.CategoryDTOs;
using Yummy.EntityLayer.Concrete;

namespace Yummy.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryService _categoryService;

		public CategoriesController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet]
		public IActionResult CategoryList()
		{
			var values = _categoryService.TGetListAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCategory(CreateCategoryDTO createCategoryDTO)
		{
			Category category = new Category()
			{
				CategoryName = createCategoryDTO.CategoryName,
				CategoryDescription = createCategoryDTO.CategoryDescription,		
				CategoryStatus = createCategoryDTO.CategoryStatus
			};
			_categoryService.TInsert(category);
			return Ok("Kategori Başarılı Bir Şekilde Eklendi");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteCategory(int id)
		{
			var values = _categoryService.TGetByID(id);
			_categoryService.TDelete(values);
			return Ok("Kategori Başarılı Bir Şekilde Silindi");
		}

		[HttpGet("{id}")]
		public IActionResult GetCategory(int id)
		{
			var values = _categoryService.TGetByID(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
		{
			Category category = new Category()
			{
				CategoryName = updateCategoryDTO.CategoryName,
				CategoryDescription = updateCategoryDTO.CategoryDescription,
				CategoryStatus = updateCategoryDTO.CategoryStatus,
				CategoryID = updateCategoryDTO.CategoryID
			};
			_categoryService.TUpdate(category);
			return Ok("Kategori Başarılı Bir Şekilde Güncellendi");
		}

		[HttpGet("GetActiveCategories")]
		public IActionResult GetActiveCategories()
		{
			var values = _categoryService.TGetActiveCategories();
			return Ok(values);
		}

		[HttpGet("ChangeCategoryStatus/{id}")]
		public IActionResult ChangeCategoryStatus(int id)
		{
			_categoryService.TChangeCategoryStatus(id);
			return Ok("Kategori Durum Değeri Değiştirildi");
		}
	}
}