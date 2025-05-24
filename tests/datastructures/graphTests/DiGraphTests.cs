using Xunit;
using System.Linq;
using DataStructures.Graph.AdjancencySet;

namespace Tests.Graph.DiGraphTests;

public class GraphTests
{
    [Fact]
    public void Edges_ShouldReturnConnectedVertices()
    {
        // Arrange
        var graph = new Graph<string>();
        graph.AddVertex("A");
        graph.AddVertex("B");
        graph.AddVertex("C");

        graph.AddEdge("A", "B");
        graph.AddEdge("A", "C");

        // Act
        var connectedVertices = graph.Edges("A").ToList();

        // Assert
        Assert.Contains("B", connectedVertices);
        Assert.Contains("C", connectedVertices);
        Assert.Equal(2, connectedVertices.Count);
    }
}
