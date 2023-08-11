using ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Criterias;
using System.Linq.Expressions;

namespace ApressDesignPattern.SOLID._2._OCP.After.Base.Specification
{
    public static class ExpressionBuilder
    {
        public static Specification<TEntity> Compose<TEntity>(
            this Specification<TEntity> first,
            Specification<TEntity> second,
            Specification<TEntity> merge)
        {
            return null;
        }
        public static Specification<TEntity> And<TEntity>(
            Specification<TEntity> first,
            Specification<TEntity> second)
        {
            return null;
        }

        public static Specification<TEntity> Or<TEntity>(
            Specification<TEntity> first,
            Specification<TEntity> second)
        {
            return null;
            //return new OrSpecification<TEntity>(new ColorSpecification(color),
            //                                     new SizeSpecification(size));
        }
    }
}
