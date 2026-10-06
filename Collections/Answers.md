# Collections — Answers

## 2.1 Research
`IReadOnlyDictionary<TKey,TValue>` is an interface for looking up key/value pairs and enumerating them without exposing mutation operations. `Dictionary<TKey,TValue>` is a concrete hash-table implementation that can add, remove, and replace entries. A public API can return `IReadOnlyDictionary` to communicate a read-only contract and avoid coupling callers to one implementation; this is an interface-level restriction, not a deep immutable snapshot if the underlying object is shared.

`SortedDictionary<TKey,TValue>` keeps keys ordered by its comparer, while `Dictionary` makes no ordering guarantee. A hash dictionary usually offers average O(1) lookup; a sorted dictionary uses a balanced tree and lookup/insertion/removal are O(log n). Choose it when ordered traversal and updates are both needed.

Sources: [Microsoft Learn: IReadOnlyDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlydictionary-2), [Microsoft Learn: SortedDictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.sorteddictionary-2), [Stephen Toub, Choosing .NET collection types](https://learn.microsoft.com/dotnet/standard/collections/).

## 2.2 Pick the collection
- S1 — `Dictionary`: national ID provides a key for fast average O(1) lookups.
- S2 — `HashSet`: it enforces uniqueness and provides fast membership checks.
- S3 — `List`: it preserves insertion order and allows duplicate grades.
- S4 — `IReadOnlyDictionary`: callers can look up prices without mutation operations in the public contract.
- S5 — `SortedDictionary`: it keeps sessions ordered by start time as they are added.
- S6 — `IEnumerable`: it supports one-at-a-time iteration and early stopping without requiring materialization.
