using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialReminder.Models;
using TrialReminder.Models.Trials;

namespace TrialReminder.Profiles
{
    public class TrialsProfile : Profile
    {
        public TrialsProfile()
        {
            // Trial - > TrialSummaryItemModel
            CreateMap<Trial, TrialSummaryItemModel>()
                .ForMember(dest => dest.HasStartDate, options => options.MapFrom(src => src.StartDate.HasValue))
                .ForMember(dest => dest.HasEndDate, options => options.MapFrom(src => src.EndDate.HasValue))
                .ForMember(dest => dest.StartDate, options => options.MapFrom(src => src.StartDate.Value))
                .ForMember(dest => dest.EndDate, options => options.MapFrom(src => src.EndDate.Value))
                .ForMember(dest => dest.IsExpired, options => options.MapFrom(src => src.EndDate.HasValue ? src.EndDate.Value.Date < DateTime.Now.Date : false));

            // TrialCreateModel -> Trial
            CreateMap<TrialCreateModel, Trial>();
        }
    }
}
