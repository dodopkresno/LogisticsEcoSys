using AutoMapper;
using Inventory.Application.Interface;
using Inventory.Application.Requests;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Mapping
{
    public class PermissionMapper : IPermissionMapper
    {
        private readonly IMapper _mapper;
        public PermissionMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Permission Map(AddPermission request)
        {
            var objPermission = _mapper.Map<Permission>(request);
            return objPermission;
        }

        public Permission Map(EditPermission request)
        {
            var objToChange = _mapper.Map<Permission>(request);
            return objToChange;
        }
    }
}
