namespace CollectionsAndLINQ.Core.Collections;

public class ShoppingItem
{
    public ShoppingItem(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; init; }

    public decimal Price { get; init; }

    public int Quantity { get; init; }

    public override string ToString() =>
        $"{nameof(Name)}: {Name}, {nameof(Price)}: {Price}, {nameof(Quantity)}: {Quantity}";
}