using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;
using Tactsoft.Service.DbDependencies;
using Tactsoft.Service.Services.Base;

namespace Tactsoft.Service.Services
{
    public class CompanyService : BaseService<Company>, ICompanyService
    {
        private readonly AppDbContext _appDbContext;
        public CompanyService(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }

        public long GetIdByUeseName(string userName)
        {
            var company = _appDbContext.Companies.FirstOrDefault(x => x.UserName == userName);
            return company.Id;
        }
    }
}
