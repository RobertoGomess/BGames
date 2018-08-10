using prmToolkit.NotificationPattern;
using System;

namespace BGames.Domain.Entiteis.Base
{
    public abstract class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}
