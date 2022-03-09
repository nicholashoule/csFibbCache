<img align="right" width="256px" src="https://raw.githubusercontent.com/nicholashoule/img/master/me.svg">

![.NET Core Format](https://github.com/nicholashoule/csFibbCache/workflows/.NET%20Core%20Format/badge.svg?branch=master)
![.NET Core Build](https://github.com/nicholashoule/csFibbCache/workflows/.NET%20Core%20Build/badge.svg?branch=master)
[![Run on Repl.it](https://repl.it/badge/github/nicholashoule/csFibbCache)](https://repl.it/github/nicholashoule/csFibbCache)

# Classic C# recursive fibonacci example

Example of speeding up C# recursive function calls using cache.

##### Pure recursive method scales as exp(N)

C# recursion is quite slow to increase performance create and use a cache.

| **int**              | **long**                       | **decimal**                              |
| -------------------- | ------------------------------ | ---------------------------------------- |
| Max: 2147483647      | Max: 9223372036854775807       | Max: 79228162514264337593543950335       |
| Fibb(46): 1836311903 | Fibb(92): 7540113804746346429  | Fibb(139): 50095301248058391139327916261 |
| Fibb(47): 2971215073 | Fibb(93): -6246583658587674878 | Fibb(140): -1 (decimal.MaxValue)         |

### Integral numeric types (C# reference)

[C# reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

| **C# type/keyword** | **Range**                                               | **Size**                          | **.NET type**  |
| ------------------- | ------------------------------------------------------- | --------------------------------- | -------------- |
| sbyte               | -128 to 127                                             | Signed 8-bit integer              | System.SByte   |
| byte                | 0 to 255                                                | Unsigned 8-bit integer            | System.Byte    |
| short               | -32,768 to 32,767                                       | Signed 16-bit integer             | System.Int16   |
| ushort              | 0 to 65,535                                             | Unsigned 16-bit integer           | System.UInt16  |
| int                 | -2,147,483,648 to 2,147,483,647                         | Signed 32-bit integer             | System.Int32   |
| uint                | 0 to 4,294,967,295                                      | Unsigned 32-bit integer           | System.UInt32  |
| long                | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | Signed 64-bit integer             | System.Int64   |
| ulong               | 0 to 18,446,744,073,709,551,615                         | Unsigned 64-bit integer           | System.UInt64  |
| nint                | Depends on platform                                     | Signed 32-bit or 64-bit integer   | System.IntPtr  |
| nuint               | Depends on platform                                     | Unsigned 32-bit or 64-bit integer | System.UIntPtr |

### Floating-point numeric types (C# reference)

[C# reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)

| **C# type/keyword** | **Approximate range**          | **Precision** | **Size** | **.NET type**  |
| ------------------- | ------------------------------ | ------------- | -------- | -------------- |
| float               | ±1.5 x 10−45 to ±3.4 x 1038    | ~6-9 digits   | 4 bytes  | System.Single  |
| double              | ±5.0 × 10−324 to ±1.7 × 10308  | ~15-17 digits | 8 bytes  | System.Double  |
| decimal             | ±1.0 x 10-28 to ±7.9228 x 1028 | 28-29 digits  | 16 bytes | System.Decimal |

### Versions:

dotnet 3.1+

##### Run the code:

https://repl.it/@NicholasHoule/csFibbCache
