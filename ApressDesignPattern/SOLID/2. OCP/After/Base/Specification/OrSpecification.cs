namespace ApressDesignPattern.SOLID._2._OCP.After.Base.Specification;

public class OrSpecification<TEntity> 
    : Specification<TEntity>
{
    private readonly Specification<TEntity> _first, _second;

    public OrSpecification(Specification<TEntity> first, Specification<TEntity> second)
    {
        _first = first;
        _second = second;
    }

    public override bool IsSatisfied(TEntity entity) => 
        _first.IsSatisfied(entity) || _second.IsSatisfied(entity);
}
