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
    public class YearOfPassingService : BaseService<YearOfPassing>, IYearOfPassingService
    {
        private readonly AppDbContext _dbContext;
        public YearOfPassingService(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem { Text = x.YearOfPassingName, Value = x.Id.ToString() });
        }
    }
}
