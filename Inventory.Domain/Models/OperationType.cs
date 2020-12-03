using Inventory.Domain.Common;
using Inventory.Domain.Models.Aggregate.SequenceAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class OperationType : BaseEntity
    {
        public Guid operationId { get; set; }
        public string code { get; set; }
        public bool craeteNewBatch { get; set; }
        public bool useExistingBatch { get; set; }
        public Guid companyId { get; set; }
        public Company company { get; set; }
        public Guid sequenceId { get; set; }
        public Sequence sequence { get; set; }
    }
}
