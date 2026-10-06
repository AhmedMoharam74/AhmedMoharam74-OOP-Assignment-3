# Answers

## Reports — Template Method
The abstract base class owns the invariant algorithm: create destination, render, write once, and return the path. Each exporter supplies its filename and format-specific rendering. An abstract class fits because the exporters share implementation/state and must inherit the same algorithm; an interface can specify a contract but does not naturally hold this shared protected template implementation.

## Enrollment — Facade
The Facade presents one `Enroll` call over the four-service workflow. The caller no longer needs to construct the services, know their order, or pass invoice/payment details among them. Existing service classes are used as-is.
