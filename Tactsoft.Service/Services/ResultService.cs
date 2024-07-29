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
    public class ResultService : BaseService<Result>, IResultService
    {
        private readonly AppDbContext _dbContext;
        public ResultService(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem { Text = x.ResultName, Value = x.Id.ToString() });
        }
    }
}
