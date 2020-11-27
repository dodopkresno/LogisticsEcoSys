using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class Location : BaseEntity
    {
        public Guid locationId { get; set; }
        public string description { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
        public string checkDigit { get; set; }
        public Guid warehouseId { get; set; }
        public Warehouse warehouse { get; set; }
        public Guid locationParentId { get; set; }
        public Location location { get; set; }
        public int Id { get; set; }
        public LocationType locationType { get; set; }
        public Guid locationCtgId { get; set; }
        public LocationCategory LocationCategory { get; set; }
        public bool isScrap { get; set; }
        public bool isReturn { get; set; }
        public double sequenceNo { get; set; }
        public double maxHeight { get; set; }
        public double maxWeight { get; set; }
        public double maxStack { get; set; }
    }
}
