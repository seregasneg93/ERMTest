using ERMTest.Data;
using ERMTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERMTest.Models
{
    public class DataPKRep : IDataPKRep
    {
        private readonly AppDbContext _context;

        public DataPKRep(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<DataPK> GetAllPK()
        {
            return _context.DataPK;
        }
    }
}
