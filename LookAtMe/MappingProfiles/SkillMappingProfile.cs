using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LookAtMe.Models;

namespace LookAtMe.MappingProfiles
{
    public class SkillMappingProfile: Profile
    {
        public SkillMappingProfile()
        {
            //theoretically those should be auto mapped, but I wanted to have it in code
            CreateMap<Skill, SkillDto>()
                .ForMember(m => m.SkillId, c => c.MapFrom(s => s.SkillId))
                .ForMember(m => m.SkillName, c => c.MapFrom(s => s.SkillName))
                .ForMember(m => m.SkillLevel, c => c.MapFrom(s => s.SkillLevel))
                .ForMember(m => m.Skilltype, c => c.MapFrom(s => s.Skilltype));

            CreateMap<CreateSkillDto, Skill>()
                .ForMember(m => m.SkillId, c => c.MapFrom(s => s.SkillId))
                .ForMember(m => m.SkillName, c => c.MapFrom(s => s.SkillName))
                .ForMember(m => m.SkillLevel, c => c.MapFrom(s => s.SkillLevel))
                .ForMember(m => m.Skilltype, c => c.MapFrom(s => s.Skilltype));
        }
    }
}
