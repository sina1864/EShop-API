using Common.Query;
using Shop.Query.Users.DTOs;

namespace Shop.Query.Users.Addresses.GetById;

public record GetUserAddressByIdQuery(long AddressId) : IQuery<AddressDto?>;