using Common.Query;
using Shop.Query.Products.DTOs;

namespace Shop.Query.Products.GetByFilter;

public class GetProductsByFilterQuery : QueryFilter<ProductFilterResult, ProductFilterParams>
{
    public GetProductsByFilterQuery(ProductFilterParams filterParams) : base(filterParams)
    {
    }
}