using Mimari1.Business.Abstract.Services;
using Mimari1.Dal.Context;
using Mimari1.Entities.Concrete.LibraryClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mimari1.Business.Services
{
	public class BolumService : IBolumService
	{
		private readonly DataContext _dataContext;
		public void Add(Bolum model)
		{
			throw new NotImplementedException();
		}

		public void Delete(Bolum entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteAll(Expression<Func<Bolum, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public Bolum GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Bolum> GetList(Expression<Func<Bolum, bool>> filter = null, Func<IQueryable<Bolum>, IOrderedQueryable<Bolum>> order = null, string includeProperties = "")
		{
			throw new NotImplementedException();
		}

		public int Save()
		{
			throw new NotImplementedException();
		}

		public void Update(Bolum model)
		{
			throw new NotImplementedException();
		}
	}
}
