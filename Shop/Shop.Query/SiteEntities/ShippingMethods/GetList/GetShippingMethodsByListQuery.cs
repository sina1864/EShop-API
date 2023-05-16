using Common.Query;
using Shop.Query.SiteEntities.DTOs;

namespace Shop.Query.SiteEntities.ShippingMethods.GetList;

public record GetShippingMethodsByListQuery : IQuery<List<ShippingMethodDto>>;