using Yummy.EntityLayer.Concrete;

namespace Yummy.DataAccessLayer.Abstract
{
	public interface IProductDAL : IGenericDAL<Product>
	{
		void ChangeProductStatus(int id);
		List<Product> GetProductsByCategoryID(int id);
		List<Product> GetProductsWithCategories();
	}
}