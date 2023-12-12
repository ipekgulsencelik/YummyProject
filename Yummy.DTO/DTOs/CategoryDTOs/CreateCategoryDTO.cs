namespace Yummy.DTO.DTOs.CategoryDTOs
{
	public class CreateCategoryDTO
	{
		public string CategoryName { get; set; }
		public string? CategoryDescription { get; set; }
		public bool CategoryStatus { get; set; }
	}
}