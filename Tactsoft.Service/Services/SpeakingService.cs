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
    public class SpeakingService : BaseService<Speaking>, ISpeakingService
    {
        private readonly AppDbContext _dbContext;
        public SpeakingService(AppDbContext context) : base(context)
        {
            this._dbContext= context;
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem { Text = x.SpeakingName, Value = x.Id.ToString() });
        }
    }
}
