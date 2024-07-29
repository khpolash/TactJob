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
    public class ServiceTypeService : BaseService<ServiceType>, IServiceTypeService
    {
        private readonly AppDbContext appDbContext;
        public ServiceTypeService(AppDbContext context) : base(context)
        {
            appDbContext = context;
        }

        public IEnumerable<SelectListItem> Dropdown()
        {
            return All().Select(x => new SelectListItem { Text = x.ServiceTypeName, Value = x.Id.ToString() });
        }
    }
}
