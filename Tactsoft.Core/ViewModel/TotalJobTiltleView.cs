using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities.Base;

namespace Tactsoft.Core.ViewModel
{
    public class TotalJobTiltleView :MasterEntity
    {
        public IEnumerable<FrontendViewModel> FrontendViewModel { get; set; }
        public string JobTitle { get; set; }
        public int TotalJob { get; set; }
    }
}
