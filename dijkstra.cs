namespace Dijkstra_C_Sharp_Implementation;

public static class Dijkstra
{
    public static void FindShortestPath(string start, string wanted)
    {
        if (start == wanted)
        {
            Console.WriteLine("Start and destiny Vertexes are the same");
            return;
        }

        Vertex startVertex = GraphManager.GetVertex(start);
        Vertex endVertex = GraphManager.GetVertex(wanted);
        Vertex currentVertex = startVertex;

        while (currentVertex != endVertex)
        {
            //if (currentVertex.)
        }
    }

    public static unsafe void Short(Vertex start, Vertex end)
    {
        if (start != end)
        {
            foreach (var vrtx in GraphManager.CostList)
            {
                
            }
        }
        else
        {
            
        }
    }
}