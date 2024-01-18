using AutoMapper;
using Carpark.Core.Interfaces;

namespace Carpark.Core.Mapper
{
    public class BaseMapper<TSource, TDestination> : IBaseMapper<TSource, TDestination>
    {
        private readonly IMapper _mapper;

        public BaseMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDestination MapModel(TSource source)
        {
            return _mapper.Map<TDestination>(source);
        }

        public IEnumerable<TDestination> MapList(IEnumerable<TSource> source)
        {
            return _mapper.Map<IEnumerable<TDestination>>(source);
        }

        public List<TDestination> MapList2(IEnumerable<TSource> source)
        {
            return _mapper.Map<List<TDestination>>(source);
        }
    }
}