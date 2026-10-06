public interface INotificationChannel { void Send(string message); }
public sealed class SmsChannel : INotificationChannel { public void Send(string message) => Console.WriteLine($"SMS: {message}"); }
public sealed class ConsoleNotificationChannel : INotificationChannel { public void Send(string message) => Console.WriteLine($"Email: {message}"); }
public sealed class PushChannel : INotificationChannel { public void Send(string message) => Console.WriteLine($"Push: {message}"); }
public abstract class NotificationDecorator(INotificationChannel inner) : INotificationChannel { protected INotificationChannel Inner { get; } = inner; public abstract void Send(string message); }
public sealed class UrgentDecorator(INotificationChannel inner) : NotificationDecorator(inner) { public override void Send(string message) => Inner.Send($"[URGENT] {message}"); }
public sealed class ScheduledDecorator(INotificationChannel inner) : NotificationDecorator(inner) { public override void Send(string message) => Inner.Send($"[SCHEDULED] {message}"); }
public sealed class Notifier(INotificationChannel channel) { public void Send(string message) => channel.Send(message); }
