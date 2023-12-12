using System.Text.Json.Serialization;

namespace Yummy.EntityLayer.Concrete
{
	public class Product
	{
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImageURL { get; set; }
        public decimal ProductPrice { get; set; }

        public int CategoryID { get; set; }
		[JsonIgnore]
		public Category Category { get; set; }

        public bool ProductStatus { get; set; }
    }
}
