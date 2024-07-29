using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities.Base;

namespace Tactsoft.Core.ViewModel
{
    public class VmApplyingJobseeker:MasterEntity
    {
        public string JobseekerName { get; set; }
        public string Email { get; set; }
  
        public string JobTittle { get; set; }
        public string Count { get; set; }

    }
}
