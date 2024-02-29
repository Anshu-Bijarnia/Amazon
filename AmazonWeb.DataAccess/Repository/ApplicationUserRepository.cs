using Amazon.DataAccess.Data;
using Amazon.DataAccess.Repository.IRepository;
using Amazon.Models;
using Amazon.Utility;

namespace Amazon.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
