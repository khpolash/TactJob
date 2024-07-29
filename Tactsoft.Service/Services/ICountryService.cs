using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;
using Tactsoft.Core.ViewModel;
using Tactsoft.Service.Services.Base;

namespace Tactsoft.Service.Services
{
    public interface ICountryService:IBaseService<Country>
    {
        IEnumerable<SelectListItem> Dropdown();
      
    }
}
