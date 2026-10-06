# Refactoring answers

- `ShippingCostCalculator` uses a carrier abstraction and a registry, removing carrier-specific branching (Open/Closed Principle). Adding a carrier means adding a new implementation and wiring it into the program.
- `OrderProcessor` receives its notification dependency through its constructor, so it depends on an abstraction and can use any sender implementation.
- Notification delivery is composed from a channel plus optional decorators. Urgent and scheduled flags can be combined in either order instead of creating a subclass for each combination.
- Added `PickupCarrier` and `PushChannel` as extension examples. The demo wires both from Program.cs.
- Behavior should be checked against the original sample's exact output once copied into the academy repository; starter sources were not available in the supplied workspace, so fee/message parity needs comparison.
