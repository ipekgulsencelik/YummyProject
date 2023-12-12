using Yummy.DataAccessLayer.Abstract;
using Yummy.DataAccessLayer.Concrete;
using Yummy.DataAccessLayer.Repository;
using Yummy.EntityLayer.Concrete;

namespace Yummy.DataAccessLayer.EntityFramework
{
	public class EFCategoryDAL : GenericRepository<Category>, ICategoryDAL
	{
		public EFCategoryDAL(YummyContext context) : base(context)
		{
		}

		public void ChangeCategoryStatus(int id)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetActiveCategories()
		{
			throw new NotImplementedException();
		}
	}
}
