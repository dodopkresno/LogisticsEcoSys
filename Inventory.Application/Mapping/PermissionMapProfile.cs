using AutoMapper;
using Inventory.Application.Requests;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Mapping
{
    public class PermissionMapProfile : Profile
    {
        public PermissionMapProfile()
        {
            CreateMap<AddPermission, Permission>();
            CreateMap<EditPermission, Permission>();
        }
    }
}
