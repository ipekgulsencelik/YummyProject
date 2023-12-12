using Yummy.EntityLayer.Concrete;

namespace Yummy.BusinessLayer.Abstract
{
	public interface ICategoryService : IGenericService<Category>
	{
		void TChangeCategoryStatus(int id);
		List<Category> TGetActiveCategories();
	}
}