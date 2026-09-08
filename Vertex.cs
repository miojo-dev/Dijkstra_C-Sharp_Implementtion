namespace Dijkstra_C_Sharp_Implementation;

public struct Vertex
{
    private string Name { get; }
    private unsafe Graph* Next { get; }
    private int Distance { get; }

    public unsafe Vertex(string name, Graph connection, int distance)
    {
        Name = name;
        Next = &connection;
        Distance = distance;
    }

    public string GetName() => Name;
    public unsafe Graph* GetEnd() => Next;
    public int GetDistance() => Distance;
}