using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mimari1.Business.Abstract
{
    public interface IGenericService<T> where T : class, new()
	{
		//T nesnesi ile yapılabilecek fonksiyonları buraya yazacağız.
		IEnumerable<T> GetList(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> order = null, string includeProperties = "");

		T GetById(int id);

		void Add(T model);

		void Update(T model);

		void Delete(T entity);

		void DeleteAll(Expression<Func<T, bool>> filter = null);

		//bir kayıttan kaç satır etkilendiğini döndüren fonksiyon
		int Save();
	}
}

//web, mobil, api