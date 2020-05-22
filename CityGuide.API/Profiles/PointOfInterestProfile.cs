using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CityGuide.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();

            CreateMap<Models.PointOfInterestForCreationDto, Entities.PointOfInterest>();

            CreateMap<Models.PointOfInterestForUpdateDto, Entities.PointOfInterest>()
                .ReverseMap();

        }
    }
}
