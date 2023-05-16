using Common.Query;
using Shop.Query.Sellers.DTOs;

namespace Shop.Query.Sellers.Inventories.GetByProductId;

public record GetInventoriesByProductIdQuery(long ProductId) : IQuery<List<InventoryDto>>;