using AutoMapper;
using Inventory.Application.Interface;
using Inventory.Application.Requests.UomCategory;
using Inventory.Application.Responses.UomCategory;
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
        private readonly IMapper _mapper;

        public UomCategoryMapper(IUomCategoryMapper uomCategoryMapper, IMapper mapper)
        {
            _uomCategoryMapper = uomCategoryMapper;
            _mapper = mapper;
        }

        public UomCategory Map(AddUoMCategory request)
        {
            if (request == null) return null;
            var data = MeasureType.From(request.Id);
            var item = new UomCategory
            {
                name = request.name,
                description = request.description,
                MeasureType = data,
                LastModifiedBy = request.updatedBy
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
                MeasureType = data,
                LastModifiedBy = request.updatedBy
            };
            
            return item;
        }
        public DataResponse Map(UomCategory request)
        {
            if (request == null) return null;

            var response = _mapper.Map<DataResponse>(request);
            return response;
        }
    }
}
