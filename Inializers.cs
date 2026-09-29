namespace Dijkstra_C_Sharp_Implementation;

public static class GraphManager
{
    public static int BlockedPathCost = 1000;
    
    private static readonly string[] GraphNames =
    [
        "N1", "N2", "ND1", "ND2", "ND3", "ND4", "ND5", "C1", "C2", "C3", "C4", "SD1", "SD2", "SD3", "SD4", "SD5", "SD6",
        "SD7", "SD8", "S1", "S2", "S3", "S4", "S5"
    ];

    private static readonly int[][] AdjecentList =
    [
        [0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0],
        [0, 0, 1, 0, 0, 0, 0, 1, 0, 1 ,0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1],
        [0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
        [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0],
        [1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1],
        [0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0],
        [0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0]
    ];

    private static readonly int[][] IncidencyList =
    [
        [1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
        [0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0],
        [0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
        [0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0],
        [0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
        [0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0],
        [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0],
        [0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0]
    ];

    private static readonly int[][] CostList =
    [
        [BlockedPathCost, 10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 24, BlockedPathCost, BlockedPathCost, 28, BlockedPathCost, 26, BlockedPathCost, BlockedPathCost],
        [10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 22, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, 24, BlockedPathCost, 30, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, BlockedPathCost, BlockedPathCost, 22, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, 14, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, BlockedPathCost, 26, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, 28, BlockedPathCost, BlockedPathCost, 24],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 22, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 12, 14, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, BlockedPathCost, BlockedPathCost],
        [18, 22, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, BlockedPathCost, BlockedPathCost, 14, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, 12, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 12, BlockedPathCost, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, BlockedPathCost, 14, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [24, 18, BlockedPathCost, 22, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 16, 10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, 20, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, 10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [28, 24, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, 12, 16, 14, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, 12, 14, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, 28, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 10, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [26, 30, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, 16, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 12, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 26, BlockedPathCost, 22, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 14, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost],
        [BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 24, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 18, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, 20, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost, BlockedPathCost]
    ];

    private static readonly Vertex[] Vertexes =
    [
    ];

    public static void ResetGraphs()
    {
        foreach (var name in GraphNames)
        {
        }
    }

    public static Vertex GetVertex(string name)
    {
        var i = 0;
        while (Vertexes[i].GetName() != name)
        {
            i++;
        }

        return Vertexes[i];
    }
}