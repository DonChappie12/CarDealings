using System;

namespace carsBackEnd.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string StyleofCar { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public int MPG { get; set; }
        public string Warranty { get; set; }
        public string Drivetrain { get; set; }
        public string Description { get; set; }
        public string Wear { get; set; }

        // Todo: This is wear the engine class would be
        // public int MyProperty { get; set; }
    }
}