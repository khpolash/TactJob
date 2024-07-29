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
    public class PermanentAddressService : BaseService<PermanentAddress>, IPermanentAddressService
    {
        private readonly AppDbContext dbContext;
        public PermanentAddressService(AppDbContext context) : base(context)
        {
            dbContext = context;                                                        
        }
    }
}
