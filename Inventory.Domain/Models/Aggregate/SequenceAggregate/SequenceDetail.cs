using Inventory.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models.Aggregate.SequenceAggregate
{
    public class SequenceDetail : BaseEntity
    {
        public Guid seqDateRangeId { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public int nextNumber { get; set; }
        public Guid sequenceId { get; set; }
        public Sequence sequence { get; set; }

        public void nextSequence(int increment)
        {
            nextNumber += increment;
        }
    }
}
