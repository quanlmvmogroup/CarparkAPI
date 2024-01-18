using Carpark.Core.Common;
using Carpark.Core.Entities;
using Carpark.Core.Interfaces;
using Carpark.Core.Models;
using Carpark.Core.Services.Interfaces;

namespace Carpark.Core.Services.Impls
{
    public class CarparkService : ICarparkService
    {
        private readonly ICarparkRepository _carparkRepository;
        private readonly IBaseMapper<CarPark, CarparkInfoDto> _carparkMapper;

        public CarparkService(ICarparkRepository carparkRepository, IBaseMapper<CarPark, CarparkInfoDto> carparkMapper)
        {
            _carparkRepository = carparkRepository;
            _carparkMapper = carparkMapper;
        }

        public async Task<PaginatedResponseModel<CarparkInfoDto>> GetListCarparkInfo(SearchingCarparkInfoRequest request)
        {
            var result = await _carparkRepository.GetListCarpark(request);

            var mappedData = _carparkMapper.MapList(result.Data);
            return new PaginatedResponseModel<CarparkInfoDto>(mappedData.ToList(), mappedData.Count(), request.PageNum, request.PageSize);
        }
    }
}
