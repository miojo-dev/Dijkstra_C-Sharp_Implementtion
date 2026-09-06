namespace Dijkstra_C_Sharp_Implementation;

public class Vertex
{
    private unsafe Graph* _prev;
    private unsafe Graph* _next;
    private string Name { get; }

    public unsafe Vertex(string name, Graph* origin, Graph* end)
    {
        this.Name = name;
        _prev = origin;
        _next = end;
    }
}