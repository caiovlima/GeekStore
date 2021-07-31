using System;

namespace GeekStore.Domain.Common
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            Created = new DateTime();
        }

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
    }
}
