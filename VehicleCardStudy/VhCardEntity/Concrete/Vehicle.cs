using System;
using System.Collections.Generic;

namespace VhCardEntity.Concrete
{
    public partial class Vehicle
    {
        public int Id { get; set; }
        public string? Plate { get; set; }
        public int? TypeId { get; set; }
        public int? ModelYear { get; set; }
        public string? Color { get; set; }
    }
}
