using System;

namespace TowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);
            bool isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);

            point = new Point(8, 5);
            isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap);

        }
    }
}