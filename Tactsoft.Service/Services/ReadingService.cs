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
    public class ReadingService : BaseService<Reading>, IReadingService
    {
        private readonly AppDbContext appDbContext;
        public ReadingService(AppDbContext context) : base(context)
        {
            this.appDbContext = context;
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem { Text = x.ReadingName, Value = x.Id.ToString() });
        }
    }
}
