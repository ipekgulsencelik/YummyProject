namespace Yummy.DTO.DTOs.ProductDTOs
{
	public class CreateProductDTO
	{
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public string ProductImageURL { get; set; }
		public decimal ProductPrice { get; set; }
		public int CategoryID { get; set; }
		public bool ProductStatus { get; set; }
	}
}