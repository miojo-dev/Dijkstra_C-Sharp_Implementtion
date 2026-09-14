namespace Dijkstra_C_Sharp_Implementation;

public readonly struct Edge(string name, Vertex connection, int distance)
{
    private string Name { get; } = name;
    private unsafe Vertex Next { get; } = connection;
    private int Distance { get; } = distance;

    public string GetName() => Name;
    public Vertex GetEnd() => Next;
    public int GetDistance() => Distance;
}