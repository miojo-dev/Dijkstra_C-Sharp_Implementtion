using System;
using System.Diagnostics;

namespace Dijkstra_C_Sharp_Implementation;

public static class MainClass
{
    private static string? _input;
    public static bool Debug = false;

    public static void Main(string[] args)
    {
        Console.WriteLine("===== Starting Dijkstra's Algorithm =====");
        Console.WriteLine();
        Console.WriteLine("===== | Press enter key to start | =====");
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
            Console.WriteLine("| 1: Initialize Graphs         |");
            Console.WriteLine("| 2: Run Dijkstra's Algorithm  |");
            Console.WriteLine("| 3: Exit                      |");
            Console.WriteLine("|______________________________|");
            _input = Console.ReadLine();

            switch (_input)
            {
                case "1": InitializeGraphs();
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
    }
}