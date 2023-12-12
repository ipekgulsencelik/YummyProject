using Yummy.BusinessLayer.Abstract;
using Yummy.DataAccessLayer.Abstract;
using Yummy.EntityLayer.Concrete;

namespace Yummy.BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDAL _productDAL;

		public ProductManager(IProductDAL productDAL)
		{
			_productDAL = productDAL;
		}

		public void TChangeProductStatus(int id)
		{
			_productDAL.ChangeProductStatus(id);
		}

		public void TDelete(Product entity)
		{
			_productDAL?.Delete(entity);
		}

		public Product TGetByID(int id)
		{
			return _productDAL.GetByID(id);
		}

		public List<Product> TGetListAll()
		{
			return _productDAL.GetListAll();
		}

		public List<Product> TGetProductsByCategoryID(int id)
		{
			return _productDAL.GetProductsByCategoryID(id);
		}

		public List<Product> TGetProductsWithCategories()
		{
			return _productDAL.GetProductsWithCategories();
		}

		public void TInsert(Product entity)
		{
			_productDAL.Insert(entity);
		}

		public void TUpdate(Product entity)
		{
			_productDAL.Update(entity);
		}
	}
}
