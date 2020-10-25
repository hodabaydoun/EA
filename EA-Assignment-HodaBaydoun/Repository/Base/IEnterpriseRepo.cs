using System;
using System.Data;

namespace EA-Assignment-HodaBaydoun.Repository.Base
{
     public interface IEnterpriseRepo : IDataRepo
{
    void SetTransaction(IDbTransaction transaction);
}

public interface IEnterpriseRepo<T> : IDataRepo<T> where T : class
{
    IDbConnection GetEnterpriseConnection();
}
}
