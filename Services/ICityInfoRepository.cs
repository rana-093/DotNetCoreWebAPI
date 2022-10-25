using DotNetCoreWebAPI.entities;

namespace DotNetCoreWebAPI.Services
{
    public interface ICityInfoRepository
    {
        public Task<IEnumerable<City>> GetCitiesAsync();

        public Task<City?> GetCityAsync(int cityId, bool includePointOfInterest);

        public Task<IEnumerable<PointOfInterest>> GetPointOfInterestsForCityAsync(int cityId);

        public Task<PointOfInterest?> GetPointOfInterest(int cityId, int pointofInterestId);
    }
}
