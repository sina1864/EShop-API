using Common.Application;

namespace Shop.Application.Orders.Finally;

public record OrderFinallyCommand(long OrderId) : IBaseCommand;