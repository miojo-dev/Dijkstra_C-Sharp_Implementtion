namespace Dijkstra_C_Sharp_Implementation;

public class Vertex
{
    private string Name { get; }
    private int Degree { get; }
    public unsafe Vertex*[] Connections;
    public unsafe Vertex* ClosestVertex = null;
    public int Weight = GraphManager.BlockedPathCost;

    public unsafe Vertex(string name, int degree)
    {
        this.Name = name;
        this.Degree = degree;
        Connections = new Vertex*[this.Degree];
    }

    public unsafe bool TryAddConnection(Vertex connectedGraph)
    {
        for (var i = 0; i < Connections.Length; i++)
        {
            if (Connections[i] != null)
            {
                Connections[i] = &connectedGraph;
                return true;
            }
        }

        return false;
    }

    public string GetName() => Name;
    public int GetDegree() => Degree;
}