using ERMTest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERMTest.Interfaces
{
   public interface IDataPKRep
    {
        IQueryable<DataPK> GetAllPK();
    }
}
