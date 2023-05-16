using Common.Application;
using Shop.Application.Sellers.AddInventory;
using Shop.Application.Sellers.EditInventory;
using Shop.Query.Sellers.DTOs;

namespace Shop.Presentation.Facade.Sellers.Inventories;

public interface ISellerInventoryFacade
{
    Task<OperationResult> AddInventory(AddSellerInventoryCommand command);
    Task<OperationResult> EditInventory(EditSellerInventoryCommand command);
    Task<InventoryDto?> GetById(long inventoryId);
    Task<List<InventoryDto>> GetList(long sellerId);
    Task<List<InventoryDto>> GetByProductId(long productId);
}