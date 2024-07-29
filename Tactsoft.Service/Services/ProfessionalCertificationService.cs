using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;
using Tactsoft.Data.EntityConfigurations;
using Tactsoft.Service.DbDependencies;
using Tactsoft.Service.Services.Base;

namespace Tactsoft.Service.Services
{
    public class ProfessionalCertificationService : BaseService<ProfessionalCertificationSummary>, IProfessionalCertificationService
    {
        private readonly AppDbContext _appDbContext;
        public ProfessionalCertificationService(AppDbContext context) : base(context)
        {
            _appDbContext = context;
        }
    }
}
