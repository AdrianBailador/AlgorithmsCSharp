# LinkedList

A generic singly linked list supporting append, remove and lookup.

## Complexity

| Operation | Time | Notes |
|-----------|------|-------|
| `AddLast` | O(n) | Walks to the tail — there's no tail pointer. |
| `Remove`  | O(n) | Scans for the first matching value. |
| `Contains`| O(n) | Scans until found or the list ends. |

- **Space:** O(n) for n elements.

## Run

```bash
dotnet run --project LinkedList
```
