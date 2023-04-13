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

        public string MethodParam => $"{this.Type} {this.Name}";
        public string GenericConstraint => $"where {this.Name} : {this.Type}";
    }

    public class Method
    {
        public Method(string name, string? type = null, List<Param>? parameters = null, List<Param>? generics = null, string resultType = "TResult")
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

        public string? paramMethodString => this.Params == null ? null : string.Join(",", this.Params.Select(a => a.MethodParam));
        public string? paramUsageString => this.Params == null ? null : string.Join(",", this.Params.Select(a => a.Usage));
        public string? genericNameString => this.Generics == null || this.Generics.All(a => string.IsNullOrWhiteSpace(a.Name)) ? null : string.Join(",", this.Generics.Where(a => !string.IsNullOrWhiteSpace(a.Name)).Select(a => a.Name));
        public string? genericUsageString => this.Generics == null || this.Generics.All(a => string.IsNullOrWhiteSpace(a.Usage)) ? null : string.Join(",", this.Generics.Where(a => !string.IsNullOrWhiteSpace(a.Usage)).Select(a => a.Usage));
        public string? genericConstraintString => this.Generics == null || this.Generics.All(a => string.IsNullOrWhiteSpace(a.Type)) ? null : (string.Join(" ", this.Generics.Where(a => !string.IsNullOrWhiteSpace(a.Type)).Select(a => a.GenericConstraint)));

    }

    private static void Main(string[] args)
    {
        var sources = new List<(string, string, string, string)>{
            ("IReadOnlyList<TSource>", "IReadOnlyListEnumerator<TSource>", "TSource", "TSource"),
            ("TSource[]", "ArrayEnumerator<TSource>", "TSource", "TSource"),
            ("HashSet<TSource>", "HashSetEnumerator<TSource>", "TSource", "TSource"),
            ("MultiHashSetWrapper<TSource>", "MultiHashSetWrapperEnumerator<TSource>", "TSource", "TSource"),
            ("Dictionary<TSource1, TSource2>", "DictionaryEnumerator<TSource1, TSource2>", "KeyValuePair<TSource1, TSource2>", "TSource1, TSource2"),
        };

        Console.WriteLine("using System.Collections.Generic;");
        Console.WriteLine("namespace System.Linq.Struct");
        Console.WriteLine("{");
        Console.WriteLine("    public static partial class GeneratedExtensions");
        Console.WriteLine("    {");

        Console.WriteLine($"#region Build");
        foreach (var type in sources)
        {
            Console.WriteLine($"        public static RefLinqEnumerable<{type.Item3}, {type.Item2}> Build<{type.Item4}>({type.Item1} c)");
            Console.WriteLine($"            => new RefLinqEnumerable<{type.Item3}, {type.Item2}>(new {type.Item2}(c));");
        }
        Console.WriteLine($"#endregion");

        Console.WriteLine($"#region Add Where predicate to known finalizers that needs them");
        foreach (var method in new List<(string, string)>{
            ("Count", "int"),
            ("Any", "bool"),
            ("Single", "TResult"),
            ("SingleOrDefault", "TResult"),
            ("First", "TResult"),
            ("FirstOrDefault", "TResult"),
            ("Last", "TResult"),
            ("LastOrDefault", "TResult"),
            ("Max", "TResult"),
            ("Min", "TResult"),
            ("Average", "TResult"),
            ("Sum", "TResult"),
            ("Multiply", "TResult"),
        })
        {
            Console.WriteLine($"        public static {method.Item2.Replace("TResult", "TSource")} {method.Item1}<TSource, TEnumerator>(this RefLinqEnumerable<TSource, TEnumerator> seq, Func<TSource, bool> pred)");
            Console.WriteLine($"            where TEnumerator : IRefEnumerator<TSource>");
            Console.WriteLine($"            => seq.Where(pred).{method.Item1}();");

            foreach (var type in sources)
            {
                Console.WriteLine($"        public static {method.Item2.Replace("TResult", type.Item3)} {method.Item1}<{type.Item4}>(this {type.Item1} c, Func<{type.Item3}, bool> pred)");
                Console.WriteLine($"            => Build(c).{method.Item1}(pred);");
            }
        }
        Console.WriteLine($"#endregion");

        Console.WriteLine($"#region Add basic extensions for known finalizers");
        foreach (var method in new List<(string, string, string, string, string)>{
            ("Count", "int", "", "", ""),
            ("Any", "bool", "", "", ""),
            ("Single", "TResult", "", "", ""),
            ("SingleOrDefault", "TResult", "", "", ""),
            ("First", "TResult", "", "", ""),
            ("FirstOrDefault", "TResult", "", "", ""),
            ("Last", "TResult", "", "", ""),
            ("LastOrDefault", "TResult", "", "", ""),
            ("Max", "TResult", "", "", ""),
            ("Min", "TResult", "", "", ""),
            ("Average", "TResult", "", "", ""),
            ("Sum", "TResult", "", "", ""),
            ("Multiply", "TResult", "", "", ""),
            ("MaxBy", "TResult", ", Func<TInput, TMaxByKey> keySelector", ", TMaxByKey", "keySelector"),
            ("MinBy", "TResult", ", Func<TInput, TMinByKey> keySelector", ", TMinByKey", "keySelector"),
            ("All", "bool", ", Func<TInput, bool> pred", "", "pred"),
            ("Contains", "bool", ", TInput toFind", "", "toFind"),
            ("Aggregate", "TResult", ", Func<TInput, TInput, TInput> agg", "", "agg"),
            ("Aggregate", "TAccumulate", ", TAccumulate acc, Func<TAccumulate, TInput, TAccumulate> agg", ", TAccumulate", "acc, agg"),
        })
        {
            // Original for those methods are locatd in 'Extensions.cs' file
            foreach (var type in sources)
            {
                Console.WriteLine($"        public static {method.Item2.Replace("TResult", type.Item3)} {method.Item1}<{type.Item4}{method.Item4}>(this {type.Item1} c{method.Item3.Replace("TInput", type.Item3)})");
                Console.WriteLine($"            => Build(c).{method.Item1}({method.Item5});");
            }
        }
        Console.WriteLine($"#endregion");

        Console.WriteLine($"#region Add basic extensions for known enumerables");
        foreach (var method in new List<(string, string, string, string, string)>{
            ("Where", "TResult", ", Func<TInput, bool> predicate", "", "predicate"),
            ("Skip", "TResult", ", int skip", "", "skip"),
            ("Take", "TResult", ", int take", "", "take"),
            ("Append", "TResult", ", TInput toAppend", "", "toAppend"),
            ("Prepend", "TResult", ", TInput toPrepend", "", "toPrepend"),
            ("OrderBy", "TResult", ", Func<TInput, TOrderByKey> keySelector", ", TOrderByKey", "keySelector"),
            ("Select", "TOutput", ", Func<TInput, TOutput> map", ", TOutput", "map"),
        })
        {
            Console.WriteLine($"        public static RefLinqEnumerable<{method.Item2.Replace("TResult", "TSource")}, {method.Item1}<TSource, TPrevious{method.Item4}>> {method.Item1}<TSource, TPrevious{method.Item4}>(this RefLinqEnumerable<TSource, TPrevious> prev{method.Item3.Replace("TInput", "TSource")})");
            Console.WriteLine($"            where TPrevious : IRefEnumerator<TSource>");
            Console.WriteLine($"            => new RefLinqEnumerable<{method.Item2.Replace("TResult", "TSource")}, {method.Item1}<TSource, TPrevious{method.Item4}>>(new {method.Item1}<TSource, TPrevious{method.Item4}>(prev.enumerator, {method.Item5}));");

            foreach (var type in sources)
            {
                Console.WriteLine($"        public static RefLinqEnumerable<{method.Item2.Replace("TResult", type.Item3)}, {method.Item1}<{type.Item3}, {type.Item2}{method.Item4}>> {method.Item1}<{type.Item4}{method.Item4}>(this {type.Item1} c{method.Item3.Replace("TInput", type.Item3)})");
                Console.WriteLine($"            => Build(c).{method.Item1}({method.Item5});");
            }
        }
        Console.WriteLine($"#endregion");

        Console.WriteLine($"#region Add basic extensions for known enumerables");

        foreach (var method in new List<(string, string, string, string, string, bool)>{
            ("Concat", "TResult", "RefLinqEnumerable<TInput, TSecondEnumerator>", "TSecondEnumerator", "where TSecondEnumerator : IRefEnumerator<TInput>", false),
            ("Zip", "(TResult, TSecondInput)", "RefLinqEnumerable<TSecondInput, TSecondEnumerator>", "TSecondInput, TSecondEnumerator", "where TSecondEnumerator : IRefEnumerator<TSecondInput>", true),
        })
        {
            Console.WriteLine($"        public static RefLinqEnumerable<{method.Item2.Replace("TResult", "TSource")}, {method.Item1}<TSource, TPrevious, {method.Item4}>> {method.Item1}<TSource, TPrevious, {method.Item4}>(this RefLinqEnumerable<TSource, TPrevious> prev, {method.Item3.Replace("TInput", "TSource")} seq2)");
            Console.WriteLine($"            where TPrevious : IRefEnumerator<TSource> {method.Item5.Replace("TInput", "TSource")}");
            Console.WriteLine($"            => new RefLinqEnumerable<{method.Item2.Replace("TResult", "TSource")}, {method.Item1}<TSource, TPrevious, {method.Item4}>>(new {method.Item1}<TSource, TPrevious, {method.Item4}>(prev.enumerator, seq2));");

            foreach (var type in sources)
            {
                Console.WriteLine($"        public static RefLinqEnumerable<{method.Item2.Replace("TResult", type.Item3)}, {method.Item1}<{type.Item3}, {type.Item2}, {method.Item4}>> {method.Item1}<{type.Item4}, {method.Item4}>(this {type.Item1} c, {method.Item3.Replace("TInput", type.Item3)} seq2)");
                Console.WriteLine($"            {method.Item5.Replace("TInput", type.Item3)}");
                Console.WriteLine($"            => Build(c).{method.Item1}(seq2);");

                foreach (var secondType in sources)
                {
                    string tSecondSourceName;
                    string distinctTypes;
                    if (method.Item6)
                    {
                        tSecondSourceName = "TSecondSource";
                        distinctTypes = $"{type.Item4}, {secondType.Item4.Replace("TSource", tSecondSourceName)}";
                    }
                    else
                    {
                        tSecondSourceName = "TSource";
                        distinctTypes = type.Item4; // no need for secondType as they should be equal.
                    }

                    Console.WriteLine($"        public static RefLinqEnumerable<{method.Item2.Replace("TResult", type.Item3).Replace("TSecondInput", secondType.Item3.Replace("TSource", tSecondSourceName))}, {method.Item1}<{type.Item3}, {type.Item2}, {method.Item4.Replace("TSecondEnumerator", secondType.Item2.Replace("TSource", tSecondSourceName)).Replace("TSecondInput", secondType.Item3.Replace("TSource", tSecondSourceName))}>> {method.Item1}<{distinctTypes}>(this {type.Item1} c, {secondType.Item1.Replace("TSource", tSecondSourceName)} seq2)");
                    Console.WriteLine($"            => Build(c).{method.Item1}(Build(seq2));");
                }
            }
        }
        Console.WriteLine($"#endregion");

        var toMultiSources = new List<Method>();
        var toAddBasicExtension = new List<Method>();

        Console.WriteLine($"#region SelectMany extensions");
        {
            Console.WriteLine($"        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<T, TPrevious, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<T, TPrevious, U, UEnumerator>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, RefLinqEnumerable<U, UEnumerator>> func)");
            Console.WriteLine($"            where TPrevious : IRefEnumerator<T>");
            Console.WriteLine($"            where UEnumerator : IRefEnumerator<U>");
            Console.WriteLine($"            => prev.Select(func).SelectMany();");

            foreach (var type in sources)
            {
                Console.WriteLine($"        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<{type.Item3}, {type.Item2}, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<{type.Item4} ,U,UEnumerator>(this {type.Item1} c ,Func<{type.Item3}, RefLinqEnumerable<U, UEnumerator>> func)");
                Console.WriteLine($"            where UEnumerator : IRefEnumerator<U>");
                Console.WriteLine($"            => Build(c).SelectMany(func);");

                Console.WriteLine($"        public static RefLinqEnumerable<{type.Item3.Replace("T", "U")}, SelectMany<{type.Item3.Replace("T", "U")}, {type.Item2.Replace("T", "U")}, Select<{type.Item1.Replace("T", "U")}, Select<T, TPrevious, {type.Item1.Replace("T", "U")}>, RefLinqEnumerable<{type.Item3.Replace("T", "U")}, {type.Item2.Replace("T", "U")}>>>> SelectMany<T, TPrevious, {type.Item4.Replace("T", "U")}>(this RefLinqEnumerable<T, TPrevious> prev, Func<T, {type.Item1.Replace("T", "U")}> func)");
                Console.WriteLine($"            where TPrevious : IRefEnumerator<T>");
                Console.WriteLine($"            => prev.Select(func).Select(a => Build(a)).SelectMany();");

                foreach (var secondType in sources)
                {
                    Console.WriteLine($"        public static RefLinqEnumerable<{type.Item3.Replace("T", "U")}, SelectMany<{type.Item3.Replace("T", "U")}, {type.Item2.Replace("T", "U")}, Select<{type.Item1.Replace("T", "U")}, Select<{secondType.Item3}, {secondType.Item2}, {type.Item1.Replace("T", "U")}>, RefLinqEnumerable<{type.Item3.Replace("T", "U")}, {type.Item2.Replace("T", "U")}>>>> SelectMany<{secondType.Item4}, {type.Item4.Replace("T", "U")}>(this {secondType.Item1} prev, Func<{secondType.Item3}, {type.Item1.Replace("T", "U")}> func)");
                    Console.WriteLine($"            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();");
                }
            }
        }
        Console.WriteLine($"#endregion");

        Console.WriteLine("    }");
        Console.WriteLine("}");
    }
}