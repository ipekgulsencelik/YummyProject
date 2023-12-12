using Yummy.EntityLayer.Concrete;

namespace Yummy.DataAccessLayer.Abstract
{
	public interface ICategoryDAL : IGenericDAL<Category>
	{
		void ChangeCategoryStatus(int id);
		List<Category> GetActiveCategories();
	}
}
