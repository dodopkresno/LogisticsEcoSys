﻿//using AutoMapper;
using Inventory.Application.Interface;
using Inventory.Application.Requests.UomCategory;
using Inventory.Application.Responses.Enum;
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
       // private readonly IMapper _mapper;
        public UomCategoryMapper()
        {
            //_mapper = mapper;
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
        public UomCategory Map(EditUomCategory request, UomCategory existing)
        {
            if (request == null) return null;
            
            existing.name = request.name;
            existing.description = request.description;
            existing.Id = request.Id;
            existing.LastModifiedBy = request.updatedBy;
            existing.LastModified = DateTime.Now;

            return existing;
        }
        public DataResponse Map(UomCategory request)
        {
            if (request == null) return null;

            var data = MeasureType.From(request.Id);
            //request.MeasureType = data;
            //DataResponse response = _mapper.Map<DataResponse>(request);
            //EnumResponse dtEnum = new EnumResponse() { Id = data.Id, Name = data.Name };
            //var mt = _mapper.Map<EnumResponse>(dtEnum);

            var response = new DataResponse
            {
                UoMCategoryId = request.UoMCategoryId,
                name = request.name,
                description = request.description,
                Id = request.Id,
                MeasureTypeName = data.Name,
                Created = request.Created,
                CreatedBy = request.CreatedBy,
                IsActive = request.IsActive,
                LastModified = request.Created,
                LastModifiedBy = request.LastModifiedBy
            };

            return response;
        }
    }
}
