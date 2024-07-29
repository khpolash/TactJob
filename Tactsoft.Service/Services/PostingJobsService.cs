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
    public class PostingJobsService : BaseService<PostingJobs>, IPostingJobsService
    {
        private readonly AppDbContext _appDbContext;

        public PostingJobsService(AppDbContext context) : base(context)
        {
            this._appDbContext = context;   
        }
    }
}
