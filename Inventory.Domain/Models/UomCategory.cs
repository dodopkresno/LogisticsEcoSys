using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Domain.Models
{
    public class UomCategory : BaseEntity
    {
        public Guid UoMCategoryId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public MeasureType MeasureType { get; set; }

        //public bool canPostUomCategory(string data)
        //{
        //    bool param = true;
        //    if (data == null)
        //        param = false;

        //    return param;
        //}
    }
}