using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Repository.Dapper
{
 public class DapperUtils
{
    private string enterpriseConnectionString;
    private IDbTransaction _transaction;

    public DapperUtils(string enterpriseConnectionString)
    {
        this.enterpriseConnectionString = enterpriseConnectionString;
    }

    public IDbConnection GetConnection()
    {
        return new SqlConnection(enterpriseConnectionString);
    }

    public List<T> GetList<T>(string query, object param = null) where T : class
    {
        try
        {
            using (IDbConnection conn = GetConnection())
            {
                var enumerable = conn.Query<T>(query, param, commandTimeout: 300, commandType: CommandType.StoredProcedure);
                return enumerable.ToList();
            }
        }
        catch
        {
            throw;
        }
    }
}
}
