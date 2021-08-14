using System;

namespace carsBackEnd.Models
{
    public class Engine
    {
        public Guid Id { get; set; }
        public string EngineName { get; set; }
        public string GasType { get; set; }
        public string CylinderType { get; set; }
    }
}