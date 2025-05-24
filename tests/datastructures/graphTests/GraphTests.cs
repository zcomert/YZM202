
using DataStructures.Graph.AdjancencySet;

namespace Tests.Graph.GraphTests;

public class GraphTests
{
    [Fact]
    public void Graph_Smoke_Test()
    {
        var graph = new Graph<int>();

        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddVertex(4);
        graph.AddVertex(5);

        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        graph.AddEdge(4, 1);
        graph.AddEdge(3, 5);

        Assert.Equal(3, graph.Edges(4).Count());

        Assert.Equal(5, graph.Count);

        Assert.True(graph.HasEdge(1, 2));

        graph.RemoveEdge(1, 2);

        Assert.False(graph.HasEdge(1, 2));

        graph.RemoveEdge(2, 3);
        graph.RemoveEdge(3, 4);
        graph.RemoveEdge(4, 5);
        graph.RemoveEdge(4, 1);


        Assert.True(graph.HasEdge(3, 5));
        graph.RemoveEdge(3, 5);
        Assert.False(graph.HasEdge(3, 5));

        graph.RemoveVertex(1);
        graph.RemoveVertex(2);
        graph.RemoveVertex(3);
        graph.RemoveVertex(4);

        graph.AddEdge(5, 5);
        graph.RemoveEdge(5, 5);
        graph.RemoveVertex(5);

        Assert.Equal(0, graph.Count);
    }

    [Fact]
    public void AddVertex_ShouldIncreaseVertexCount()
    {
        var graph = new Graph<string>();
        graph.AddVertex("A");
        Assert.Equal(1, graph.Count);
    }

    [Fact]
    public void AddEdge_ShouldConnectVertices()
    {
        var graph = new Graph<string>();
        graph.AddVertex("A");
        graph.AddVertex("B");

        graph.AddEdge("A", "B");

        Assert.True(graph.HasEdge("A", "B"));
    }

    [Fact]
    public void AddEdge_Twice_ShouldThrowException()
    {
        var graph = new Graph<string>();
        graph.AddVertex("A");
        graph.AddVertex("B");
        graph.AddEdge("A", "B");

        var ex = Assert.Throws<Exception>(() => graph.AddEdge("A", "B"));
        Assert.Equal("The edge has been already defined!", ex.Message);
    }

    [Fact]
    public void RemoveEdge_ShouldDisconnectVertices()
    {
        var graph = new Graph<string>();
        graph.AddVertex("A");
        graph.AddVertex("B");
        graph.AddEdge("A", "B");

        graph.RemoveEdge("A", "B");

        Assert.False(graph.HasEdge("A", "B"));
    }

    [Fact]
    public void RemoveEdge_ThatDoesNotExist_ShouldThrow()
    {
        var graph = new Graph<string>();
        graph.AddVertex("A");
        graph.AddVertex("B");

        var ex = Assert.Throws<Exception>(() => graph.RemoveEdge("A", "B"));
        Assert.Equal("The edge does not exists.", ex.Message);
    }

    [Fact]
    public void RemoveVertex_ShouldRemoveItFromGraph()
    {
        var graph = new Graph<string>();
        graph.AddVertex("A");
        graph.AddVertex("B");
        graph.AddEdge("A", "B");

        graph.RemoveVertex("A");

        Assert.False(graph.ContainsVertex("A"));
        Assert.DoesNotContain("A", graph.Edges("B"));
    }


    [Fact]
    public void GetVertex_ShouldReturnCorrectVertex()
    {
        var graph = new Graph<string>();
        graph.AddVertex("X");

        var vertex = graph.GetVertex("X");

        Assert.NotNull(vertex);
        Assert.Equal("X", vertex.Key);
    }

    [Fact]
    public void Edges_ShouldReturnConnectedVertices()
    {
        var graph = new Graph<string>();
        graph.AddVertex("A");
        graph.AddVertex("B");
        graph.AddVertex("C");
        graph.AddEdge("A", "B");
        graph.AddEdge("A", "C");

        var edges = graph.Edges("A").ToList();

        Assert.Contains("B", edges);
        Assert.Contains("C", edges);
        Assert.Equal(2, edges.Count);
    }

}
