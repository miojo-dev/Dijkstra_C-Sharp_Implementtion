using Microsoft.VisualBasic;

namespace Dijkstra_C_Sharp_Implementation;

public static class MainClass
{
    private static string? _input;
    public static bool Debug = false;

    public static void Main(string[] args)
    {
        Console.WriteLine("===== Starting Dijkstra's Algorithm =====");
        Console.WriteLine();
        Console.WriteLine("===== | Press any key to start | =====");
        _input = Console.ReadLine();
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
            Console.WriteLine("| 1: Search Path               |");
            Console.WriteLine("| 2: Exit                      |");
            Console.WriteLine("|______________________________|");
            _input = Console.ReadLine();

            switch (_input)
            {
                case "1":
                    SearchPath();
                    break;
                case "2":
                    return;
            }
        }
    }

    private static void SearchPath()
    {
        Console.WriteLine("What Vertex you wanna find?");
        var toFind = Console.ReadLine();

        Console.WriteLine("Where do you wanna start?");
        var toStart = Console.ReadLine();

        Console.Clear();

        var path = Dijkstra.FindPath(toStart, toFind);
        Dijkstra.PrintPath(path);
        
        Console.WriteLine();

        Console.ReadKey();

        GraphManager.ResetVertexArray();
    }
}