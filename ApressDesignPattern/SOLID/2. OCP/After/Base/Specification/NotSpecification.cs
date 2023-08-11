namespace ApressDesignPattern.SOLID._2._OCP.After.Base.Specification;

public class NotSpecification<TEntity> 
    : Specification<TEntity>
{
    #region Members

    Specification<TEntity> _specification;

    #endregion

    public NotSpecification(Specification<TEntity> specification)
    {

        if (specification is null)
            throw new ArgumentNullException("originalSpecification");

        _specification = specification;
    }

    public override bool IsSatisfied(TEntity entity) => 
        !_specification.IsSatisfied(entity);
}
