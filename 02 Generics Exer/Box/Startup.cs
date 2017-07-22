using System;
using System.Collections.Generic;
using System.Linq;

class Startup
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //IList<Box<string>> boxes = new List<Box<string>>();
        //IList<Box<int>> boxes = new List<Box<int>>();
        IList<Box<double>> boxes = new List<Box<double>>();

        for (int i = 0; i < n; i++)
        {
            //Box<string> box = new Box<string>(Console.ReadLine());
            //Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
            Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
            boxes.Add(box);
        }

        var input = Console.ReadLine().Split().Select(double.Parse).ToArray().FirstOrDefault();
        var comparator = new Box<double>(input);

        Console.WriteLine(comparator.Compare(boxes, input));
    }
}
