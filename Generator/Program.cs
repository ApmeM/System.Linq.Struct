using System.Collections.Generic;
using System.Linq;

internal class Program
{
    public class Param
    {
        public Param(string type, string name, string? usage = null)
        {
            Type = type;
            Name = name;
            Usage = usage ?? name;
        }

        public readonly string Type;
        public readonly string Name;
        public readonly string Usage;
    }

    public class Method
    {
        public Method(string name, string? type = null, List<Param>? parameters = null, List<Param>? generics = null, string resultType = "T")
        {
            Name = name;
            Type = type;
            Params = parameters;
            Generics = generics;
            ResultType = resultType;
        }

        public readonly string Name;
        public readonly List<Param>? Params;
        public readonly List<Param>? Generics;
        public readonly string? Type;
        public string ResultType;
    }

    private static void Main(string[] args)
    {
        var toAddPredicate = new List<Method>{
            new Method("Count", "int"),
            new Method("Any", "bool"),
            new Method("Single", "T"),
            new Method("SingleOrDefault", "T"),
            new Method("First", "T"),
            new Method("FirstOrDefault", "T"),
            new Method("Last", "T"),
            new Method("LastOrDefault", "T"),
            new Method("Max", "T"),
            new Method("Min", "T"),
            new Method("Sum", "T"),
            new Method("Multiply", "T"),
        };

        var toAddBasicExtension = new List<Method>{
            new Method("Where", null, new List<Param>{new Param("Func<T, bool>", "predicate")}),
            new Method("Skip", null, new List<Param>{new Param("int", "skip")}),
            new Method("Take", null, new List<Param>{new Param("int", "take")}),
            new Method("Append", null, new List<Param>{new Param("T", "toAppend")}),
            new Method("Prepend", null, new List<Param>{new Param("T", "toPrepend")}),
            new Method("OrderBy", null, new List<Param>{new Param("Func<T, TKey>", "keySelector")}, new List<Param>{new Param("", "TKey")}),
            new Method("Concat", null, new List<Param>{new Param("RefLinqEnumerable<T, TEnumerator2>", "seq2", "seq2.enumerator")}, new List<Param>{new Param("IRefEnumerator<T>", "TEnumerator2")}),
            new Method("Zip", null, new List<Param>{new Param("RefLinqEnumerable<T2, TEnumerator2>", "seq2", "seq2.enumerator")}, new List<Param>{new Param("", "T2"),new Param("IRefEnumerator<T2>", "TEnumerator2")}, "(T,T2)"),
            new Method("Select", null, new List<Param>{new Param("Func<T, U>", "map")}, new List<Param>{new Param("", "U")}, "U"),
        };

        var sources = new List<Tuple<string, string>>{
            new Tuple<string, string>("IReadOnlyList<T>", "IReadOnlyListEnumerator<T>"),
            new Tuple<string, string>("T[]", "ArrayEnumerator<T>"),
            new Tuple<string, string>("HashSet<T>", "HashSetEnumerator<T>"),
            new Tuple<string, string>("MultiHashSetWrapper<T>", "MultiHashSetWrapperEnumerator<T>")
        };

        var toMultiSources = new List<Method>{
            new Method("All", "bool", new List<Param> { new Param("Func<T, bool>", "pred") }),
            new Method("Contains", "bool", new List<Param> { new Param("T", "toFind") }),
            new Method("Aggregate", "T", new List<Param> { new Param("Func<T, T, T>", "agg") }),
            new Method("Aggregate", "TAccumulate", new List<Param> { new Param("TAccumulate", "acc"), new Param("Func<TAccumulate, T, TAccumulate>", "agg") }, new List<Param>{new Param("", "TAccumulate")}),
        };

        Console.WriteLine("using System.Collections.Generic;");
        Console.WriteLine("namespace System.Linq.Struct");
        Console.WriteLine("{");
        Console.WriteLine("    public static partial class GeneratedExtensions");
        Console.WriteLine("    {");

        foreach (var method in toAddPredicate)
        {
            Console.WriteLine($"        public static {method.Type} {method.Name}<T, TEnumerator>(this RefLinqEnumerable<T, TEnumerator> seq, Func<T, bool> pred)");
            Console.WriteLine($"            where TEnumerator : IRefEnumerator<T>");
            Console.WriteLine($"            => seq.Where(pred).{method.Name}();");

            toMultiSources.Add(new Method(method.Name, method.Type, null));
            toMultiSources.Add(new Method(method.Name, method.Type, new List<Param> { new Param("Func<T, bool>", "pred") }));
        }

        foreach (var method in toAddBasicExtension)
        {
            var paramMethodString = method.Params == null ? "" : ("," + string.Join(",", method.Params.Select(a => $"{a.Type} {a.Name}")));
            var paramUsageString = method.Params == null ? "" : ("," + string.Join(",", method.Params.Select(a => $"{a.Usage}")));
            var genericMethodString = method.Generics == null ? "" : ("," + string.Join(",", method.Generics.Select(a => $"{a.Name}")));
            var genericConstraintString = method.Generics == null ? "" : (string.Join(" ", method.Generics.Where(a => !string.IsNullOrWhiteSpace(a.Type)).Select(a => $"where {a.Name} : {a.Type}")));

            Console.WriteLine($"        public static RefLinqEnumerable<{method.ResultType}, {method.Name}<T, TPrevious {genericMethodString}>> {method.Name}<T, TPrevious{genericMethodString}>(this RefLinqEnumerable<T, TPrevious> prev {paramMethodString})");
            Console.WriteLine($"            where TPrevious : IRefEnumerator<T> {genericConstraintString}");
            Console.WriteLine($"            => new RefLinqEnumerable<{method.ResultType}, {method.Name}<T, TPrevious{genericMethodString}>>(new {method.Name}<T, TPrevious{genericMethodString}>(prev.enumerator {paramUsageString}));");

            toMultiSources.Add(new Method(method.Name, $"RefLinqEnumerable<{method.ResultType}, {method.Name}<T, {{0}}{genericMethodString}>>", method.Params, method.Generics));
        }

        foreach (var method in toMultiSources)
        {
            var paramMethodString = method.Params == null ? "" : ("," + string.Join(",", method.Params.Select(a => $"{a.Type} {a.Name}")));
            var paramUsageString = method.Params == null ? "" : (string.Join(",", method.Params.Select(a => $"{a.Name}")));
            var genericMethodString = method.Generics == null ? "" : ("," + string.Join(",", method.Generics.Select(a => $"{a.Name}")));
            var genericConstraintString = method.Generics == null ? "" : (string.Join(" ", method.Generics.Where(a => !string.IsNullOrWhiteSpace(a.Type)).Select(a => $"where {a.Name} : {a.Type}")));

            foreach (var type in sources)
            {
                Console.WriteLine($"        public static {string.Format(method.Type ?? "", type.Item2)} {method.Name}<T {genericMethodString}>(this {type.Item1} c {paramMethodString})");
                if (!string.IsNullOrWhiteSpace(genericConstraintString))
                    Console.WriteLine($"            {genericConstraintString}");
                Console.WriteLine($"            => new RefLinqEnumerable<T, {type.Item2}>(new {type.Item2}(c)).{method.Name}({paramUsageString});");
            }
        }

        // Separate generator for SelectMany
        foreach (var type in sources)
        {
            Console.WriteLine($"        public static RefLinqEnumerable<U, SelectMany<U, TUEnumerator, Select<T, {type.Item2}, RefLinqEnumerable<U, TUEnumerator>>>> SelectMany<T, U, TUEnumerator>(this {type.Item1} c, Func<T, RefLinqEnumerable<U, TUEnumerator>> func)");
            Console.WriteLine($"            where TUEnumerator : IRefEnumerator<U>");
            Console.WriteLine($"            => c.Select(func).SelectMany();");
        }

        Console.WriteLine("    }");
        Console.WriteLine("}");
    }
}