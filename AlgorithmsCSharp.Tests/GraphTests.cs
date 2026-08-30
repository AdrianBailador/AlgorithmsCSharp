using GraphTraversalAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class GraphTests
{
    private static Graph BuildSampleGraph()
    {
        var graph = new Graph();
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        return graph;
    }

    [Fact]
    public void Bfs_VisitsNodesLevelByLevel()
    {
        var graph = BuildSampleGraph();
        Assert.Equal(new[] { 1, 2, 3, 4, 5 }, graph.Bfs(1));
    }

    [Fact]
    public void Dfs_VisitsNodesDepthFirst()
    {
        var graph = BuildSampleGraph();
        Assert.Equal(new[] { 1, 2, 4, 3, 5 }, graph.Dfs(1));
    }

    [Fact]
    public void Bfs_OnlyVisitsReachableNodes()
    {
        var graph = new Graph();
        graph.AddEdge(1, 2);
        graph.AddEdge(3, 4);

        Assert.Equal(new[] { 1, 2 }, graph.Bfs(1));
    }

    [Fact]
    public void Bfs_SingleNodeWithNoEdges_ReturnsOnlyItself()
    {
        var graph = new Graph();
        Assert.Equal(new[] { 7 }, graph.Bfs(7));
    }
}
