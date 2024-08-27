namespace Ordering.Application.Orders.Eventhandlers;

public class OrderCreatedEventHanndler(ILogger<OrderCreatedEventHanndler> logger)
    : INotificationHandler<OrderCreatedEvent>
{
    public Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event handled: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
