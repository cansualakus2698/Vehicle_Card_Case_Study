using System;
using System.Collections.Generic;

namespace VhCardEntity.Concrete
{
    public partial class VehiclesType
    {
        public int TypeId { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public decimal? CapacityKg { get; set; }
        public decimal? CapacityM3 { get; set; }
    }
}
