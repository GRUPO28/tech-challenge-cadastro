using System.Diagnostics.CodeAnalysis;

namespace Common.Exceptions;

[ExcludeFromCodeCoverage]
public class ApplicationNotificationException : NotificationException
{
    public ApplicationNotificationException(string message) : base(message)
    {
        
    }
}
