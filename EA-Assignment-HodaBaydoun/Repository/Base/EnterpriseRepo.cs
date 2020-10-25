using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Repository.Base
{
    public class EnterpriseRepo : IEnterpriseRepo
    {
        public void SetTransaction(IDbTransaction transaction)
        {
            throw new System.NotImplementedException();
        }
    }

    public abstract class EnterpriseRepo<T> : IEnterpriseRepo<T> where T : class
    {
        private string connStr;
        public IDbTransaction transaction;


        public EnterpriseRepo(IConfiguration configuration)
        {
            this.connStr = configuration.GetConnectionString("DataConnection");
        }

        public abstract Task<List<T>> GetListAsync();

        public abstract Task<T> GetSingleAsync(long id);


        //public IDbConnection GetEnterpriseConnection()
        //{
        //    return new SqlConnection(this.enterpriseConnectionString);
        //}
        public IDbConnection GetEnterpriseConnection()
        {
            return transaction.Connection;
        }

        public DapperUtils GetDapper()
        {
            return new DapperUtils(connStr);
        }

        public abstract Task InsertAsync(T entity);

        public abstract Task<long> DeleteAsync(long entityId);


    public void SetTransaction(IDbTransaction transaction)
    {
        this.transaction = transaction;
    }
}
}
