using System.Collections.ObjectModel;

public sealed class Store<T> where T : IHasId
{
    private readonly Dictionary<int, T> _items = new();

    public void Add(T item)
    {
        ArgumentNullException.ThrowIfNull(item);
        if (!_items.TryAdd(item.Id, item))
            throw new InvalidOperationException($"An item with ID {item.Id} already exists.");
    }

    public T? GetById(int id) => _items.TryGetValue(id, out var item) ? item : default;
    public IReadOnlyDictionary<int, T> GetAll() => new ReadOnlyDictionary<int, T>(_items);
    public bool Remove(int id) => _items.Remove(id);
}
