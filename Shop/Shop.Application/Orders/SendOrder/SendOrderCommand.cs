using Common.Application;

namespace Shop.Application.Orders.SendOrder;

public class SendOrderCommand : IBaseCommand
{
    public SendOrderCommand(long orderId)
    {
        OrderId = orderId;
    }

    public long OrderId { get; private set; }
}