namespace Yummy.DTO.DTOs.CategoryDTOs
{
	public class UpdateCategoryDTO
	{
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }
		public string? CategoryDescription { get; set; }
		public bool CategoryStatus { get; set; }
	}
}