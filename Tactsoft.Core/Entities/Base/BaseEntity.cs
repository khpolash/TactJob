using Tactsoft.Core.Entities.Base;

namespace Tactsoft.Core.Base
{
    public class BaseEntity: MasterEntity
    {
        public long CreatedBy { get; set; }
        public DateTimeOffset CreatedDateUtc { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedDateUtc { get; set; }
    }
}
