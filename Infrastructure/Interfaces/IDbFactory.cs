namespace Infrastructure.Interfaces
{
    #region Usings
    using Data.Context;
    using System;
    #endregion

    public interface IDbFactory : IDisposable
    {
        DataContext Init();
    }
}
