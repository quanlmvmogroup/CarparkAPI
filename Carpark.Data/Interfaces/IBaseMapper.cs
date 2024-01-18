namespace Carpark.Core.Interfaces
{
    public interface IBaseMapper<TSource, TDestination>
    {
        TDestination MapModel(TSource source);

        IEnumerable<TDestination> MapList(IEnumerable<TSource> source);

        List<TDestination> MapList2(IEnumerable<TSource> source);
    }
}
