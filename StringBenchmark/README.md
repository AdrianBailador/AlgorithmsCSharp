# StringBenchmark

Benchmarks three ways of building a string through repeated
concatenation.

## Complexity

| Approach               | Time    | Why |
|-------------------------|---------|-----|
| `string + string`       | O(n²)   | Each concatenation allocates a new string and copies everything so far. |
| `string.Concat()`       | O(n²)   | Same underlying cost as `+` for repeated calls in a loop. |
| `StringBuilder.Append()`| O(n) amortized | Grows an internal resizable buffer instead of reallocating every time. |

- **Space:** O(n) for the final string in all three cases, but the two
  O(n²) approaches also generate O(n) intermediate throwaway strings
  along the way.

## Run

```bash
dotnet run --project StringBenchmark
```
