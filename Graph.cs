namespace Dijkstra_C_Sharp_Implementation;

public class Graph
{
    private int Degree { get; }
    private unsafe Vertex*[] conections { get; set; }

    public unsafe Graph(int degree)
    {
        this.Degree = degree;
        conections = new Vertex*[this.Degree];
    }
}