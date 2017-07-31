using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main()
    {
        var command = Console.ReadLine();
        ProcessCommand(command);
    }

    private static void ProcessCommand(string command)
    {
        Console.WriteLine($"{command}:");

        var suits = Enum.GetValues(typeof(CardSuits));
        foreach (var suit in suits)
        {
            Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
        }
    }
}
