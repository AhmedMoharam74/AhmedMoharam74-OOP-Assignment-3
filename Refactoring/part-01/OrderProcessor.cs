public sealed record Order(string Number, decimal Total);
public interface IOrderNotification { void Send(Order order); }
public sealed class ConsoleEmailSender : IOrderNotification { public void Send(Order order) => Console.WriteLine($"Email sent for {order.Number}"); }
public sealed class OrderProcessor(IOrderNotification notification)
{
 public void Process(Order order) { ArgumentNullException.ThrowIfNull(order); Console.WriteLine($"Processing {order.Number}: {order.Total:C}"); notification.Send(order); }
}
