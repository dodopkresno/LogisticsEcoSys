using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Inventory.Application.Responses.UomCategory;
using Inventory.Domain.Enums;
using Inventory.Domain.Models;

namespace Inventory.Application.Mapping
{
    public class UomCategoryMeasureTypeValueResolver : IValueResolver<UomCategory, DataResponse, MeasureType>
    {
        public MeasureType Resolve(UomCategory source, DataResponse destination, MeasureType destMember, ResolutionContext context)
        {
            var data = MeasureType.From(source.Id);
            return data;
        }
    }
}
