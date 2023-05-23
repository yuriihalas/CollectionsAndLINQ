namespace CollectionsAndLINQ.Core.Collections;

public static class CollectionsRunner
{
    public static void Run()
    {
        List<ShoppingItem> shoppingList = new()
        {
            new("Pie", 20.3M, 2),
            new("Apple", 10.3M, 1),
            new("Cucumber", 10.1M, 2)
        };

        shoppingList.ForEach(Console.WriteLine);
    }
}