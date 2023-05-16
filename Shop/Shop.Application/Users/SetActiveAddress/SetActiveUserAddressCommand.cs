using Common.Application;

namespace Shop.Application.Users.SetActiveAddress;

public record SetActiveUserAddressCommand(long UserId, long AddressId) : IBaseCommand;