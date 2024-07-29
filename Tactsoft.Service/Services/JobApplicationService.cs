using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class JobApplicationService: BaseService<JobApplication>, IJobApplicationService
    {
        private readonly AppDbContext _dbContext;
        public JobApplicationService(AppDbContext context) : base(context)
        {
            this._dbContext = context;
        }

        
    }
}
