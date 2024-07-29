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
    public class LevelofEducationService : BaseService<LevelofEducation>, ILevelofEducationService
    {
        private readonly AppDbContext _dbContext;
        public LevelofEducationService(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem { Text = x.LevelofEducationName, Value = x.Id.ToString() });
        }
    }
}
