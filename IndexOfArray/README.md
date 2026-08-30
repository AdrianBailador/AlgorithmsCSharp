# IndexOfArray

Searches an array for a target value, scanning outward from the
middle (right half first, then left half) until it is found.

## Complexity

- **Time:** O(n) worst case — the array isn't sorted, so this can't do
  better than a linear scan despite starting from the middle.
- **Space:** O(1)

## Run

```bash
dotnet run --project IndexOfArray
```
