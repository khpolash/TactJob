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
    public class ThanaService : BaseService<Thana>, IThanaService
    {
        private readonly AppDbContext _appDbContext;
        public ThanaService(AppDbContext context) : base(context)
        {
            this._appDbContext = context;
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem { Text = x.ThanaName, Value = x.Id.ToString() });
        }
    }
}
