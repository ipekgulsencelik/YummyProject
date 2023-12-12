using Yummy.DataAccessLayer.Abstract;
using Yummy.DataAccessLayer.Concrete;

namespace Yummy.DataAccessLayer.Repository
{
	public class GenericRepository<T> : IGenericDAL<T> where T : class
	{
		private readonly YummyContext _context;

		public GenericRepository(YummyContext context)
		{
			_context = context;
		}

		public void Delete(T entity)
		{
			_context.Set<T>().Remove(entity);
			_context.SaveChanges();
		}

		public T GetByID(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public List<T> GetListAll()
		{
			return _context.Set<T>().ToList();
		}

		public void Insert(T entity)
		{
			_context.Set<T>().Add(entity);
			_context.SaveChanges();
		}

		public void Update(T entity)
		{
			_context.Set<T>().Update(entity);
			_context.SaveChanges();
		}
	}
}
