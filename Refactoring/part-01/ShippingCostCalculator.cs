public enum ShippingType { Standard, Express, Pickup }
public interface IShippingCarrier { ShippingType Type { get; } decimal Calculate(decimal weightKg); }
public sealed class StandardCarrier : IShippingCarrier { public ShippingType Type => ShippingType.Standard; public decimal Calculate(decimal weightKg) => 5m + 1.2m * weightKg; }
public sealed class ExpressCarrier : IShippingCarrier { public ShippingType Type => ShippingType.Express; public decimal Calculate(decimal weightKg) => 12m + 2.5m * weightKg; }
public sealed class PickupCarrier : IShippingCarrier { public ShippingType Type => ShippingType.Pickup; public decimal Calculate(decimal weightKg) => 0m; }
public sealed class ShippingCostCalculator(IEnumerable<IShippingCarrier> carriers)
{
 private readonly IReadOnlyDictionary<ShippingType,IShippingCarrier> _carriers = carriers.ToDictionary(x => x.Type);
 public decimal Calculate(ShippingType type, decimal weightKg) => _carriers.TryGetValue(type,out var carrier) ? carrier.Calculate(weightKg) : throw new ArgumentOutOfRangeException(nameof(type));
}
// Add new carriers by implementing IShippingCarrier; no existing class changes are needed.
