using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Program
{
    private static List<(string, string, string, string)> sources = new List<(string, string, string, string)>{
        ("IReadOnlyList<TSource>", "IReadOnlyListEnumerator<TSource>", "TSource", "TSource"),
        ("TSource[]", "ArrayEnumerator<TSource>", "TSource", "TSource"),
        ("HashSet<TSource>", "HashSetEnumerator<TSource>", "TSource", "TSource"),
        ("MultiHashSetWrapper<TSource>", "MultiHashSetWrapperEnumerator<TSource>", "TSource", "TSource"),
        ("Dictionary<TSource1, TSource2>", "DictionaryEnumerator<TSource1, TSource2>", "KeyValuePair<TSource1, TSource2>", "TSource1, TSource2"),
        ("MultiDictionaryWrapper<TSource1, TSource2>", "MultiDictionaryWrapperEnumerator<TSource1, TSource2>", "KeyValuePair<TSource1, TSource2>", "TSource1, TSource2"),
    };

    private static StringBuilder extensions = new StringBuilder();

    private static StringBuilder methods = new StringBuilder();

    private static void Main(string[] args)
    {
        foreach (var type in sources)
        {
            extensions.AppendLine($"        public static RefLinqEnumerable<{type.Item3}, {type.Item2}> Build<{type.Item4}>({type.Item1} c)");
            extensions.AppendLine($"            => new RefLinqEnumerable<{type.Item3}, {type.Item2}>(new {type.Item2}(c));");
        }

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
            methods.AppendLine($"        public {method.Item2.Replace("TResult", "TSource")} {method.Item1}(Func<TSource, bool> pred)");
            methods.AppendLine($"            => this.Where(pred).{method.Item1}();");

            foreach (var type in sources)
            {
                extensions.AppendLine($"        public static {method.Item2.Replace("TResult", type.Item3)} {method.Item1}<{type.Item4}>(this {type.Item1} c, Func<{type.Item3}, bool> pred)");
                extensions.AppendLine($"            => Build(c).{method.Item1}(pred);");
            }
        }

        foreach (var method in new List<(string, string, string, string, string)>{
            ("ToList", "List<TResult>", "", "", ""),
            ("ToList", "List<TResult>", ", List<TInput> list", "", "list"),
            ("ToArray", "TResult[]", "", "", ""),
            ("ToArray", "TResult[]", ", List<TInput> list", "", "list"),
            ("ToHashSet", "HashSet<TResult>", "", "", ""),
            ("ToHashSet", "HashSet<TResult>", ", HashSet<TInput> set", "", "set"),
            ("ToDictionary", "Dictionary<TKey, TResult>", ", Func<TInput, TKey> keySelector", ", TKey", "keySelector"),
            ("ToDictionary", "Dictionary<TKey, TResult>", ", Func<TInput, TKey> keySelector, Dictionary<TKey, TInput> dict", ", TKey", "keySelector, dict"),
            ("ToDictionary", "Dictionary<TKey, TValue>", ", Func<TInput, TKey> keySelector, Func<TInput, TValue> valueSelector", ", TKey, TValue", "keySelector, valueSelector"),
            ("ToDictionary", "Dictionary<TKey, TValue>", ", Func<TInput, TKey> keySelector, Func<TInput, TValue> valueSelector, Dictionary<TKey, TValue> dict", ", TKey, TValue", "keySelector, valueSelector, dict"),
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
                extensions.AppendLine($"        public static {method.Item2.Replace("TResult", type.Item3)} {method.Item1}<{type.Item4}{method.Item4}>(this {type.Item1} c{method.Item3.Replace("TInput", type.Item3)})");
                extensions.AppendLine($"            => Build(c).{method.Item1}({method.Item5});");
            }
        }

        foreach (var method in new List<(string, string, string, string, string)>{
            ("Where", "TResult", "Func<TInput, bool> predicate", "", "predicate"),
            ("Skip", "TResult", "int skip", "", "skip"),
            ("Take", "TResult", "int take", "", "take"),
            ("Reverse", "TResult", "", "", ""),
            ("Append", "TResult", "TInput toAppend", "", "toAppend"),
            ("Repeat", "TResult", "int times", "", "times"),
            ("Prepend", "TResult", "TInput toPrepend", "", "toPrepend"),
            ("OrderBy", "TResult", "Func<TInput, TOrderByKey> keySelector", "TOrderByKey", "keySelector"),
            ("DistinctBy", "TResult", "Func<TInput, TDistinctByKey> keySelector", "TDistinctByKey", "keySelector"),
            ("Distinct", "TResult", "", "", ""),
            ("Select", "TOutput", "Func<TInput, TOutput> map", "TOutput", "map"),
            ("Cast", "TOutput", "", "TOutput", ""),
            ("OfType", "TOutput", "", "TOutput", ""),
        })
        {
            var methodParameters = (string.IsNullOrWhiteSpace(method.Item5) ? "" : ", ") + method.Item5;
            var methodArguments = (string.IsNullOrWhiteSpace(method.Item3) ? "" : ", ") + method.Item3;
            var genericParameters = (string.IsNullOrWhiteSpace(method.Item4) ? "" : ", ") + method.Item4;
            var genericFullParameters = (string.IsNullOrWhiteSpace(method.Item4) ? "" : "<") + method.Item4+(string.IsNullOrWhiteSpace(method.Item4) ? "" : ">");

            methods.AppendLine($"        public RefLinqEnumerable<{method.Item2.Replace("TResult", "TSource")}, {method.Item1}<TSource, TPrevious{genericParameters}>> {method.Item1}{genericFullParameters}({method.Item3.Replace("TInput", "TSource")})");
            methods.AppendLine($"            => new RefLinqEnumerable<{method.Item2.Replace("TResult", "TSource")}, {method.Item1}<TSource, TPrevious{genericParameters}>>(new {method.Item1}<TSource, TPrevious{genericParameters}>(this.enumerator{methodParameters}));");

            foreach (var type in sources)
            {
                extensions.AppendLine($"        public static RefLinqEnumerable<{method.Item2.Replace("TResult", type.Item3)}, {method.Item1}<{type.Item3}, {type.Item2}{genericParameters}>> {method.Item1}<{type.Item4}{genericParameters}>(this {type.Item1} c{methodArguments.Replace("TInput", type.Item3)})");
                extensions.AppendLine($"            => Build(c).{method.Item1}{genericFullParameters}({method.Item5});");
            }
        }

        foreach (var method in new List<(string, string, string, string, string, bool)>{
            ("Concat", "TResult", "RefLinqEnumerable<TInput, TSecondEnumerator>", "TSecondEnumerator", "where TSecondEnumerator : IRefEnumerator<TInput>", false),
            ("Zip", "(TResult, TSecondInput)", "RefLinqEnumerable<TSecondInput, TSecondEnumerator>", "TSecondInput, TSecondEnumerator", "where TSecondEnumerator : IRefEnumerator<TSecondInput>", true),
        })
        {
            methods.AppendLine($"        public RefLinqEnumerable<{method.Item2.Replace("TResult", "TSource")}, {method.Item1}<TSource, TPrevious, {method.Item4}>> {method.Item1}<{method.Item4}>({method.Item3.Replace("TInput", "TSource")} seq2)");
            methods.AppendLine($"            {method.Item5.Replace("TInput", "TSource")}");
            methods.AppendLine($"            => new RefLinqEnumerable<{method.Item2.Replace("TResult", "TSource")}, {method.Item1}<TSource, TPrevious, {method.Item4}>>(new {method.Item1}<TSource, TPrevious, {method.Item4}>(this.enumerator, seq2));");

            foreach (var type in sources)
            {
                extensions.AppendLine($"        public static RefLinqEnumerable<{method.Item2.Replace("TResult", type.Item3)}, {method.Item1}<{type.Item3}, {type.Item2}, {method.Item4}>> {method.Item1}<{type.Item4}, {method.Item4}>(this {type.Item1} c, {method.Item3.Replace("TInput", type.Item3)} seq2)");
                extensions.AppendLine($"            {method.Item5.Replace("TInput", type.Item3)}");
                extensions.AppendLine($"            => Build(c).{method.Item1}(seq2);");

                foreach (var secondType in sources)
                {
                    if ((type.Item4 == "TSource1, TSource2" || secondType.Item4 == "TSource1, TSource2") && type.Item4 != secondType.Item4)
                    {
                        extensions.AppendLine($"// TODO: Dictionary not supported for {method.Item1}.");
                        continue;
                    }

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

                    extensions.AppendLine($"        public static RefLinqEnumerable<{method.Item2.Replace("TResult", type.Item3).Replace("TSecondInput", secondType.Item3.Replace("TSource", tSecondSourceName))}, {method.Item1}<{type.Item3}, {type.Item2}, {method.Item4.Replace("TSecondEnumerator", secondType.Item2.Replace("TSource", tSecondSourceName)).Replace("TSecondInput", secondType.Item3.Replace("TSource", tSecondSourceName))}>> {method.Item1}<{distinctTypes}>(this {type.Item1} c, {secondType.Item1.Replace("TSource", tSecondSourceName)} seq2)");
                    extensions.AppendLine($"            => Build(c).{method.Item1}(Build(seq2));");
                }
            }
        }

        {
            methods.AppendLine($"        public RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<TSource, TPrevious, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<U, UEnumerator>(Func<TSource, RefLinqEnumerable<U, UEnumerator>> func)");
            methods.AppendLine($"            where UEnumerator : IRefEnumerator<U>");
            methods.AppendLine($"            => this.Select(func).SelectMany();");

            foreach (var type in sources)
            {
                extensions.AppendLine($"        public static RefLinqEnumerable<U, SelectMany<U, UEnumerator, Select<{type.Item3}, {type.Item2}, RefLinqEnumerable<U, UEnumerator>>>> SelectMany<{type.Item4} ,U,UEnumerator>(this {type.Item1} c ,Func<{type.Item3}, RefLinqEnumerable<U, UEnumerator>> func)");
                extensions.AppendLine($"            where UEnumerator : IRefEnumerator<U>");
                extensions.AppendLine($"            => Build(c).SelectMany(func);");

                methods.AppendLine($"        public RefLinqEnumerable<{type.Item3.Replace("T", "U")}, SelectMany<{type.Item3.Replace("T", "U")}, {type.Item2.Replace("T", "U")}, Select<{type.Item1.Replace("T", "U")}, Select<TSource, TPrevious, {type.Item1.Replace("T", "U")}>, RefLinqEnumerable<{type.Item3.Replace("T", "U")}, {type.Item2.Replace("T", "U")}>>>> SelectMany<{type.Item4.Replace("T", "U")}>(Func<TSource, {type.Item1.Replace("T", "U")}> func)");
                methods.AppendLine($"            => this.Select(func).Select(a => GeneratedExtensions.Build(a)).SelectMany();");

                foreach (var secondType in sources)
                {
                    extensions.AppendLine($"        public static RefLinqEnumerable<{type.Item3.Replace("T", "U")}, SelectMany<{type.Item3.Replace("T", "U")}, {type.Item2.Replace("T", "U")}, Select<{type.Item1.Replace("T", "U")}, Select<{secondType.Item3}, {secondType.Item2}, {type.Item1.Replace("T", "U")}>, RefLinqEnumerable<{type.Item3.Replace("T", "U")}, {type.Item2.Replace("T", "U")}>>>> SelectMany<{secondType.Item4}, {type.Item4.Replace("T", "U")}>(this {secondType.Item1} prev, Func<{secondType.Item3}, {type.Item1.Replace("T", "U")}> func)");
                    extensions.AppendLine($"            => Build(prev).Select(func).Select(a => Build(a)).SelectMany();");
                }
            }
        }

        Console.WriteLine("using System.Collections.Generic;");
        Console.WriteLine("using System;");
        Console.WriteLine("");
        Console.WriteLine("namespace System.Linq.Struct");
        Console.WriteLine("{");
        Console.WriteLine("    public static partial class GeneratedExtensions");
        Console.WriteLine("    {");
        Console.WriteLine(extensions.ToString());
        Console.WriteLine("    }");
        Console.WriteLine("    public partial struct RefLinqEnumerable<TSource, TPrevious>");
        Console.WriteLine("    {");
        Console.WriteLine(methods.ToString());
        Console.WriteLine("    }");
        Console.WriteLine("}");
    }
}