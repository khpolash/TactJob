using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities.Base;

namespace Tactsoft.Core.ViewModel
{
    public class HotJobsView : MasterEntity
    {
        public IEnumerable<FrontendViewModel> FrontendViewModel { get; set; }

        public string CompanyName { get; set; }
        public string ComapnyLogo { get; set; }
        public string Jobtitle { get; set; }
    }
}
