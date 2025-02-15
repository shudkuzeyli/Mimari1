using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mimari1.Core.DataAccess.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class, new()
		where TContext : DbContext, new()
	{

		private readonly TContext _dbContext;
		public EfEntityRepositoryBase(TContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Add(TEntity model)
		{
			throw new NotImplementedException();
		}

		public void Delete(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public void DeleteAll(Expression<Func<TEntity, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public TEntity GetById(int id)
		{
			try
			{
				return _dbContext.Set<TEntity>().Find(id);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> order = null, string includeProperties = "")
		{
			throw new NotImplementedException();
		}

		public int Save()
		{
			throw new NotImplementedException();
		}

		public void Update(TEntity model)
		{
			throw new NotImplementedException();
		}
	}
}
