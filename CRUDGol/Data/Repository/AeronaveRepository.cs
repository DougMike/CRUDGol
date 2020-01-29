using CRUDGol.Data.Repository;
using CRUDGol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CRUDGol.Data
{
    public class AeronaveRepository : BaseRepository<Aeronave>, IAeronaveRepository
    {
        public AeronaveRepository(AeronaveContext _context) : base(_context)
        {

        }
    }
}
