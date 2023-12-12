using Yummy.BusinessLayer.Abstract;
using Yummy.DataAccessLayer.Abstract;
using Yummy.EntityLayer.Concrete;

namespace Yummy.BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDAL _categoryDAL;

		public CategoryManager(ICategoryDAL categoryDAL)
		{
			_categoryDAL = categoryDAL;
		}

		public void TChangeCategoryStatus(int id)
		{
			_categoryDAL.ChangeCategoryStatus(id);
		}

		public void TDelete(Category entity)
		{
			_categoryDAL.Delete(entity);
		}

		public List<Category> TGetActiveCategories()
		{
			return _categoryDAL.GetActiveCategories();
		}

		public Category TGetByID(int id)
		{
			return _categoryDAL.GetByID(id);
		}

		public List<Category> TGetListAll()
		{
			return _categoryDAL.GetListAll();
		}

		public void TInsert(Category entity)
		{
			_categoryDAL.Insert(entity);
		}

		public void TUpdate(Category entity)
		{
			_categoryDAL.Update(entity);
		}
	}
}