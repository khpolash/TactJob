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
    public class PreferredAreasService : BaseService<PreferredAreas>, IPreferredAreasService
    {
        private readonly AppDbContext _dbContext;
        public PreferredAreasService(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
