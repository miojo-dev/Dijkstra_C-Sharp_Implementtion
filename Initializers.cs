namespace Dijkstra_C_Sharp_Implementation;

public static class GraphManager
{
    public const int BlockedPathCost = 1000;

    public static readonly string[] GraphNames =
    [
        "N1", "N2", "ND1", "ND2", "ND3", "ND4", "ND5", "C1", "C2", "C3", "C4", "SD1", "SD2", "SD3", "SD4", "SD5", "SD6",
        "SD7", "SD8", "S1", "S2", "S3", "S4", "S5"
    ];

    public static Vertex[] Vertexes =
    [
        new Vertex { Id = 0, Weight = BlockedPathCost },
        new Vertex { Id = 1, Weight = BlockedPathCost },
        new Vertex { Id = 2, Weight = BlockedPathCost },
        new Vertex { Id = 3, Weight = BlockedPathCost },
        new Vertex { Id = 4, Weight = BlockedPathCost },
        new Vertex { Id = 5, Weight = BlockedPathCost },
        new Vertex { Id = 6, Weight = BlockedPathCost },
        new Vertex { Id = 7, Weight = BlockedPathCost },
        new Vertex { Id = 8, Weight = BlockedPathCost },
        new Vertex { Id = 9, Weight = BlockedPathCost },
        new Vertex { Id = 10, Weight = BlockedPathCost },
        new Vertex { Id = 11, Weight = BlockedPathCost },
        new Vertex { Id = 12, Weight = BlockedPathCost },
        new Vertex { Id = 13, Weight = BlockedPathCost },
        new Vertex { Id = 14, Weight = BlockedPathCost },
        new Vertex { Id = 15, Weight = BlockedPathCost },
        new Vertex { Id = 16, Weight = BlockedPathCost },
        new Vertex { Id = 17, Weight = BlockedPathCost },
        new Vertex { Id = 18, Weight = BlockedPathCost },
        new Vertex { Id = 19, Weight = BlockedPathCost },
        new Vertex { Id = 20, Weight = BlockedPathCost },
        new Vertex { Id = 21, Weight = BlockedPathCost },
        new Vertex { Id = 22, Weight = BlockedPathCost },
        new Vertex { Id = 23, Weight = BlockedPathCost }
    ];

    public static readonly int[][] CostList =
    [
        [
            BlockedPathCost, 10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, 24, BlockedPathCost, BlockedPathCost, 28, BlockedPathCost, 26,
            BlockedPathCost, BlockedPathCost
        ],
        [
            10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 22, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, 24, BlockedPathCost, 30,
            BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, 12, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, 20, BlockedPathCost, BlockedPathCost, 22, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, 14, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, 20, BlockedPathCost, 26, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            14, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, 28,
            BlockedPathCost, BlockedPathCost, 24
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, 22, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, 12, 14, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16,
            18, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, 20, BlockedPathCost, BlockedPathCost
        ],
        [
            18, 22, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, BlockedPathCost, BlockedPathCost, 14,
            BlockedPathCost, 16, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 12,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, 18
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, 12, 16, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, 12, BlockedPathCost, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, BlockedPathCost, 14,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, 14, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            24, 18, BlockedPathCost, 22, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, 16, 10, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, 18, 20, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, 10,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, 20
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 12,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            28, 24, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, 12, 16, 14, 18, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, 12, 14, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, 28, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 10,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            26, 30, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, 16, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 12, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 26, BlockedPathCost, 22,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost
        ],
        [
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 24, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, BlockedPathCost, BlockedPathCost, BlockedPathCost,
            BlockedPathCost, BlockedPathCost, BlockedPathCost
        ]
    ];

    public static void ResetVertexArray()
    {
        foreach (var vertex in Vertexes)
        {
            vertex.Weight = BlockedPathCost;
            vertex.ClosestVertex = -1;
        }
    }

    public static int NameToId(string Name)
    {
        for (int i = 0; i < 24; i++)
        {
            if (GraphNames[i] == Name)
            {
                return i;
            }
        }

        return -1;
    }
}