using EA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface ICarsRepo : IEnterpriseRepo
{
    IEnumerable<CarsModel> GetAll(int start, int end);
}