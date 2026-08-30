# DataTypeChecker

Looks up the memory size, minimum and maximum value of a C# primitive
type by name (e.g. `int`, `float`, `decimal`).

## Complexity

- **Time:** O(1) per lookup — backed by a `Dictionary`.
- **Space:** O(1) — the lookup table has a fixed number of entries.

## Run

```bash
dotnet run --project DataTypeChecker
```
