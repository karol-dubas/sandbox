using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper_examples
{
    internal class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap: Source --> Destination
            CreateMap<User, UserDto>()
                .ForMember(d => d.PropToIgnore, o => o.Ignore())
                .ForMember(d => d.FullName, o => o.MapFrom(s => $"{s.FirstName} {s.LastName}"))
                .ForMember(d => d.Age, o => o.MapFrom(s => DateTime.Now.Year - s.BirthDate.Year));

            CreateMap<Order, OrderDto>()
                // unflattening tylko dla ReverseMap()
                .ReverseMap();
        }
    }
}
