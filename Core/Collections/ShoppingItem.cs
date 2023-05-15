namespace CollectionsAndLINQ.Core.Collections;

public class ShoppingItem
{
    public ShoppingItem(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public string Name { get; set; }

    public Decimal Price { get; set; }

    public int Quantity { get; set; }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Price)}: {Price}, {nameof(Quantity)}: {Quantity}";
    }
}