using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Inventory.Application.Responses.Enum;
using Inventory.Application.Responses.UomCategory;
using Inventory.Domain.Enums;
using Inventory.Domain.Models;

namespace Inventory.Application.Mapping
{
    //public class UomCategoryMeasureTypeValueResolver : IValueResolver<UomCategory, DataResponse, EnumResponse>
    //{
    //    public EnumResponse Resolve(UomCategory source, DataResponse destination, EnumResponse destMember, ResolutionContext context)
    //    {
    //        var data = MeasureType.From(source.Id);
    //        EnumResponse dtEnum = new EnumResponse() { Id = data.Id, Name = data.Name };
    //        return dtEnum;
    //    }
    //}
}
