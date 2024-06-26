using AutoMapper;
using TemplateProject.Application.Endpoints.People;
using TemplateProject.Application.Endpoints.People.Commands;
using TemplateProject.Domain.Entities;

namespace TemplateProject.Application.Mapping;

public class PeopleProfile : Profile
{
    public PeopleProfile()
    {
        CreateMap<Person, PersonViewModel>()
            .ReverseMap();
        CreateMap<AddPersonCommand, Person>()
            .ForMember(dest => dest.Active, opt => opt.MapFrom(src => true))
            .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())
            .ForMember(dest => dest.ModifiedBy, opt => opt.Ignore())
            .ForMember(dest => dest.ModifiedOn, opt => opt.Ignore());
    }
}
