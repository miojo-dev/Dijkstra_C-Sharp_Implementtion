namespace Dijkstra_C_Sharp_Implementation;

public static class Dijkstra
{
    public static Vertex[] FindPath(string start, string wanted)
    {
        int starting = GraphManager.NameToId(start);
        int ending = GraphManager.NameToId(wanted);
        int count = GraphManager.Vertexes.Length;

        if (starting == -1 || ending == -1)
        {
            return [];
        }

        foreach (var vertex in GraphManager.Vertexes)
        {
            vertex.Weight = int.MaxValue;
            vertex.ClosestVertex = -1;
        }

        bool[] visited = new bool[count];
        GraphManager.Vertexes[starting].Weight = 0;

        for (int step = 0; step < count; step++)
        {
            int current = -1;

            for (int i = 0; i < count; i++)
            {
                if (!visited[i] &&
                    (current == -1 || GraphManager.Vertexes[i].Weight < GraphManager.Vertexes[current].Weight))
                {
                    current = i;
                }
            }

            if (current == -1 || GraphManager.Vertexes[current].Weight == int.MaxValue)
            {
                break;
            }

            visited[current] = true;

            for (int next = 0; next < count; next++)
            {
                int edgeCost = GraphManager.CostList[current][next];

                if (visited[next] || edgeCost == GraphManager.BlockedPathCost)
                {
                    continue;
                }

                int newDistance = GraphManager.Vertexes[current].Weight + edgeCost;
                if (newDistance < GraphManager.Vertexes[next].Weight)
                {
                    GraphManager.Vertexes[next].Weight = newDistance;
                    GraphManager.Vertexes[next].ClosestVertex = current;
                }
            }
        }

        if (GraphManager.Vertexes[ending].Weight == int.MaxValue)
        {
            return [];
        }

        List<Vertex> path = [];
        int pathNode = ending;
        while (pathNode != -1 && path.Count < count)
        {
            path.Add(GraphManager.Vertexes[pathNode]);
            if (pathNode == starting)
            {
                path.Reverse();
                return [.. path];
            }

            pathNode = GraphManager.Vertexes[pathNode].ClosestVertex;
        }

        return [];
    }

    public static void PrintPath(Vertex[] path)
    {
        if (path.Length == 0)
        {
            Console.WriteLine("Array is null or empty. No path found.");
        }
        else
        {
            Console.Write("Path: ");

            for (int i = 0; i < path.Length; i++)
            {
                Console.Write(GraphManager.GraphNames[path[i].Id]);

                if (i < path.Length - 1)
                {
                    Console.Write(" -> ");
                }
            }

            Console.WriteLine();
            Console.Write("Weight: ");

            for (int i = 0; i < path.Length; i++)
            {
                Console.Write(path[i].Weight);

                if (i < path.Length - 1)
                {
                    Console.Write(" -> ");
                }
            }
            
            Console.WriteLine();
            Console.Write($"Total Cost: {path[^1].Weight}");
        }
    }
}