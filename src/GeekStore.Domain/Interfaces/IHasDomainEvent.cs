using System.Collections.Generic;
using GeekStore.Domain.Events;

namespace GeekStore.Domain.Interfaces
{
    public interface IHasDomainEvent
    {
        public List<DomainEvent> DomainEvents { get; set; }
    }
}
