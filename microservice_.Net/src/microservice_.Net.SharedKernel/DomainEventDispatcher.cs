using microservice_.Net.SharedKernel.Interfaces;
using MediatR;

namespace microservice_.Net.SharedKernel;

public class DomainEventDispatcher : IDomainEventDispatcher
{
  private readonly IMediator _mediator;

  public DomainEventDispatcher(IMediator mediator)
  {
    _mediator = mediator;
  }

  public async Task DispatchAndClearEvents(IEnumerable<EntityBase> entitiesWithEvents)
  {
    foreach (var entity in entitiesWithEvents)
    {
      var events = entity.DomainEvents.ToArray();
      entity.ClearDomainEvents();
      foreach (var domainEvent in events)
      {
        await _mediator.Publish(domainEvent).ConfigureAwait(false);
      }
    }
  }
}
