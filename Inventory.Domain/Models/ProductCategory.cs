using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class ProductCategory : BaseEntity
    {
        public Guid productCategoryId { get; set; }
        public string pcPathName { get; set; }
        public Guid parentPCId { get; set; }
        public ProductCategory productCategory { get; set; }
        public Guid routeId { get; set; }
        public Route route { get; set; }
        public Guid putawayRuleId { get; set; }
        public MovementRule putawayRule { get; set; }
        public Guid pickingRuleId { get; set; }
        public MovementRule pickingRule { get; set; }
        public Guid replenRuleId { get; set; }
        public MovementRule replenRule { get; set; }

        //putaway & picking strategy

    }
}
