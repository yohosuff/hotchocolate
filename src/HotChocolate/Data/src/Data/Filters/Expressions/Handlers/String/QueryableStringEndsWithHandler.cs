using System.Linq.Expressions;
using HotChocolate.Language;
using HotChocolate.Types;

namespace HotChocolate.Data.Filters.Expressions;

public class QueryableStringEndsWithHandler : QueryableStringOperationHandler
{
    public QueryableStringEndsWithHandler(InputParser inputParser) : base(inputParser)
    {
        CanBeNull = false;
    }

    protected override int Operation => DefaultFilterOperations.EndsWith;

    public override Expression HandleOperation(
        QueryableFilterContext context,
        IFilterOperationField field,
        IValueNode value,
        object? parsedValue)
    {
        Expression property = context.GetInstance();
        return FilterExpressionBuilder.EndsWith(property, parsedValue);
    }
}
