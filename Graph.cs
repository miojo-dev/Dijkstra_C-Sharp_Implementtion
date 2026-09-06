namespace Dijkstra_C_Sharp_Implementation;

public class Graph
{
    private int Degree { get; }
    private unsafe Vertex*[] Vertex { get; set; }

    public unsafe Graph(int degree)
    {
        this.Degree = degree;
        Vertex = new Vertex*[this.Degree];

        for (int i = 0; i < degree; i++)
        {
            Vertex[i] = null;
        }
    }
    
    public void AddEdge(Vertex vertex)
    {
    }
}