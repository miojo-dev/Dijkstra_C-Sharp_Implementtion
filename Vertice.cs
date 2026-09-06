namespace Dijkstra_C_Sharp_Implementation;

public class Vertice
{
    private unsafe Graph* _prev;
    private unsafe Graph* _next;
    private string Name { get; }

    public unsafe Vertice(string name, Graph* origin, Graph* end)
    {
        this.Name = name;
        _prev = origin;
        _next = end;
    }
}