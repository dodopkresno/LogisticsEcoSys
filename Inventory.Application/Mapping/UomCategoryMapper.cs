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
        private readonly IMapper _mapper;

        public UomCategoryMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public UomCategory Map(AddUoMCategory request)
        {
            if (request == null) return null;
            var item = new UomCategory
            {
                name = request.name,
                description = request.description,
                Id = request.Id,
                CreatedBy = request.createdBy,
                Created = request.created,
                IsActive = request.isActive                
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
                Id = request.Id,
                //MeasureType = data,
                LastModifiedBy = request.updatedBy
            };
            
            return item;
        }
        public DataResponse Map(UomCategory request)
        {
            if (request == null) return null;
            
            var data = MeasureType.From(request.Id);
            request.MeasureType = data;
            var response = _mapper.Map<DataResponse>(request);
            //var response = new DataResponse
            //{
            //    UoMCategoryId = request.UoMCategoryId,
            //    name = request.name,
            //    description = request.description,
            //    Id = request.Id,
            //    MeasureType = data,
            //    Created = request.Created,
            //    CreatedBy = request.CreatedBy,
            //    IsActive = request.IsActive,
            //    LastModified = request.Created,
            //    LastModifiedBy = request.LastModifiedBy
            //};

            return response;
        }
    }
}
