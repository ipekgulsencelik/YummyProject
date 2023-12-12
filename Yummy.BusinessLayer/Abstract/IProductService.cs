using Yummy.EntityLayer.Concrete;

namespace Yummy.BusinessLayer.Abstract
{
	public interface IProductService : IGenericService<Product>
	{
		void TChangeProductStatus(int id);
		List<Product> TGetProductsByCategoryID(int id);
		List<Product> TGetProductsWithCategories();
	}
}