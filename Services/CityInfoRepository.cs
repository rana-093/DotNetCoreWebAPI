using DotNetCoreWebAPI.DbContexts;
using DotNetCoreWebAPI.entities;
using DotNetCoreWebAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebAPI.Services
{
    public class CityInfoRepository : ICityInfoRepository
    {
        private readonly CityContext context;
        
        public CityInfoRepository(CityContext cityContext) {
            this.context = cityContext??throw new ArgumentNullException(nameof(cityContext));
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await context.cities.OrderBy(c => c.Name).ToListAsync();
        }
        public async Task<City?>GetCityAsync(int cityId, bool includePointOfInterest)
        {
            if (includePointOfInterest)
            {
                return await context.cities.Include(c => c.PointOfInterests)
                    .Where(c => c.Id == cityId).FirstOrDefaultAsync();
            }
            return await context.cities.Where(c => c.Id == cityId).FirstOrDefaultAsync();
        }

        public async Task<PointOfInterest?> GetPointOfInterest(int cityId, int pointofInterestId)
        {
            return await context.pointsOfInterests.Where(p => p.cityId == cityId && p.Id == pointofInterestId)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PointOfInterest>>GetPointOfInterestsForCityAsync(int cityId)
        {
            return await context.pointsOfInterests.Where(p => p.cityId == cityId).ToListAsync();
        }
    }
}
