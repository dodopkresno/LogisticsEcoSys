using AutoMapper;
using Inventory.Application.Responses.Enum;
using Inventory.Application.Responses.Uom;
using Inventory.Application.Responses.UomCategory;
using Inventory.Domain.Enums;
using Inventory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Application.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UomCategory, DataResponse>();
                //.ForMember(dst => dst.MeasureTypeName, opt => opt.MapFrom(src => src.MeasureType.Name))
                //.ForSourceMember(src => src.ToString(), opt => opt.DoNotValidate())
                //.IncludeMembers(um => um.MeasureType);
            CreateMap<MeasureType, DataResponse>(MemberList.None);
                //.ForMember(dest => dest.measureType, opt => opt.Ignore())
                //.AfterMap((src, dest, rc) =>
                //{
                //    var item = src.MeasureType;
                //    EnumResponse dt = new EnumResponse() { Id = item.Id, Name = item.Name };
                //    dest.measureType = rc.Mapper.Map<EnumResponse>(dt);
                //});

                //.ForMember(dest => dest.UoMCategoryId, opt => opt.MapFrom(src => src.UoMCategoryId))
                //.ForMember(dest => dest.name, opt => opt.MapFrom(src => src.name))
                //.ForMember(dest => dest.description, opt => opt.MapFrom(src => src.description))
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                //.ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                //.ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedBy))
                //.ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
                //.ForMember(dest => dest.LastModifiedBy, opt => opt.MapFrom(src => src.LastModifiedBy))
                //.ForMember(dest => dest.LastModified, opt => opt.MapFrom(src => src.LastModified));
            CreateMap<MeasureType, EnumResponse>().ReverseMap();
            CreateMap<UoM, UomResponse>().ReverseMap();
        }
    }
}
