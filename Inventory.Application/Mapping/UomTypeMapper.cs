using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Inventory.Application.Interface;
using Inventory.Application.Responses.Enum;
using Inventory.Domain.Enums;

namespace Inventory.Application.Mapping
{
    public class UomTypeMapper : IUomTypeMapper
    {
        private readonly IMapper _mapper;
        public UomTypeMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<UomTypeResponse> mapList()
        {
            var data = UomType.List();

            var dto = _mapper.Map<IEnumerable<UomTypeResponse>>(data);
            return dto;
        }
        public UomTypeResponse mapSingle(int Id)
        {
            if (string.IsNullOrEmpty(Id.ToString())) ;
            var data = UomType.From(Id);
            return _mapper.Map<UomTypeResponse>(data);

        }
    }
}
