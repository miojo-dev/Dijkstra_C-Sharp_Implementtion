namespace Dijkstra_C_Sharp_Implementation;

public static class MainClass
{
    private static string? _input;
    public static bool Debug = false;

    private static readonly string[] GraphNames =
    [
        "N1", "N2", "ND1", "ND2", "ND3", "ND4", "ND5", "C1", "C2", "C3", "C4", "SD1", "SD2", "SD3", "SD4", "SD5", "SD6",
        "SD7", "SD8", "S1", "S2", "S3", "S4", "S5"
    ];

    private static readonly int[][] AdjecentList = new int[][]
    {
    };

    private static readonly int[][] IncidencyList = new int[][]
    {
    };

    private static readonly int[][] CostList = new int[][]
    {
    };


    public static void Main(string[] args)
    {
        Console.WriteLine("===== Starting Dijkstra's Algorithm =====");
        Console.WriteLine();
        Console.WriteLine("===== | Press any key to start | =====");
        Debug = _input == "debug";

        Menu();
    }

    private static void Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(" ___-~=+*#@ | Menu | @#*+=~-___ ");
            Console.WriteLine("|       Select an option       |");
            Console.WriteLine("|                              |");
            Console.WriteLine("| 1: Initialize Graphs         |");
            Console.WriteLine("| 2: Run Dijkstra's Algorithm  |");
            Console.WriteLine("| 3: Exit                      |");
            Console.WriteLine("|______________________________|");
            _input = Console.ReadLine();

            switch (_input)
            {
                case "1":
                    InitializeGraphs();
                    break;
                case "2":
                    break;
                case "3":
                    return;
            }
        }
    }

    private static void InitializeGraphs()
    {
        foreach (var vertex in GraphNames)
        {

        }
    }
}