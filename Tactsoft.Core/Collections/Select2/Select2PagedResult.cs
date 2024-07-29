using Tactsoft.Core.Collections.Select2;
using System.Collections.Generic;

namespace Tactsoft.Core.Collections.Select2
{
    public class Select2PagedResult
    {
        public int Total { get; set; }
        public List<Select2Result> Results { get; set; }
    }
}