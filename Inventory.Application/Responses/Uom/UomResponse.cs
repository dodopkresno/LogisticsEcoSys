using Inventory.Application.Responses.Enum;
using Inventory.Application.Responses.UomCategory;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Responses.Uom
{
    public class UomResponse : BaseResponse
    {
        public Guid UoMId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double ratio { get; set; }
        public Guid UoMCategoryId { get; set; }
        public DataResponse UomCategory { get; set; }
        public int Id { get; set; }
        public UomTypeResponse UomType { get; set; }
    }
}
