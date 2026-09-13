namespace Dijkstra_C_Sharp_Implementation;

public struct Edge
{
    private string Name { get; }
    private unsafe Vertex* Next { get; }
    private int Distance { get; }

    public unsafe Edge(string name, Vertex connection, int distance)
    {
        Name = name;
        Next = &connection;
        Distance = distance;
    }

    public string GetName() => Name;
    public unsafe Vertex* GetEnd() => Next;
    public int GetDistance() => Distance;
}