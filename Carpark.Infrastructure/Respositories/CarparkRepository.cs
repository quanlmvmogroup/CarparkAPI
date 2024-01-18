using Carpark.Core.Common;
using Carpark.Core.Entities;
using Carpark.Core.Interfaces;
using Carpark.Core.Models;
using Carpark.Infrastructure.Db;
using System.Linq.Expressions;

namespace Carpark.Infrastructure.Respositories
{
    public class CarparkRepository : BaseRepository<CarPark>, ICarparkRepository
    {
        public CarparkRepository(CarparkDbContext dbContext) : base(dbContext) 
        {

        }

        public async Task<PaginatedResponseModel<CarPark>> GetListCarpark(SearchingCarparkInfoRequest request)
        {
            return await GetPaginatedDataByRequest(request,
                filter: f =>
                    (!request.CarParkType.HasValue || f.CarParkType == (short)request.CarParkType.Value) &&
                    (!request.ParkingTypeSystem.HasValue || f.ParkingTypeSystem == (short)request.ParkingTypeSystem.Value) &&
                    (!request.ShortTermParkingType.HasValue || f.ShortTermParkingType == (short)request.ShortTermParkingType.Value) &&
                    (!request.FreeParkingType.HasValue || f.FreeParkingType == (short)request.FreeParkingType.Value) &&
                    (!request.NightParkingType.HasValue || f.NightParkingType == (short)request.NightParkingType.Value) &&
                    (!request.GantryHeight.HasValue || f.GantryHeight >= request.GantryHeight.Value),
                includes: new Expression<Func<CarPark, object>>[]
                {
                    i => i.CarParkTypeNavigation,
                    i => i.FreeParkingNavigation,
                    i => i.NightParkingNavigation
                }, orderBy: o => o.OrderByDescending(x => x.CreatedAt));
        }
    }
}
