namespace Infrastructure.DBFactory
{
    #region Usings
    using Data.Context;
    using Infrastructure.Interfaces;
    #endregion

   public class DBFactory : Disposable,IDbFactory
    {
        DataContext DBContext;

        public DataContext Init()
        {
            return DBContext ?? (DBContext = new DataContext());
        }

        protected override void DisposeCore()
        {
           if(DBContext != null)
            {
                DBContext.Dispose();
            }
        }
    }
}
