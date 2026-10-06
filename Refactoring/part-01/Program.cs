var calculator = new ShippingCostCalculator(new IShippingCarrier[] { new StandardCarrier(), new ExpressCarrier(), new PickupCarrier() });
Console.WriteLine($"Standard: {calculator.Calculate(ShippingType.Standard, 5m):C}");
Console.WriteLine($"Express: {calculator.Calculate(ShippingType.Express, 5m):C}");
Console.WriteLine($"Pickup: {calculator.Calculate(ShippingType.Pickup, 5m):C}");
var order = new OrderProcessor(new ConsoleEmailSender());
order.Process(new Order("A-101", 250m));
var channels = new INotificationChannel[] { new ConsoleNotificationChannel(), new SmsChannel(), new PushChannel() };
foreach (var channel in channels)
{
    new Notifier(channel).Send("Normal");
    new Notifier(new UrgentDecorator(channel)).Send("Urgent");
    new Notifier(new ScheduledDecorator(channel)).Send("Scheduled");
    new Notifier(new UrgentDecorator(new ScheduledDecorator(channel))).Send("Urgent and scheduled");
}
