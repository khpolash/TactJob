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
    public class ResumeReceivingOptionService : BaseService<ResumeReceivingOption>, IResumeReceivingOptionService
    {
        private readonly AppDbContext appDb;
        public ResumeReceivingOptionService(AppDbContext context) : base(context)
        {
            appDb= context;
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem { Text = x.ResumeOption, Value = x.Id.ToString() });
        }
    }
}
