using AutoMapper;
using Inventory.Application.Responses.UomCategory;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Mapping
{
    public class UomCategoryMapProfile : Profile
    {
        public UomCategoryMapProfile()
        {
            CreateMap<UomCategory, DataResponse>();
        }
    }
}
