using System;

namespace Ex15_2
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car(){Cost = 56, MaxSpeed = 120 },
                new Car(){Cost = 70, MaxSpeed = 150 },
                new Car(){Cost = 45, MaxSpeed = 180 },
                new Car(){Cost = 32, MaxSpeed = 200 },
                new Car(){Cost = 82, MaxSpeed = 280 },
            };

            //간단한 솔루션
            //var selected = from car in cars
            //               where car.Cost < 60
            //               orderby car.Cost 
            //               select new
            //               {
            //                   비용 = car.Cost,
            //                   최고속도 = car.MaxSpeed
            //               };

            //group by 활용 솔루션
            var selected = from car in cars
                           group car by car.Cost < 60 into g
                           select new
                           {
                               GroupKey = g.Key,
                               Info = g.Select(car => new
                               {
                                   비용 = car.Cost,
                                   최고속력 = car.MaxSpeed,
                               })
                           };
            foreach (var group in selected)
            {
                if (group.GroupKey == true)
                {
                    Console.WriteLine("Car.Cost  Car.MaxSpeed");
                    foreach (var car in group.Info)
                        Console.WriteLine($"{car.비용,+8}  {car.최고속력,+12}");
                }
            }
            
        }
    }
}