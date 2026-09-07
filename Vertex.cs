namespace Dijkstra_C_Sharp_Implementation;

public struct Vertex
{
    private string Name { get; }
    private unsafe Graph* _end { get; }
    private int Distance { get; }

    public unsafe Vertex(string name, Graph connection, int distance)
    {
        Name = name;
        _end = &connection;
        Distance = distance;
    }
}