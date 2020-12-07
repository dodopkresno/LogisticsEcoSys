using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Rule : BaseEntity
    {
        public Guid ruleId { get; set; }
        public int sequenceNo { get; set; }
        public Guid operationId { get; set; }
        public OperationType operationType { get; set; }
        public Guid srcLocationId { get; set; }
        public Location srcLocation { get; set; }
        public Guid desLocationId { get; set; }
        public Location desLocation { get; set; }
        public int Id { get; set; }
        public ActionType actionType { get; set; }
        public Guid routeId { get; set; }
        public Route route { get; set; }
        public bool haveOperationRule { get; set; }
        public int opsRuleId { get; set; }
        public OperationMovementType operationMovementType { get; set; }
    }
}
