using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace UUJ.GuidersHub.EntityFramework.Repositories
{
    public abstract class GuidersHubRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<GuidersHubDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected GuidersHubRepositoryBase(IDbContextProvider<GuidersHubDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class GuidersHubRepositoryBase<TEntity> : GuidersHubRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected GuidersHubRepositoryBase(IDbContextProvider<GuidersHubDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
