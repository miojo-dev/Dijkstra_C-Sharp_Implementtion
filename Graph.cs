using System.Runtime.InteropServices.JavaScript;

namespace Dijkstra_C_Sharp_Implementation;

public class Graph
{
    private string Name { get; }
    private int Degree { get; }
    private Vertex[] Connections { get; }

    public Graph(string name, int degree)
    {
        this.Name = name;
        this.Degree = degree;
        Connections = new Vertex[this.Degree];
    }

    public bool TryAddConnection(string name, Graph connectedGraph, int distance)
    {
        for (var i = 0; i < Connections.Length; i++)
        {
            if (Connections[i].GetName() == string.Empty)
            {
                Connections[i] = new Vertex(name, connectedGraph, distance);
                return true;
            }
        }

        return false;
    }

    public Vertex? TryFindVertex(string name)
    {
        for (var i = 0; i < Connections.Length; i++)
        {
            if (Connections[i].GetName() == name)
            {
                return Connections[i];
            }
        }

        return null;
    }

    public string GetName() => Name;
    public int GetDegree() => Degree;
    public Vertex[] GetConnections() => Connections;
}