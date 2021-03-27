using MassTransit;
using System;

namespace DR.Components.Emails
{
    public interface ICommand
        : CorrelatedBy<Guid>
    {
        Guid CommandId { get; }
    }
}
