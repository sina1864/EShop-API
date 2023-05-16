using Common.Query;
using Shop.Query.SiteEntities.DTOs;

namespace Shop.Query.SiteEntities.ShippingMethods.GetById;

public record GetShippingMethodByIdQuery(long Id) : IQuery<ShippingMethodDto?>;