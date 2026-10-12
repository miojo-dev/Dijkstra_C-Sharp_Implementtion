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
    }

    public static Vertex[] FindPath(string start, string wanted)
    {
        Vertex[] path = new Vertex[] { };
        int starting = GraphManager.NameToId(start);
        int ending = GraphManager.NameToId(wanted);
        int current = ending;
        int i;

        for (i = 0; i < 24; i++)
        {
            if (GraphManager.NameToId(wanted) != i)
            {
                for (int j = 0; j < 24; j++)
                {
                    if (GraphManager.CostList[i][j] != GraphManager.BlockedPathCost)
                    {
                        if (GraphManager.CostList[i][j] < GraphManager.Vertexes[j].Weight)
                        {
                            GraphManager.Vertexes[j].ClosestVertex = i;
                            GraphManager.Vertexes[j].Weight = GraphManager.CostList[i][j];

                            if (i == starting)
                            {
                                GraphManager.Vertexes[j].Weight =
                                    GraphManager.CostList[i][j] + GraphManager.Vertexes[i].Weight;
                            }
                        }
                    }
                }
            }
        }

        i = 0;

        while (current != starting)
        {
            path[i] = GraphManager.Vertexes[current];
            i++;
            current = GraphManager.Vertexes[current].ClosestVertex;
        }
        
        return path.Reverse().ToArray();
    }
    
    public static void PrintPath(Vertex[] path, int totalCost)
    {
        if (path.Length == 0)
        {
            Console.WriteLine("Nenhum caminho encontrado.");
            return;
        }

        Console.Write("Caminho encontrado: ");

        for (int i = 0; i < path.Length; i++)
        {
            Console.Write(GraphManager.GraphNames[path[i].Id]);

            if (i < path.Length - 1)
            {
                Console.Write(" -> ");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Custo total: {totalCost}");
    }
}