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

		public bool Add(TEntity model)
		{
			try
			{
				_dbContext.Add<TEntity>(model);

				return true;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void Delete(TEntity entity)
		{
			try
			{
				_dbContext.Remove<TEntity>(entity);

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void DeleteAll(Expression<Func<TEntity, bool>> filter = null)
		{
			try
			{
				if (filter == null)
				{
					_dbContext.Set<TEntity>().RemoveRange(_dbContext.Set<TEntity>());
				}
				else
				{
					//filtre verilmişse
					var entities = _dbContext.Set<TEntity>().Where(filter).ToList();

					_dbContext.Set<TEntity>().RemoveRange(entities);
				}

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
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
			return _dbContext.SaveChanges();
		}

		public void Update(TEntity model)
		{
			_dbContext.Entry(model).State = EntityState.Modified;
		}

		public void Update(TEntity model, params Expression<Func<TEntity, object>>[] updatedProperties)
		{

			var dbEntity = _dbContext.Set<TEntity>().Find(model);
			if (dbEntity == null)
			{
				throw new Exception("Entity not found");
			}
			var entry = _dbContext.Entry(dbEntity);

			foreach (var property in updatedProperties)
			{
				entry.Property(property).IsModified = true;
			}
		}
	}
}
