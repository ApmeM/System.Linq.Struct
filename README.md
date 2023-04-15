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
            .Select(c => c + 5)
            .Where(c => c % 2 == 0)
            .Select(c => c - 6.0 / localVar)
            .Append(3)
            .Append(5)
            .Prepend(3)
            .OrderBy(a => a)
            .Skip(2)
            .Take(10)
            .Concat(arr.Select(c => c / 1d));
        Assert.Equal(33.4, seq.Sum() + seq.Max());
```

## Why to use

Benefits over upstream library:

- Do not have any external dependencies
- No need for ToRefLinq method - just replace 'using' to System.Linq.Struct and it will work out of the box
- More methods available (including those that requires inner allocation)
- Has wrappers for reusing same pre-built query fordifferent original data (of the same list type)

Benefits over classic Linq:

- Zero allocations for methods that do not require inner data storage
- Improved performance (benchamrk data can be checked on upstream readme)
- Allows to cast value types array (e.g. this code will not fail: `int[]{1,2,3}.Cast<int, double>().sum())`

## Similar Libraries

- [HonkPerf.NET](https://github.com/asc-community/HonkPerf.NET)
- [Hyperlinq](https://github.com/NetFabric/NetFabric.Hyperlinq)
- [LinqFaster](https://github.com/jackmott/LinqFaster)
- [ValueLinq](https://github.com/manofstick/Cistern.ValueLinq)
- [LinqAF](https://github.com/kevin-montrose/LinqAF)
- [NoAlloq](https://github.com/VictorNicollet/NoAlloq)
- [StructLinq](https://github.com/reegeek/StructLinq)
- [LinqGen](https://github.com/cathei/LinqGen)

