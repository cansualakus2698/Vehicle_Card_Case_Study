using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VhCardBusiness.Abstract;
using VhCardDataAccess.Abstract.Repositories;
using VhCardDataAccess.Concrete.RepositoryBase;
using VhCardEntity.Concrete;

namespace VhCardBusiness.Concrete
{
    public class BaseManager<TEntity> : IBaseService<TEntity>
        where TEntity : class, new()
    {
        protected readonly IRepositoryBase<TEntity> repository;
        public BaseManager(VhCardCaseContext context)
        {
            repository = new RepositoryBase<TEntity>(context);
        }
        public void Add(TEntity entity)
        {
            repository.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            repository.Delete(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return repository.Get(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }
    }
}
