using Carpark.BL.Services.Interfaces;
using Carpark.Data.CarparkDbContext;
using Carpark.Data.Common;
using Carpark.Data.Models;
using Carpark.Utilities.Enums;
using Carpark.ViewModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Carpark.BL.Services.Impls
{
    public class CarparkBiz : ICarparkBiz
    {
        private readonly CarparkDbContext _context;

        public CarparkBiz(CarparkDbContext carparkDbContext)
        {
            _context = carparkDbContext;
        }

        public async Task<CarparkInfoDto> GetCarparkInfoByCarparkNo(string carparkNo)
        {
            var carpark = await _context.Carparks.FindAsync(carparkNo);

            var carparkInfo = new CarparkInfoDto
            {
                CarParkNo = carpark.CarParkNo,
                Address = carpark.Address,
                XCoord = carpark.XCoord,
                YCoord = carpark.YCoord,
                CarParkDeck = carpark.CarParkDeck,
                GantryHeight = carpark.GantryHeight,
                CarParkBasement = carpark.CarParkBasement,
                CarParkType = (ECarParkType)carpark.CarParkType,
                ParkingTypeSystem = (ETypeOfParking)carpark.ParkingTypeSystem,
                ShortTermParkingType = (EShortTermParking)carpark.ShortTermParkingType,
                FreeParkingType = (EFreeParking)carpark.FreeParkingType,
                NightParkingType = (ENightParkingType)carpark.NightParkingType
            };

            return carparkInfo;
        }

        public async Task<PagedResult<CarparkInfoDto>> GetListCarparkInfo(SearchingCarparkInfoRequest request)
        {
            var query = _context.Carparks.AsQueryable();

            if (request.CarParkType.HasValue)
                query = query.Where(x => (ECarParkType)x.CarParkType == request.CarParkType);

            if (request.ShortTermParkingType.HasValue)
                query = query.Where(x => (EShortTermParking)x.ShortTermParkingType == request.ShortTermParkingType);

            if (request.FreeParkingType.HasValue)
                query = query.Where(x => (EFreeParking)x.FreeParkingType == request.FreeParkingType);

            if (request.NightParkingType.HasValue)
                query = query.Where(x => (ENightParkingType)x.NightParkingType == request.NightParkingType);

            if (request.ParkingTypeSystem.HasValue)
                query = query.Where(x => (ETypeOfParking)x.ParkingTypeSystem == request.ParkingTypeSystem);

            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(carparkInfo => new CarparkInfoDto()
                {
                    CarParkNo = carparkInfo.CarParkNo,
                    Address = carparkInfo.Address,
                    XCoord = carparkInfo.XCoord,
                    YCoord = carparkInfo.YCoord,
                    CarParkDeck = carparkInfo.CarParkDeck,
                    GantryHeight = carparkInfo.GantryHeight,
                    CarParkBasement = carparkInfo.CarParkBasement,
                    CarParkType = (ECarParkType)carparkInfo.CarParkType,
                    ParkingTypeSystem = (ETypeOfParking)carparkInfo.ParkingTypeSystem,
                    ShortTermParkingType = (EShortTermParking)carparkInfo.ShortTermParkingType,
                    FreeParkingType = (EFreeParking)carparkInfo.FreeParkingType,
                    NightParkingType = (ENightParkingType)carparkInfo.NightParkingType
                }).ToListAsync();

            var pagedResult = new PagedResult<CarparkInfoDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };

            return pagedResult;
        }
    }
}
