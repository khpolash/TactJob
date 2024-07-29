using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;
using Tactsoft.Core.Entities.Base;

namespace Tactsoft.Core.ViewModel
{
	public class UserViewModel :MasterEntity
	{
        public IEnumerable<PersonalDetails>  PersonalDetails { get; set; }
        public IEnumerable<AcademicSummary> AcademicSummary { get; set; }
    }
}
