using MassTransit;
using System;

namespace DR.Components.Emails
{
    public interface IEvent
        : CorrelatedBy<Guid>
    {
    }
}
