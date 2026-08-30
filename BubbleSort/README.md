# Sorting Algorithms

Five classic sorting algorithms applied to the same array, so their
output — and their cost — can be compared directly.

## Complexity

| Algorithm      | Time (best) | Time (average) | Time (worst) | Space    |
|----------------|-------------|-----------------|--------------|----------|
| Bubble Sort    | O(n²)¹      | O(n²)           | O(n²)        | O(1)     |
| Selection Sort | O(n²)       | O(n²)           | O(n²)        | O(1)     |
| Insertion Sort | O(n)        | O(n²)           | O(n²)        | O(1)     |
| Merge Sort     | O(n log n)  | O(n log n)      | O(n log n)   | O(n)     |
| Quick Sort     | O(n log n)  | O(n log n)      | O(n²)        | O(log n) average, O(n) worst |

¹ This implementation has no early-exit on an already-sorted pass, so
Bubble Sort is always O(n²) here, even on sorted input.

## Run

```bash
dotnet run --project BubbleSort
```
