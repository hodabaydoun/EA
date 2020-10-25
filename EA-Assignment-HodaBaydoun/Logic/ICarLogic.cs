using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA-Assignment-HodaBaydoun.Logic
{
    interface ICarLogic
{
    IEnumerable<CarObj> GetAll(int start, int end, string lang = "en");
}
}
