using Microsoft.EntityFrameworkCore;
using RenoSystemDB.DAL;
using RenoSystemDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenoSystemDB.BLL
{
    public class SupplyServices
    {
        private readonly RenosContext _context;

        internal SupplyServices(RenosContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Reate a list of supplies
        /// </summary>
        /// <returns>a list of supplies filtered by Job</returns>
        public List<Supply> GetSuppliesByJobId(int id)
        {
            return _context.Supplies
                .Where(s => s.JobId == id)                
                .ToList<Supply>();
        }       
    }
}
