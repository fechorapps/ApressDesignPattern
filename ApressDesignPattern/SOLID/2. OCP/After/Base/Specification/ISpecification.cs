namespace ApressDesignPattern.SOLID._2._OCP.After.Base.Specification;

public interface ISpecification<TEntity>
{
    bool IsSatisfied(TEntity entity);
}
