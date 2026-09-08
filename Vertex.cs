namespace Dijkstra_C_Sharp_Implementation;

public struct Vertex
{
    private string Name { get; }
    private unsafe Graph* _next { get; }
    private int Distance { get; }

    public unsafe Vertex(string name, Graph connection, int distance)
    {
        Name = name;
        _next = &connection;
        Distance = distance;
    }

    public string GetName() => Name;
    public unsafe Graph* GetEnd() => _next;
    public int GetDistance() => Distance;
}