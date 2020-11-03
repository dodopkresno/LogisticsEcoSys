using Inventory.Application.Requests;
using Inventory.Domain.Enums;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Mapping
{
    public class UomCategoryMapper : IUomCategoryMapper
    {
        private readonly IUomCategoryMapper _uomCategoryMapper;

        public UomCategoryMapper(IUomCategoryMapper uomCategoryMapper)
        {
            _uomCategoryMapper = uomCategoryMapper;
        }

        public UomCategory Map(AddUoMCategory request)
        {
            if (request == null) return null;
            var data = MeasureType.From(request.Id);
            var item = new UomCategory
            {
                name = request.name,
                description = request.description,
                MeasureType = data
            };
            return item;
        }
        public UomCategory Map(EditUomCategory request)
        {
            if (request == null) return null;
            
            var data = MeasureType.From(request.Id);
            var item = new UomCategory
            {
                UoMCategoryId = request.UCID,
                name = request.name,
                description = request.description,
                MeasureType = data
            };
            
            return item;
        }
    }
}
