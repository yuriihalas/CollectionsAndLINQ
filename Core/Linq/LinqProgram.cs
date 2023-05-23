namespace CollectionsAndLINQ.Core.Linq;

public static class LinqProgram
{
    // Write a lambda expression that will return the next number after the provided integer
    public static int Task1(int value)
    {
        int GetNext(int i) => i + 1;
        return GetNext(value);
    }

    // Using LINQ query syntax, write a method that will take IEnumerable<string> values and a string pattern,
    // filters the values that contain the pattern, and return the sorted result.
    public static IEnumerable<string> Task2(IEnumerable<string> list, string pattern) =>
        from value in list
        where value.Contains(pattern)
        orderby value
        select value;

    // Using LINQ method syntax, write a method that will take IEnumerable<string> values and a string pattern,
    // filters the values that contain the pattern, and return the sorted result.
    public static IEnumerable<string> Task3(IEnumerable<string> list, string pattern) =>
        list.Where(value => value.Contains(pattern)).Order();

    //Write a method that takes a collection of elements, and returns the 3rd, 4th, and 5th
    //items of the provided sequence.
    public static List<T> Task4<T>(List<T> list) =>
        list.Skip(2).Take(3).ToList();

    //Write a method that returns all words in the sequence between "start" (inclusive) and "end" (non-inclusive).
    //For example, if given { "One", "start", "more", "end", "thing" } ... this method should return { "start", "more" }
    public static List<string> Task5(List<string> list) =>
        list.SkipWhile(value => !value.Equals("start"))
            .TakeWhile(value => !value.Equals("end"))
            .ToList();

    //Write a method that returns all distinct words that have less than four letters in them.
    public static List<string> Task6(List<string> list) =>
        list.Where(word => word.Length < 4)
            .Distinct()
            .ToList();

    //Create a class Name with 3 properties: First, Middle, Last.
    //Write a method that returns the provided list of names, ordered by Last, in descending order.
    public static List<Name> Task7(List<Name> names) =>
        names.OrderByDescending(name => name.Last).ToList();

    //Using the same Name class as before, write a method that returns the provided list of names,
    //ordered by Last, then Middle, then First in descending order.
    public static List<Name> Task8(List<Name> names) =>
        names.OrderByDescending(name => name.Last)
            .ThenByDescending(name => name.Middle)
            .ThenByDescending(name => name.First)
            .ToList();

    //Write a method that returns the number of strings in the provided sequence that begin with the provided startString.
    public static int Task9(List<string> list, string startString) =>
        list.Count(value => value.StartsWith(startString));

    //Write a method that returns the length of the shortest word
    public static int Task10(List<string> words) =>
        words.Min(word => word.Length);

    //Write a method that returns the total number of characters in all words in the source sequence
    public static int Task11(List<string> words) =>
        words.Sum(word => word.Length);

    //Write a method that returns display strings in the form of "<Last>, <First>" for each provided name. Use Name class from above.
    public static List<string> Task12(List<Name> names) =>
        names.Select(name => $"{name.Last}, {name.First}").ToList();

    //Given a sequence of words, get rid of any that don't have the character 'e' in them, then sort the remaining
    //words alphabetically, then return the following phrase using only the final word in the resulting sequence:
    //-> "The last word is <word>" If there are no words with the character 'e' in them, then return null.
    public static string? Task13(List<string> words) =>
        words.Where(word => word.Contains("e"))
                .Order()
                .LastOrDefault()
            is { } lastWord
            ? $"The last word is {lastWord}"
            : null;
}