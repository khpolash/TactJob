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
    public class PersonalDetailsService : BaseService<PersonalDetails>, IPersonalDetailsService
    {
        private readonly AppDbContext _appDbContext;
        public PersonalDetailsService(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
    }
}
