using ApressDesignPattern.SOLID._2._OCP.After.Base.Specification;

namespace ApressDesignPattern.SOLID._2._OCP.After
{
    public interface IFilter<TEntity>
    {
        IEnumerable<TEntity> Filter(IEnumerable<TEntity> items, Specification<TEntity> spec);
    }
}
