using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
<<<<<<< HEAD
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
=======
        Expression<Func<T, bool>> Criteria {get;}
        List<Expression<Func<T, object>>> Includes {get;}
>>>>>>> 55284bd3aab2b4741e45c55a3a0c107358c1462d
    }
}