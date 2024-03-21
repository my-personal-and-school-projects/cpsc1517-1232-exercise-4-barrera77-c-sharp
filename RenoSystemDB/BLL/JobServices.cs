using RenoSystemDB.DAL;
using RenoSystemDB.Entities;


namespace RenoSystemDB.BLL
{
   public class JobServices
    {
        private readonly RenosContext _context;
        
        internal JobServices(RenosContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create a list of jobs to pas sto the select component
        /// </summary>
        /// <returns></returns>
        public List<Job> GetAllJobs()
        {
            return _context.Jobs.ToList<Job>();
        }       
    
    }
}
    
