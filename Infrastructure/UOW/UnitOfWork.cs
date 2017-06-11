namespace Infrastructure.UOW
{
    #region Usings
    using Data.Context;
    using Infrastructure.Interfaces;
    #endregion

    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private DataContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public DataContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
