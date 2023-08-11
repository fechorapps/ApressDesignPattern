using ApressDesignPattern.SOLID._2._OCP.After.Base.Specification;

namespace ApressDesignPattern.SOLID._2._OCP.After;

/// <summary>
/// Represent a Specification
/// <remarks>
/// Specification overload operators for create AND,OR or NOT specifications.
/// Additionally overload AND and OR operators with the same sense of ( binary And and binary Or ).
/// C# couldn’t overload the AND and OR operators directly since the framework doesn’t allow such craziness. But
/// with overloading false and true operators this is posible.
/// </remarks>
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public abstract class Specification<TEntity>
    : ISpecification<TEntity>
{
    #region ISpecification<TEntity> Members
    public abstract bool IsSatisfied(TEntity entity);
    #endregion

    #region Override Operators

    /// <summary>
    ///  And operator
    /// </summary>
    /// <param name="first">first operand in this AND operation</param>
    /// <param name="second">second operand in this AND operation</param>
    /// <returns>New specification<see cref="Specification{TEntity}"/></returns>
    public static Specification<TEntity> operator &(
        Specification<TEntity> first,
        Specification<TEntity> second) =>
            new AndSpecification<TEntity>(first, second);

    /// <summary>
    ///  And operator
    /// </summary>
    /// <param name="first">first operand in this OR operation</param>
    /// <param name="second">second operand in this OR operation</param>
    /// <returns>New specification<see cref="Specification{TEntity}"/></returns>
    public static Specification<TEntity> operator |(
        Specification<TEntity> first,
        Specification<TEntity> second) =>
            new OrSpecification<TEntity>(first, second);

    /// <summary>
    /// Not specification
    /// </summary>
    /// <param name="specification">Specification to negate</param>
    /// <returns>New specification</returns>
    public static Specification<TEntity> operator !(Specification<TEntity> specification) =>
        new NotSpecification<TEntity>(specification);


    /// <summary>
    /// Override operator false, only for support AND OR operators
    /// </summary>
    /// <param name="specification">Specification instance</param>
    /// <returns>See False operator in C#</returns>
    public static bool operator false(
        Specification<TEntity> specification) => false;

    /// <summary>
    /// Override operator true, only for support AND OR operators
    /// </summary>
    /// <param name="specification">Specification instance</param>
    /// <returns>See True operator in C#</returns>
    public static bool operator true(
        Specification<TEntity> specification) => true;

    #endregion
}
