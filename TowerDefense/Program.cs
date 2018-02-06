using System;

namespace TowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);

            Point point2 = new Point(5, 3);

            Console.WriteLine(point.DistanceTo(point2));
        }
    }
}