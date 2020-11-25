using System;
using System.Collections.Generic;
using System.Text;
using Inventory.Application.Interface;
using Inventory.Application.Requests.Uom;
using Inventory.Application.Responses.Uom;
using Inventory.Domain.Enums;
using Inventory.Domain.Models;

namespace Inventory.Application.Mapping
{
    public class UomMapper : IUomMapper
    {
       
        private readonly IUomCategoryMapper _uomCategoryMapper;
        private readonly IUomTypeMapper _uomTypeMapper;

        public UomMapper(IUomCategoryMapper uomCategoryMapper, IUomTypeMapper uomTypeMapper)
        {
            
            _uomCategoryMapper = uomCategoryMapper;
            _uomTypeMapper = uomTypeMapper;
        }
        public UoM Map(AddUom request)
        {
            if (request == null) return null;
            var item = new UoM
            {
                name = request.name,
                description = request.description,
                ratio = request.ratio,
                UoMCategoryId = request.UomCategoryId,
                Id = request.Id,
                CreatedBy = request.createdBy,
            };
            return item;
        }
        public UoM Map(EditUom request, UoM existing)
        {
            if (request == null) return null;

            existing.name = request.name;
            existing.description = request.description;
            existing.Id = request.Id;
            existing.ratio = request.ratio;
            existing.UoMCategoryId = request.UomCategoryId;
            existing.LastModifiedBy = request.updatedBy;
            existing.LastModified = DateTime.Now;

            return existing;
        }
        public UomResponse Map(UoM request)
        {
            if (request == null) return null;

            var data = UomType.From(request.Id);
            
            var response = new UomResponse
            {
                UoMId = request.UoMCategoryId,
                name = request.name,
                description = request.description,
                ratio = request.ratio,
                UoMCategoryId = request.UoMCategoryId,
                UomCategory = _uomCategoryMapper.Map(request.UomCategory),
                Id = request.Id,
                UomType = _uomTypeMapper.mapSingle(data.Id),
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
