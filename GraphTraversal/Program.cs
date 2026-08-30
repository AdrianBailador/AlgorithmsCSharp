using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphTraversalAlgorithm
{
    public class Graph
    {
        private readonly Dictionary<int, List<int>> _adjacency = new();

        public void AddEdge(int u, int v)
        {
            AddDirectedEdge(u, v);
            AddDirectedEdge(v, u);
        }

        private void AddDirectedEdge(int from, int to)
        {
            if (!_adjacency.TryGetValue(from, out List<int>? neighbors))
            {
                neighbors = new List<int>();
                _adjacency[from] = neighbors;
            }
            neighbors.Add(to);
        }

        public List<int> Bfs(int start)
        {
            var visited = new HashSet<int> { start };
            var order = new List<int>();
            var queue = new Queue<int>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                order.Add(current);

                foreach (int neighbor in GetNeighbors(current))
                {
                    if (visited.Add(neighbor))
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return order;
        }

        public List<int> Dfs(int start)
        {
            var visited = new HashSet<int>();
            var order = new List<int>();
            DfsVisit(start, visited, order);
            return order;
        }

        private void DfsVisit(int node, HashSet<int> visited, List<int> order)
        {
            if (!visited.Add(node)) return;
            order.Add(node);

            foreach (int neighbor in GetNeighbors(node))
            {
                DfsVisit(neighbor, visited, order);
            }
        }

        private IEnumerable<int> GetNeighbors(int node)
        {
            return _adjacency.TryGetValue(node, out List<int>? neighbors) ? neighbors : Enumerable.Empty<int>();
        }
    }

    public class Program
    {
        public static void Main()
        {
            var graph = new Graph();
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 5);

            Console.WriteLine("BFS from 1: " + string.Join(", ", graph.Bfs(1)));
            Console.WriteLine("DFS from 1: " + string.Join(", ", graph.Dfs(1)));
        }
    }
}
