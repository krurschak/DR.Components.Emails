using System;

namespace DR.Components.Emails.Commands
{
    public interface SendEmail
        : ICommand
    {
        Guid? EmailId { get; }
        Guid? AppId { get; }
        string Recipients { get; }
        string Cc { get; }
        string Bcc { get; }
        string Subject { get; }
        string Body { get; }
        string Signature { get; }
    }
}
