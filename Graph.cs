namespace Dijkstra_C_Sharp_Implementation;

public class Graph
{
    private int Degree { get; }
    private unsafe Vertice*[] Vertices { get; set; }

    public unsafe Graph(int degree)
    {
        this.Degree = degree;
        Vertices = new Vertice*[this.Degree];

        for (int i = 0; i < degree; i++)
        {
            Vertices[i] = null;
        }
    }
    
    public void AddEdge(Vertice vertice)
    {
    }
}