using System;

namespace PropertyPattern
{
    class Car
    {
        public string Model { get; set; }
        public DateTime ProducedAt { get; set; }
    }

    class MainApp
    {
        static string GetNickname(Car car)
        {
            var GenerateMessage = (Car car, string nickname) =>
            $"{car.Model} produced in {car.ProducedAt.Year} is {nickname}";

            return car switch
            {
                { Model: "Mustang", ProducedAt.Year: 1967 } => GenerateMessage(car, "Fastback"),
                { Model: "Mustang", ProducedAt.Year: 1976 } => GenerateMessage(car, "Cobra II"),
                _ => GenerateMessage(car, "Unknown")
            };

            //if (car is Car { Model: "Mustang", ProducedAt.Year: 1967 })
            //    return GenerateMessage(car, "Fastback");
            //else if (car is Car { Model: "Mustang", ProducedAt.Year: 1976 })
            //    return GenerateMessage(car, "Cobra II");
            //else
            //    return GenerateMessage(car, "Unknown");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(
                GetNickname( new Car() { Model = "Mustang", ProducedAt = new DateTime(1967, 11, 23) }));
            Console.WriteLine(
                GetNickname(new Car() { Model = "Mustang", ProducedAt = new DateTime(1976, 6, 7) }));
            Console.WriteLine(
                GetNickname(new Car() { Model = "Mustang", ProducedAt = new DateTime(2099, 12, 25) }));
        }
    }
}