using Tactsoft.Core.Entities.Base;

namespace Tactsoft.Core.ViewModel
{
    public class JobViewModel:MasterEntity
    {

        public IEnumerable<FrontendViewModel> FrontendViewModel { get; set; }
        public string JobCategoryName { get; set; }
        public int TotalJob { get; set; }

        public string JobcategoryLogo { get; set; }


    }

}
