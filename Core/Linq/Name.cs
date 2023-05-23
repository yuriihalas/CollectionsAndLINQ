namespace CollectionsAndLINQ.Core.Linq;

public class Name
{
    public string? First { get; set; }
    public string? Middle { get; set; }
    public string? Last { get; set; }

    public override string ToString() => $"{nameof(First)}: {First}, {nameof(Middle)}: {Middle}, {nameof(Last)}: {Last}";
}