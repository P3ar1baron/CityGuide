using CityGuide.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.API.Services
{
    public interface ICityInfoRepository
    {
        IQueryable<City> GetCities();

        City GetCity(int cityId);

        IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId);

        PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);
    }
}
