using Common.Application;
using Shop.Application.SiteEntities.ShippingMethods.Create;
using Shop.Application.SiteEntities.ShippingMethods.Edit;
using Shop.Query.SiteEntities.DTOs;

namespace Shop.Presentation.Facade.Siteentities.ShippingMethods;

public interface IShippingMethodFacade
{
    Task<OperationResult> Create(CreateShippingMethodCommand command);
    Task<OperationResult> Edit(EditShippingMethodCommand command);
    Task<OperationResult> Delete(long id);
    Task<ShippingMethodDto?> GetShippingMethodById(long id);
    Task<List<ShippingMethodDto>> GetList();
}