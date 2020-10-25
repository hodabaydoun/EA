using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EA;
using Microsoft.Extensions.Configuration;

public class CarsRepo : EnterpriseRepo<CarsModel>, ICarsRepo
{
    public CarsRepo(IConfiguration configuration) : base(configuration)
    {
    }

    public override Task<long> DeleteAsync(long entityId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CarsModel> GetAll(int start, int end)
    {
        return GetDapper().GetList<CarsModel>(ProcedureConstants.GET_CARS, new { @start = start, @end = end });
    }

    public override Task<List<CarsModel>> GetListAsync()
    {
        throw new NotImplementedException();
    }

    public override Task<CarsModel> GetSingleAsync(long id)
    {
        throw new NotImplementedException();
    }

    public override Task InsertAsync(CarsModel entity)
    {
        throw new NotImplementedException();
    }
}
