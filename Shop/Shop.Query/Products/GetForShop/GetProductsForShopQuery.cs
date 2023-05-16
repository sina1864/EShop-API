using Common.Query;
using Shop.Query.Products.DTOs;

namespace Shop.Query.Products.GetForShop;

public class GetProductsForShopQuery : QueryFilter<ProductShopResult, ProductShopFilterParam>
{
    public GetProductsForShopQuery(ProductShopFilterParam filterParams) : base(filterParams)
    {
    }
}