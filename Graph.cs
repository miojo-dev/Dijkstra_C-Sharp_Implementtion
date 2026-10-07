namespace Dijkstra_C_Sharp_Implementation;

public class Vertex
{
    public int Id;
    public int ClosestVertex;
    public int Weight = GraphManager.BlockedPathCost;
}