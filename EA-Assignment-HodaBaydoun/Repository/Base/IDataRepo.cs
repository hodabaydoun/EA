using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Repository.Base
{
 public interface IDataRepo
{

}

public interface IDataRepo<T> : IDataRepo
   where T : class
{
    Task<List<T>> GetListAsync();
}
}
