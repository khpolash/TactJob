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
    public class TrainingSummaryService : BaseService<TrainingSummary>, ITrainingSummaryService
    {
        private readonly AppDbContext _dbContext;
        public TrainingSummaryService(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
