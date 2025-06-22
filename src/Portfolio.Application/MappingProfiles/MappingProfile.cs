// Portfolio.Application.Mappings/MappingProfile.cs
using AutoMapper;
using Portfolio.Application.Models.Dtos;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Person ↔ DTO
            CreateMap<Person, PersonDto>();
            CreateMap<CreatePersonDto, Person>();
            CreateMap<UpdatePersonDto, Person>();

            // Project ↔ DTO
            CreateMap<Project, ProjectDto>()
                .ForMember(dest => dest.Tags,
                    opt => opt.MapFrom(src => src.Tags.Select(t => t.Name)));
            CreateMap<CreateProjectDto, Project>();
            CreateMap<UpdateProjectDto, Project>();

            // Skill ↔ DTO
            CreateMap<Skill, SkillDto>()
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.Level.ToString()));
            CreateMap<CreateSkillDto, Skill>();
            CreateMap<UpdateSkillDto, Skill>();

            // Education ↔ DTO
            CreateMap<Education, EducationDto>();
            CreateMap<CreateEducationDto, Education>();
            CreateMap<UpdateEducationDto, Education>();

            // WorkExperience ↔ DTO
            CreateMap<WorkExperience, WorkExperienceDto>();
            CreateMap<CreateWorkExperienceDto, WorkExperience>();
            CreateMap<UpdateWorkExperienceDto, WorkExperience>();

            // ContactInfo ↔ DTO
            CreateMap<ContactInfo, ContactInfoDto>();
            CreateMap<CreateContactInfoDto, ContactInfo>();
            CreateMap<UpdateContactInfoDto, ContactInfo>();

            // Tag ↔ DTO
            CreateMap<Tag, TagDto>();
            CreateMap<CreateTagDto, Tag>();
            CreateMap<UpdateTagDto, Tag>();
        }
    }
}
