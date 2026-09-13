using System.Runtime.InteropServices.JavaScript;

namespace Dijkstra_C_Sharp_Implementation;

public class Vertex
{
    private string Name { get; }
    private int Degree { get; }
    private Edge[] Connections { get; }

    public Vertex(string name, int degree)
    {
        this.Name = name;
        this.Degree = degree;
        Connections = new Edge[this.Degree];
    }

    public bool TryAddConnection(string name, Vertex connectedGraph, int distance)
    {
        for (var i = 0; i < Connections.Length; i++)
        {
            if (Connections[i].GetName() == string.Empty)
            {
                Connections[i] = new Edge(name, connectedGraph, distance);
                return true;
            }
        }

        return false;
    }

    public Edge? TryFindVertex(string name)
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
    public Edge[] GetConnections() => Connections;
}