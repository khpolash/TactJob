using Tactsoft.Core.Entities;
using Tactsoft.Service.DbDependencies;
using Tactsoft.Service.Services.Base;

namespace Tactsoft.Service.Services
{
    public class AccountService : BaseService<Jobseeker>,IAccountService
    {
        private readonly AppDbContext _context;

        public AccountService(AppDbContext context) : base(context)
        {
            this._context = context;
        }


    }
}
