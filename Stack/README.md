# Stack

A LIFO (last-in, first-out) stack backed by a resizable array.

## Complexity

| Operation | Time | Notes |
|-----------|------|-------|
| `Push`    | O(1) amortized | O(n) on the (rare) resize. |
| `Pop`     | O(1) | |
| `Peek`    | O(1) | |

- **Space:** O(n) for n elements.

## Run

```bash
dotnet run --project Stack
```
