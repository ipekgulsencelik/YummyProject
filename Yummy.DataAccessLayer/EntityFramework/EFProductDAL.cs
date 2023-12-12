using Microsoft.EntityFrameworkCore;
using Yummy.DataAccessLayer.Abstract;
using Yummy.DataAccessLayer.Concrete;
using Yummy.DataAccessLayer.Repository;
using Yummy.EntityLayer.Concrete;

namespace Yummy.DataAccessLayer.EntityFramework
{
	public class EFProductDAL : GenericRepository<Product>, IProductDAL
	{
		public EFProductDAL(YummyContext context) : base(context)
		{
		}

		public void ChangeProductStatus(int id)
		{
			throw new NotImplementedException();
		}

		public List<Product> GetProductsByCategoryID(int id)
		{
			var context = new YummyContext();
			var values = context.Products.Include(x => x.Category).Where(x => x.ProductStatus == true && x.CategoryID == id).ToList();
			return values;
		}

		public List<Product> GetProductsWithCategories()
		{
			var context = new YummyContext();
			var values = context.Products.Include(x => x.Category).Where(x => x.ProductStatus == true).ToList();
			return values;
		}
	}
}