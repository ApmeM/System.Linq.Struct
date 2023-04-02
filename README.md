# System.Linq.Struct

Collection of performant (but limited in usage) replacements for BCL's types and methods;

## Summary

System.Linq.Struct from a consumer perspective works like BCL Linq. Its difference and benefit - it does not make allocations for enumerators. 

## Example

```cs
        var arr = new[] { 1, 2, 3, 4 };

        var localVar = 5;

        var seq =
            arr
            .ToRefLinq()
            .Select(c => c + 5)
            .Where(c => c % 2 == 0)
            .Select(c => c - 6.0 / localVar)
            .Append(3)
            .Append(5)
            .Prepend(3)
            .OrderBy(a => a)
            .Skip(2)
            .Take(10)
            .Concat(arr.ToRefLinq().Select(c => c / 1d));
        Assert.Equal(33.4, seq.Sum() + seq.Max());
```

## Similar Libraries

- [HonkPerf.NET](https://github.com/asc-community/HonkPerf.NET)
- [Hyperlinq](https://github.com/NetFabric/NetFabric.Hyperlinq)
- [LinqFaster](https://github.com/jackmott/LinqFaster)
- [ValueLinq](https://github.com/manofstick/Cistern.ValueLinq)
- [LinqAF](https://github.com/kevin-montrose/LinqAF)
- [NoAlloq](https://github.com/VictorNicollet/NoAlloq)
- [StructLinq](https://github.com/reegeek/StructLinq)
- [LinqGen](https://github.com/cathei/LinqGen)

