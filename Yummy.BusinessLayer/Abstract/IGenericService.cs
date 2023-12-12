﻿namespace Yummy.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void TInsert(T entity);
		void TUpdate(T entity);
		void TDelete(T entity);
		List<T> TGetListAll();
		T TGetByID(int id);
	}
}