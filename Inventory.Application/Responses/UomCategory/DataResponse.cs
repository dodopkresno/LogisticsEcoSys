using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Responses.UomCategory
{
    public class DataResponse : BaseResponse
    {
        public Guid UoMCategoryId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public MeasureType MeasureType { get; set; }
    }
}
