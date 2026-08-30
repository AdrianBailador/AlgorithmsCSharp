# DynamicProgramming

Two classic dynamic programming problems: Fibonacci with memoization,
and the 0/1 Knapsack problem solved bottom-up.

## Complexity

| Algorithm             | Time      | Space     | Notes |
|------------------------|-----------|-----------|-------|
| Fibonacci (memoized)   | O(n)      | O(n)      | Cache plus recursion stack, versus O(2ⁿ) for the naive recursive version. |
| 0/1 Knapsack           | O(n × W)  | O(n × W)  | n = number of items, W = knapsack capacity. |

## Run

```bash
dotnet run --project DynamicProgramming
```
